using CcinoTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using CcinoTools.Lib;
using System.Collections.Concurrent;

namespace CcinoTools.Services {
  public class LogService {
    public static CcinoTool context { get; set; }
    private static ConcurrentDictionary<string, List<Ranking>> RANKING_CACHE = new ConcurrentDictionary<string, List<Ranking>>();
    private static List<Ranking> tryGetRaningsFromCache(string key) {
      if (RANKING_CACHE != null) {
        if (RANKING_CACHE.ContainsKey(key)) {
          return RANKING_CACHE[key];
        }
      } else {
        RANKING_CACHE = new ConcurrentDictionary<string, List<Ranking>>();
      }
      return null;
    }
    private static void saveRankingsToCache(string key,List<Ranking> rankings) {
      if (RANKING_CACHE == null) {
        RANKING_CACHE = new ConcurrentDictionary<string, List<Ranking>>();
      }
      RANKING_CACHE[key] = rankings;
    }

    public static int? GetRankingHighestLog(List<Ranking> rankings) {
      if (rankings == null || rankings.Count == 0) {
        return null;
      }
      return rankings.Max(r => r.percentile);
    }

    //US, EU, KR, TW, CN
    public static List<Ranking> GetRankings(string apiKey,string serverName,string characterName, int? zoneId=null, int? encounterId=null, string serverRegion="CN", bool today=false) {
      string cacheKey = $"{serverName}_{characterName}_{zoneId}_{encounterId}_{serverRegion}_{today}";
      //尝试从缓存读取
      List<Ranking> result = tryGetRaningsFromCache(cacheKey);
      if (result != null) {
        return result;
      }
      serverName = HttpUtility.UrlEncode(serverName);
      characterName = HttpUtility.UrlEncode(characterName);
      string timeframe = today ? "today" : "historical";
      string domain2 = "www";
      if (serverRegion.ToUpper() == "CN") {
        domain2 = "cn";
      }
      string url = $"https://{domain2}.fflogs.com/v1/rankings/character/{characterName}/{serverName}/{serverRegion}?timeframe={timeframe}&api_key={apiKey}";
      if (zoneId != null) {
        url += "&zone=" + zoneId;
        if (encounterId != null) {
          url += "&encounter=" + encounterId;
        }
      }
      var list = Utils.httpGet(url).toObject<List<Ranking>>();
      //callback
      list = list.Where(r => {
        if (r.encounterID >= 65 && r.encounterID <= 68) {
          //伊甸排除普通难度
          return r.difficulty == 101;
        }
        return true;
      }).ToList();
      //保存数据到缓存
      saveRankingsToCache(cacheKey, list);
      return list;
    }

    public static List<Zone> GetZones(string apiKey,string serverRegion = "CN") {
      string domain2 = "www";
      if (serverRegion.ToUpper() == "CN") {
        domain2 = "cn";
      }
      string url = $"https://{domain2}.fflogs.com/v1/zones?api_key={apiKey}";
      var list = Utils.httpGet(url).toObject<List<Zone>>();
      return list;
    }
  }
}
