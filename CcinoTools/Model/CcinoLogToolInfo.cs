using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcinoTools.Model {
  public class CcinoLogToolInfo {
    public Character character { get; set; }
    public List<Ranking> rankings { get; set; }
    public int? highestLog { get; set; }
  }
}
