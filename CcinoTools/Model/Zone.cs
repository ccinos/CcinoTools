﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcinoTools.Model {
  public class Zone {
    public int? id { get; set; }
    public string name { get; set; }
    public List<Encounter> encounters { get; set; }
    public Bracket brackets { get; set; }
    public override string ToString() {
      if (brackets != null) {
        return $"{this.name} ({this.brackets.min} - {this.brackets.max})";
      } else {
        return this.name;
      }
    }

    public static string initAllZoneData() {
      return "[{\"id\":2,\"name\":\"Dungeons (Endgame)\",\"encounters\":[{\"id\":4500,\"name\":\"空中神域不获岛\"},{\"id\":4501,\"name\":\"博物战舰无限回廊\"},{\"id\":4502,\"name\":\"草木庭园圣茉夏娜植物园\"},{\"id\":4503,\"name\":\"地脉灵灯天狼星灯塔\"},{\"id\":4504,\"name\":\"星海空间颠倒塔\"},{\"id\":4505,\"name\":\"神圣遗迹无限城市街古迹\"},{\"id\":4506,\"name\":\"天龙宫殿忆罪宫\"},{\"id\":4507,\"name\":\"黑涡传说破舰岛\"},{\"id\":4508,\"name\":\"险峻峡谷塞尔法特尔溪谷\"},{\"id\":4509,\"name\":\"秘本宝库迦巴勒幻想图书馆\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":4,\"name\":\"Trials (Extreme)\",\"encounters\":[{\"id\":1027,\"name\":\"俾斯麦\"},{\"id\":1028,\"name\":\"罗波那\"},{\"id\":1029,\"name\":\"骑神托尔丹\"},{\"id\":1031,\"name\":\"萨菲洛特\"},{\"id\":1033,\"name\":\"尼德霍格\"},{\"id\":1034,\"name\":\"索菲娅\"},{\"id\":1035,\"name\":\"祖尔宛\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":5,\"name\":\"Void Ark\",\"encounters\":[{\"id\":2000,\"name\":\"刻托\"},{\"id\":2001,\"name\":\"天柱树\"},{\"id\":2002,\"name\":\"丘库雷因\"},{\"id\":2003,\"name\":\"艾奇德娜\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":6,\"name\":\"Alexander: Gordias (Story)\",\"encounters\":[{\"id\":14,\"name\":\"压迫者\"},{\"id\":15,\"name\":\"戈耳狄俄斯之袖\"},{\"id\":16,\"name\":\"有生命活水\"},{\"id\":17,\"name\":\"操纵者\"},{\"id\":5000,\"name\":\"浮士德\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":7,\"name\":\"Alexander: Gordias (Savage)\",\"encounters\":[{\"id\":18,\"name\":\"压迫者\"},{\"id\":19,\"name\":\"戈耳狄俄斯之袖\"},{\"id\":20,\"name\":\"有生命活水\"},{\"id\":21,\"name\":\"操纵者\"},{\"id\":5001,\"name\":\"浮士德\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":8,\"name\":\"The Weeping City of Mhach\",\"encounters\":[{\"id\":2004,\"name\":\"阿剌克涅\"},{\"id\":2005,\"name\":\"弗加尔\"},{\"id\":2006,\"name\":\"奥兹玛\"},{\"id\":2007,\"name\":\"卡洛菲斯提莉\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":9,\"name\":\"Alexander: Midas (Story)\",\"encounters\":[{\"id\":22,\"name\":\"奇才 拉特芬克斯\"},{\"id\":23,\"name\":\"环旋者\"},{\"id\":24,\"name\":\"万事通 奎克辛克斯\"},{\"id\":25,\"name\":\"残暴正义号\"},{\"id\":5002,\"name\":\"新型浮士德\"},{\"id\":5003,\"name\":\"爆破者\"},{\"id\":5004,\"name\":\"争斗者\"},{\"id\":5005,\"name\":\"欺诈者\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":10,\"name\":\"Alexander: Midas (Savage)\",\"encounters\":[{\"id\":26,\"name\":\"奇才 拉特芬克斯\"},{\"id\":27,\"name\":\"弥达斯之袖\"},{\"id\":28,\"name\":\"万事通 奎克辛克斯\"},{\"id\":29,\"name\":\"残暴正义号\"},{\"id\":5006,\"name\":\"新型浮士德\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":12,\"name\":\"Alexander: The Creator (Story)\",\"encounters\":[{\"id\":30,\"name\":\"废品翻新装置\"},{\"id\":31,\"name\":\"佣兵雷姆普里克斯\"},{\"id\":32,\"name\":\"巡航驱逐者\"},{\"id\":33,\"name\":\"至尊亚历山大\"},{\"id\":5007,\"name\":\"终极浮士德\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":13,\"name\":\"Alexander: The Creator (Savage)\",\"encounters\":[{\"id\":34,\"name\":\"废品翻新装置\"},{\"id\":35,\"name\":\"佣兵雷姆普里克斯\"},{\"id\":36,\"name\":\"巡航驱逐者\"},{\"id\":37,\"name\":\"至尊亚历山大\"},{\"id\":5008,\"name\":\"终极浮士德\"}],\"brackets\":{\"min\":3.0,\"max\":3.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":14,\"name\":\"Dungeons (Endgame)\",\"encounters\":[{\"id\":4510,\"name\":\"鏖战红莲阿拉米格\"},{\"id\":4511,\"name\":\"恶党孤城黄金阁\"},{\"id\":4512,\"name\":\"修行古刹星导寺\"},{\"id\":4513,\"name\":\"沉没神殿斯卡拉遗迹\"},{\"id\":4514,\"name\":\"红玉火山狱之盖\"},{\"id\":4515,\"name\":\"疯狂战舰无限回廊\"},{\"id\":4516,\"name\":\"风水灵庙岩燕庙\"},{\"id\":4517,\"name\":\"死亡大地终末焦土\"},{\"id\":4518,\"name\":\"污染庭园圣茉夏娜植物园\"},{\"id\":4519,\"name\":\"国境战线基姆利特暗区\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":15,\"name\":\"Trials (Extreme)\",\"encounters\":[{\"id\":1036,\"name\":\"须佐之男\"},{\"id\":1037,\"name\":\"吉祥天女\"},{\"id\":1038,\"name\":\"神龙\"},{\"id\":1040,\"name\":\"白虎\"},{\"id\":1041,\"name\":\"月读\"},{\"id\":1043,\"name\":\"朱雀\"},{\"id\":1044,\"name\":\"青龙\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":16,\"name\":\"Omega: Deltascape (Story)\",\"encounters\":[{\"id\":38,\"name\":\"老者\"},{\"id\":39,\"name\":\"灾变者\"},{\"id\":40,\"name\":\"哈利卡纳苏斯\"},{\"id\":41,\"name\":\"艾克斯迪司\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":17,\"name\":\"Omega: Deltascape (Savage)\",\"encounters\":[{\"id\":42,\"name\":\"老者\"},{\"id\":43,\"name\":\"灾变者\"},{\"id\":44,\"name\":\"哈利卡纳苏斯\"},{\"id\":45,\"name\":\"艾克斯迪司\"},{\"id\":46,\"name\":\"新生艾克斯迪司\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":18,\"name\":\"The Royal City of Rabanastre\",\"encounters\":[{\"id\":2008,\"name\":\"背德皇帝马提乌斯\"},{\"id\":2009,\"name\":\"统治者哈修马利姆\"},{\"id\":2010,\"name\":\"人马王洛弗卡勒\"},{\"id\":2011,\"name\":\"冷血剑阿加斯\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":19,\"name\":\"The Unending Coil of Bahamut\",\"encounters\":[{\"id\":1039,\"name\":\"至尊巴哈姆特\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":20,\"name\":\"Omega: Sigmascape (Story)\",\"encounters\":[{\"id\":47,\"name\":\"魔列车\"},{\"id\":48,\"name\":\"恶魔查达奴克\"},{\"id\":49,\"name\":\"守护者\"},{\"id\":50,\"name\":\"凯夫卡\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":21,\"name\":\"Omega: Sigmascape (Savage)\",\"encounters\":[{\"id\":51,\"name\":\"魔列车\"},{\"id\":52,\"name\":\"恶魔查达奴克\"},{\"id\":53,\"name\":\"守护者\"},{\"id\":54,\"name\":\"凯夫卡\"},{\"id\":55,\"name\":\"神圣凯夫卡\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":22,\"name\":\"The Ridorana Lighthouse\",\"encounters\":[{\"id\":2012,\"name\":\"暗黑之云法姆弗里特\"},{\"id\":2013,\"name\":\"魔人贝利亚斯\"},{\"id\":2014,\"name\":\"劳动七号\"},{\"id\":2015,\"name\":\"鬼龙雅兹玛特\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":23,\"name\":\"The Weapon's Refrain\",\"encounters\":[{\"id\":1042,\"name\":\"究极神兵\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":24,\"name\":\"Omega: Alphascape (Story)\",\"encounters\":[{\"id\":56,\"name\":\"卡奥斯\"},{\"id\":57,\"name\":\"尘世幻龙\"},{\"id\":58,\"name\":\"欧米茄\"},{\"id\":59,\"name\":\"双生欧米茄\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":25,\"name\":\"Omega: Alphascape (Savage)\",\"encounters\":[{\"id\":60,\"name\":\"卡奥斯\"},{\"id\":61,\"name\":\"尘世幻龙\"},{\"id\":62,\"name\":\"欧米茄\"},{\"id\":63,\"name\":\"双生欧米茄\"},{\"id\":64,\"name\":\"至尊欧米茄\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":26,\"name\":\"The Orbonne Monastery\",\"encounters\":[{\"id\":2016,\"name\":\"机工士姆斯塔迪奥\"},{\"id\":2017,\"name\":\"圣骑士阿格莉亚丝\"},{\"id\":2018,\"name\":\"雷神西德\"},{\"id\":2019,\"name\":\"圣天使阿尔蒂玛\"}],\"brackets\":{\"min\":4.0,\"max\":4.5,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":27,\"name\":\"Dungeons (Endgame)\",\"encounters\":[{\"id\":4520,\"name\":\"末日暗影亚马乌罗提\"},{\"id\":4521,\"name\":\"异界遗构希尔科斯孪晶塔\"},{\"id\":4522,\"name\":\"创造机构阿尼德罗学院\"},{\"id\":4523,\"name\":\"The Grand Cosmos\"}],\"brackets\":{\"min\":5.0,\"max\":5.1,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":28,\"name\":\"Trials (Extreme)\",\"encounters\":[{\"id\":1045,\"name\":\"缇坦妮雅\"},{\"id\":1046,\"name\":\"无瑕灵君\"},{\"id\":1049,\"name\":\"哈迪斯\"}],\"brackets\":{\"min\":5.0,\"max\":5.1,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":29,\"name\":\"Eden's Gate\",\"encounters\":[{\"id\":65,\"name\":\"Eden Prime\"},{\"id\":66,\"name\":\"虚空行者\"},{\"id\":67,\"name\":\"利维亚桑\"},{\"id\":68,\"name\":\"泰坦\"}],\"brackets\":{\"min\":5.0,\"max\":5.1,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":30,\"name\":\"Ultimates (Stormblood)\",\"encounters\":[{\"id\":1047,\"name\":\"巴哈姆特绝境战\"},{\"id\":1048,\"name\":\"究极神兵绝境战\"}],\"brackets\":{\"min\":5.0,\"max\":5.1,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":31,\"name\":\"The Copied Factory\",\"encounters\":[{\"id\":2020,\"name\":\"Serial-Jointed Command Model\"},{\"id\":2021,\"name\":\"Hobbes\"},{\"id\":2022,\"name\":\"Engels\"},{\"id\":2023,\"name\":\"9S-Operated Walking Fortress\"}],\"brackets\":{\"min\":5.0,\"max\":5.1,\"bucket\":0.1,\"type\":\"版本\"}},{\"id\":32,\"name\":\"Ultimates\",\"encounters\":[{\"id\":1050,\"name\":\"The Epic of Alexander\"}],\"brackets\":{\"min\":5.0,\"max\":5.1,\"bucket\":0.1,\"type\":\"版本\"}}]";
    }
  }
}
