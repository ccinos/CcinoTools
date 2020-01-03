using Microsoft.VisualStudio.TestTools.UnitTesting;
using CcinoTools.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CcinoTools.Services;
using CcinoTools.Model;

namespace CcinoTools.Lib.Tests {
  [TestClass()]
  public class UtilsTests {
    [TestMethod()]
    public void httpGetTest() {
      Console.WriteLine(LogService.GetZones("1dec8751508fa8e36cde7c53b550b69b").toJson().toJson());
    }
  }
}