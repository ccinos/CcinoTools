using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcinoTools.Model {
  public class Character {
    public static List<string> SERVER_LIST = new List<string> {
      "红玉海","神意之地","拉诺西亚","幻影群岛","萌芽池","宇宙和音","沃仙曦染","晨曦王座",
      "白银乡","白金幻象","神拳痕","潮风亭","旅人栈桥","拂晓之间","龙巢神殿",
      "紫水栈桥","延夏","静语庄园","摩杜纳","海猫茶屋","柔风海湾","琥珀原"
    };
    public Character(string fullname) {
      foreach(var server in SERVER_LIST) {
        if (fullname.EndsWith(server)) {
          if (fullname == server) {
            this.name = fullname;
          } else { 
            this.server = server;
            this.name = fullname.Substring(0, fullname.Length - server.Length);
          }
          if(!string.IsNullOrEmpty(this.server))
            this.server = this.server.Trim();
          if(!string.IsNullOrEmpty(this.name))
            this.name = this.name.Trim();
          return;
        }
      }
      this.name = fullname;
    }
    public string name { get; set; }
    public string server { get; set; }

    public override string ToString() {
      return this.name+(this.server!=null?"❀"+this.server:"");
    }
  }
}
