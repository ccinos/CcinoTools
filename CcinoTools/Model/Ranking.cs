using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcinoTools.Model {
  public class Ranking {
    public int encounterID { get; set; }
    public string encounterName { get; set; }
    public string spec { get; set; }
    public int difficulty { get; set; }
    public string characterName { get; set; }
    public string server { get; set; }
    public int percentile { get; set; }
    public double total { get; set; }
  }
}