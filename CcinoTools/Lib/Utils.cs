using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CcinoTools.Lib {
  public static class Utils {

    public static T toObject<T>(this string s) {
      return JsonConvert.DeserializeObject<T>(s);
    }

    public static string toJson(this object o) {
      return JsonConvert.SerializeObject(o);
    }

    public static string padStr(this object str, int length, string appendStr) {
      if (str == null) return string.Empty;

      int len = length * 2;
      //aequilateLength为中英文等宽长度,cutLength为要截取的字符串长度
      int aequilateLength = 0, cutLength = 0;
      Encoding encoding = Encoding.GetEncoding("gb2312");

      string cutStr = str.ToString();
      int strLength = cutStr.Length;
      byte[] bytes;
      for (int i = 0; i < strLength; i++) {
        bytes = encoding.GetBytes(cutStr.Substring(i, 1));
        if (bytes.Length == 2)//不是英文
          aequilateLength += 2;
        else
          aequilateLength++;

        if (aequilateLength <= len) cutLength += 1;

        if (aequilateLength > len)
          return cutStr.Substring(0, cutLength) + appendStr;
      }
      return cutStr;
    }

    public static Task<string> httpGetAsync(string url) {
      return new Task<string>(()=> {
        return httpGet(url);
      });
    }

    public static string httpGet(string url) {
      WebRequest myWebRequest = WebRequest.Create(url);
      WebResponse myWebResponse = myWebRequest.GetResponse();
      Stream ReceiveStream = myWebResponse.GetResponseStream();
      string responseStr = "";
      if (ReceiveStream != null) {
        StreamReader reader = new StreamReader(ReceiveStream, Encoding.UTF8);
        responseStr = reader.ReadToEnd();
        reader.Close();
      }
      myWebResponse.Close();
      return responseStr;
    }
  }
}
