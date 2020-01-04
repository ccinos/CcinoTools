using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Net;
using CcinoTools.Model;
using CcinoTools.Lib;
using CcinoTools.Services;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CcinoTools {
  public class CcinoTool : UserControl, IActPluginV1 {
    #region Designer Created Code (Avoid editing)
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tbLogs = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbApiKey = new System.Windows.Forms.TextBox();
      this.cbZones = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cbEncounters = new System.Windows.Forms.ComboBox();
      this.btnInitZone = new System.Windows.Forms.Button();
      this.cbLocalServer = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cbEnable = new System.Windows.Forms.CheckBox();
      this.tbTestName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tbTestServer = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btnTest = new System.Windows.Forms.Button();
      this.cbEnterTeamCheck = new System.Windows.Forms.CheckBox();
      this.cbTypeLogsCheck = new System.Windows.Forms.CheckBox();
      this.cbPlayTts = new System.Windows.Forms.CheckBox();
      this.label7 = new System.Windows.Forms.Label();
      this.cbMiniParseEnable = new System.Windows.Forms.CheckBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbLogs
      // 
      this.tbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbLogs.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLogs.Location = new System.Drawing.Point(455, 4);
      this.tbLogs.Multiline = true;
      this.tbLogs.Name = "tbLogs";
      this.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLogs.Size = new System.Drawing.Size(496, 530);
      this.tbLogs.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(34, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "apiKey";
      // 
      // tbApiKey
      // 
      this.tbApiKey.Location = new System.Drawing.Point(81, 100);
      this.tbApiKey.Name = "tbApiKey";
      this.tbApiKey.Size = new System.Drawing.Size(273, 21);
      this.tbApiKey.TabIndex = 4;
      this.tbApiKey.Text = "1dec8751508fa8e36cde7c53b550b69b";
      // 
      // cbZones
      // 
      this.cbZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbZones.FormattingEnabled = true;
      this.cbZones.Location = new System.Drawing.Point(81, 154);
      this.cbZones.Name = "cbZones";
      this.cbZones.Size = new System.Drawing.Size(273, 20);
      this.cbZones.TabIndex = 5;
      this.cbZones.SelectedIndexChanged += new System.EventHandler(this.cbZones_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(46, 157);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 12);
      this.label3.TabIndex = 6;
      this.label3.Text = "区域";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(46, 183);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 12);
      this.label4.TabIndex = 7;
      this.label4.Text = "副本";
      // 
      // cbEncounters
      // 
      this.cbEncounters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEncounters.FormattingEnabled = true;
      this.cbEncounters.Location = new System.Drawing.Point(81, 180);
      this.cbEncounters.Name = "cbEncounters";
      this.cbEncounters.Size = new System.Drawing.Size(273, 20);
      this.cbEncounters.TabIndex = 8;
      // 
      // btnInitZone
      // 
      this.btnInitZone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.btnInitZone.Location = new System.Drawing.Point(81, 127);
      this.btnInitZone.Name = "btnInitZone";
      this.btnInitZone.Size = new System.Drawing.Size(273, 21);
      this.btnInitZone.TabIndex = 9;
      this.btnInitZone.Text = "重新读取区域副本";
      this.btnInitZone.UseVisualStyleBackColor = true;
      this.btnInitZone.Click += new System.EventHandler(this.btnInitZone_Click);
      // 
      // cbLocalServer
      // 
      this.cbLocalServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbLocalServer.FormattingEnabled = true;
      this.cbLocalServer.Location = new System.Drawing.Point(81, 206);
      this.cbLocalServer.Name = "cbLocalServer";
      this.cbLocalServer.Size = new System.Drawing.Size(273, 20);
      this.cbLocalServer.TabIndex = 11;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(10, 209);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(65, 12);
      this.label5.TabIndex = 10;
      this.label5.Text = "当前服务器";
      // 
      // cbEnable
      // 
      this.cbEnable.AutoSize = true;
      this.cbEnable.Location = new System.Drawing.Point(81, 8);
      this.cbEnable.Name = "cbEnable";
      this.cbEnable.Size = new System.Drawing.Size(72, 16);
      this.cbEnable.TabIndex = 12;
      this.cbEnable.Text = "功能启用";
      this.cbEnable.UseVisualStyleBackColor = true;
      // 
      // tbTestName
      // 
      this.tbTestName.Location = new System.Drawing.Point(81, 440);
      this.tbTestName.Name = "tbTestName";
      this.tbTestName.Size = new System.Drawing.Size(273, 21);
      this.tbTestName.TabIndex = 14;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(34, 443);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 12);
      this.label1.TabIndex = 13;
      this.label1.Text = "角色名";
      // 
      // tbTestServer
      // 
      this.tbTestServer.Location = new System.Drawing.Point(81, 467);
      this.tbTestServer.Name = "tbTestServer";
      this.tbTestServer.Size = new System.Drawing.Size(273, 21);
      this.tbTestServer.TabIndex = 16;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(34, 470);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(41, 12);
      this.label6.TabIndex = 15;
      this.label6.Text = "服务器";
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(81, 494);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(273, 21);
      this.btnTest.TabIndex = 17;
      this.btnTest.Text = "测试读取";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // cbEnterTeamCheck
      // 
      this.cbEnterTeamCheck.AutoSize = true;
      this.cbEnterTeamCheck.Location = new System.Drawing.Point(81, 34);
      this.cbEnterTeamCheck.Name = "cbEnterTeamCheck";
      this.cbEnterTeamCheck.Size = new System.Drawing.Size(96, 16);
      this.cbEnterTeamCheck.TabIndex = 18;
      this.cbEnterTeamCheck.Text = "入队自动检测";
      this.cbEnterTeamCheck.UseVisualStyleBackColor = true;
      // 
      // cbTypeLogsCheck
      // 
      this.cbTypeLogsCheck.AutoSize = true;
      this.cbTypeLogsCheck.Checked = true;
      this.cbTypeLogsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbTypeLogsCheck.Location = new System.Drawing.Point(81, 56);
      this.cbTypeLogsCheck.Name = "cbTypeLogsCheck";
      this.cbTypeLogsCheck.Size = new System.Drawing.Size(150, 16);
      this.cbTypeLogsCheck.TabIndex = 19;
      this.cbTypeLogsCheck.Text = "输入\"logs 玩家名\"查询";
      this.cbTypeLogsCheck.UseVisualStyleBackColor = true;
      // 
      // cbPlayTts
      // 
      this.cbPlayTts.AutoSize = true;
      this.cbPlayTts.Checked = true;
      this.cbPlayTts.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbPlayTts.Location = new System.Drawing.Point(81, 78);
      this.cbPlayTts.Name = "cbPlayTts";
      this.cbPlayTts.Size = new System.Drawing.Size(72, 16);
      this.cbPlayTts.TabIndex = 20;
      this.cbPlayTts.Text = "语音播报";
      this.cbPlayTts.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label7.ForeColor = System.Drawing.Color.Red;
      this.label7.Location = new System.Drawing.Point(8, 343);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(419, 73);
      this.label7.TabIndex = 21;
      this.label7.Text = "注意：LOGS不代表玩家真实水平，请不要通过LOGS做出影响其他玩家正常游戏的行为。";
      // 
      // cbMiniParseEnable
      // 
      this.cbMiniParseEnable.AutoSize = true;
      this.cbMiniParseEnable.Location = new System.Drawing.Point(12, 260);
      this.cbMiniParseEnable.Name = "cbMiniParseEnable";
      this.cbMiniParseEnable.Size = new System.Drawing.Size(366, 16);
      this.cbMiniParseEnable.TabIndex = 22;
      this.cbMiniParseEnable.Text = "悬浮窗支持(需要搭配cactbot悬浮窗使用，使用下面的模板地址)";
      this.cbMiniParseEnable.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(95, 285);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(354, 21);
      this.textBox1.TabIndex = 23;
      this.textBox1.Text = "https://ccinos.gitee.io/act_dps_show/logtool.html";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(95, 307);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(354, 21);
      this.textBox2.TabIndex = 24;
      this.textBox2.Text = "https://ccinos.gitee.io/act_dps_show/";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(24, 288);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(65, 12);
      this.label8.TabIndex = 25;
      this.label8.Text = "只显示Logs";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(18, 310);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(71, 12);
      this.label9.TabIndex = 26;
      this.label9.Text = "dps模板集成";
      // 
      // CcinoTool
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.cbMiniParseEnable);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.cbPlayTts);
      this.Controls.Add(this.cbTypeLogsCheck);
      this.Controls.Add(this.cbEnterTeamCheck);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.tbTestServer);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.tbTestName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbEnable);
      this.Controls.Add(this.cbLocalServer);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnInitZone);
      this.Controls.Add(this.cbEncounters);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cbZones);
      this.Controls.Add(this.tbApiKey);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbLogs);
      this.Name = "CcinoTool";
      this.Size = new System.Drawing.Size(954, 537);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox tbLogs;
    private Label label2;
    private TextBox tbApiKey;
    private ComboBox cbZones;
    private Label label3;
    private Label label4;
    private ComboBox cbEncounters;
    private Button btnInitZone;
    private ComboBox cbLocalServer;
    private CheckBox cbEnable;
    private TextBox tbTestName;
    private Label label1;
    private TextBox tbTestServer;
    private Label label6;
    private Button btnTest;
    private CheckBox cbEnterTeamCheck;
    private CheckBox cbTypeLogsCheck;
    private CheckBox cbPlayTts;
    private Label label7;
    private CheckBox cbMiniParseEnable;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label8;
    private Label label9;
    private Label label5;

    #endregion
    public CcinoTool() {
      InitializeComponent();
      LogService.context = this;
      initServers();
    }

    Label lblStatus;    // 插件管理信息标签
    string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\CcinoTools.config.xml");
    SettingsSerializer xmlSettings;

    private List<Zone> zones;

    #region IActPluginV1 Members
    public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText) {
      pluginScreenSpace.Text = "Logs警察_Ccino";
      lblStatus = pluginStatusText; 
      pluginScreenSpace.Controls.Add(this);  
      this.Dock = DockStyle.Fill;
      xmlSettings = new SettingsSerializer(this);
      //-----------初始化zone数据
      initZone();
      //-----------读取设置
      LoadSettings();

      //-----------样式重新设定
      cbZones.DropDownStyle = ComboBoxStyle.DropDownList;
      cbEncounters.DropDownStyle = ComboBoxStyle.DropDownList;
      cbLocalServer.DropDownStyle = ComboBoxStyle.DropDownList;


      // Create some sort of parsing event handler.  After the "+=" hit TAB twice and the code will be generated for you.
      ActGlobals.oFormActMain.OnLogLineRead += this.OFormActMain_OnLogLineRead;

      lblStatus.Text = "插件已加载 v0.1";
    }

    private void initServers() {
      foreach(var server in Character.SERVER_LIST) {
        this.cbLocalServer.Items.Add(server);
      }
      this.cbLocalServer.SelectedIndex = 0;
    }


    private Regex enterTeamRegex = new Regex(@"(?<name>[^:]*?)加入了小队");
    private Regex typeLogsRegex = new Regex(@"logs\s+(?<name>[^:\s]*)");
    private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo) {
      if (!this.cbEnable.Checked) return;
      if (!isImport) {
        string logLine = logInfo.logLine;
        //----初始化
        //加入了跨服小队      自己进入
        //成立了跨服小队      自己进入
        //----结束
        //解散了跨服小队      解散
        //跨服小队解散了      解散
        //离开了()的小队      自己退出
        //----单条数据加入
        //神圣天使兽幻影群岛加入了小队。   队员进入
        //----单条数据删除
        //迪罗里安宇宙和音离开了小队。     队员离开
        // logs 迪罗里安宇宙和音
        Regex regex=null;
        if (cbEnterTeamCheck.Checked&&logLine.IndexOf("加入了小队") != -1){
          regex = enterTeamRegex;
        }else if (cbTypeLogsCheck.Checked&&logLine.IndexOf("logs") != -1){
          regex = typeLogsRegex;
        }
        if (regex != null) {
          Match m = regex.Match(logLine);
          if (m != null) {
            Group g = m.Groups["name"];
            if (g != null) {
              playlogs(new Character(g.Value));
            }
          }
        }
      }
    }
    public void log(object o) {
      if (o == null) return;
      log(o.ToString());
    }
    public void log(string logLine) {
      if (this.InvokeRequired) {
        this.Invoke(new MethodInvoker(()=> {
          log(logLine);
        }));
      } else {
        logLine = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": " + logLine + "\r\n";
        this.tbLogs.Text = logLine + this.tbLogs.Text;
      }
    }

    public void DeInitPlugin() {
      // 卸载所有事件
      ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;

      SaveSettings();
      lblStatus.Text = "插件已退出";
    }
    #endregion

    void LoadSettings() {
      //--在这里添加对控件的配置
      //xmlSettings.AddControlSetting(tbLogs.Name, tbLogs);
      xmlSettings.AddControlSetting(tbApiKey.Name, tbApiKey);
      xmlSettings.AddControlSetting(cbZones.Name, cbZones);
      xmlSettings.AddControlSetting(cbEncounters.Name, cbEncounters);
      xmlSettings.AddControlSetting(cbLocalServer.Name, cbLocalServer);
      xmlSettings.AddControlSetting(tbTestName.Name, tbTestName);
      xmlSettings.AddControlSetting(tbTestServer.Name, tbTestServer);
      xmlSettings.AddControlSetting(cbTypeLogsCheck.Name, cbTypeLogsCheck);
      xmlSettings.AddControlSetting(cbEnterTeamCheck.Name, cbEnterTeamCheck);
      xmlSettings.AddControlSetting(cbPlayTts.Name, cbPlayTts);
      xmlSettings.AddControlSetting(cbMiniParseEnable.Name, cbMiniParseEnable);

      //------------------------------
      if (File.Exists(settingsFile)) {
        FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        XmlTextReader xReader = new XmlTextReader(fs);

        try {
          while (xReader.Read()) {
            if (xReader.NodeType == XmlNodeType.Element) {
              if (xReader.LocalName == "SettingsSerializer") {
                xmlSettings.ImportFromXml(xReader);
              }
            }
          }
        } catch (Exception ex) {
          lblStatus.Text = "读取配置文件出错: " + ex.Message;
        }
        xReader.Close();
      }
    }
    void SaveSettings() {
      FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
      XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
      xWriter.Formatting = Formatting.Indented;
      xWriter.Indentation = 4;
      xWriter.IndentChar = ' ';
      xWriter.WriteStartDocument(true);
      xWriter.WriteStartElement("Config");    // <Config>
      xWriter.WriteStartElement("SettingsSerializer");    // <Config><SettingsSerializer>
      xmlSettings.ExportToXml(xWriter);   // Fill the SettingsSerializer XML
      xWriter.WriteEndElement();  // </SettingsSerializer>
      xWriter.WriteEndElement();  // </Config>
      xWriter.WriteEndDocument(); // Tie up loose ends (shouldn't be any)
      xWriter.Flush();    // Flush the file buffer to disk
      xWriter.Close();
    }


    private void playlogs(Character character) {
      if (string.IsNullOrWhiteSpace(character.name)) {
        return;
      }
      if (string.IsNullOrWhiteSpace(character.server)) {
        character.server = SelectedLocalServer;
      }
      try {
        Task.Run(() => {
          try {
            var rankings = LogService.GetRankings(ApiKey, character.server, character.name, SelectedZoneId, SelectedEncounterId, SelectedServerRegion);
            int? highestLog = LogService.GetRankingHighestLog(rankings);
            string logstr = (highestLog == null ? "无log" : highestLog.Value.ToString());
            //输出语音
            if (cbPlayTts.Checked) {
              ActGlobals.oFormActMain.PlayTtsWavIntermediary(character.name + ":" + logstr);
            }
            //输出详细内容
            log("=============================");
            for(int i = rankings.Count - 1; i >= 0; i--) {
              var ranking = rankings[i];
              log($"{ranking.encounterName}({ranking.spec})  {ranking.percentile}");
            }
            log("-----------------------------");
            log(character.name + "❀" + character.server + " \t " + logstr);
            //输出到logs中（用于悬浮窗监听）
            if (cbMiniParseEnable.Checked) {
              string newLogLine = "CCINO_LOG_TOOL_INFO:";
              newLogLine += new CcinoLogToolInfo() { highestLog = highestLog, character = character, rankings = rankings }.toJson();
              ActGlobals.oFormActMain.ParseRawLogLine(false, DateTime.Now, newLogLine);
            }
          } catch(Exception ex) {
            log(ex.Message);
          }
        });
      } catch (Exception ex) {
        log(ex.Message);
      }
    }




    private string SelectedLocalServer {
      get {
        return this.cbLocalServer.SelectedItem.ToString();
      }
    }
    private string SelectedServerRegion {
      get {
        return "CN";
      }
    }
    private int? SelectedEncounterId {
      get{
        if (this.cbEncounters.SelectedItem != null) {
          return ((Encounter)this.cbEncounters.SelectedItem).id;
        }
        return null;
      }
    }
    private int? SelectedZoneId {
      get {
        if (this.cbZones.SelectedItem != null) {
          return ((Zone)this.cbZones.SelectedItem).id;
        }
        return null;
      }
    }
    private string ApiKey {
      get {
        return this.tbApiKey.Text;
      }
    }
    private void initZone(bool onServer=false) {
      string apiKey = ApiKey;
      if (onServer) {
        if (!string.IsNullOrWhiteSpace(apiKey)) {
          try {
            this.zones = LogService.GetZones(apiKey);
          }catch(Exception ex) {
            log(ex.Message);
          }
        }
      }else{
        this.zones = Zone.initAllZoneData().toObject<List<Zone>>();
      }
        
      this.cbZones.Items.Clear();
      this.cbZones.Items.Add(new Zone() {
        id=null,name="<未选择>",encounters=new List<Encounter>() {
          new Encounter() {
            id=null,name="<未选择>"
          }
        }
      });
      foreach(var zone in zones) {
        this.cbZones.Items.Add(zone);
      }
      log("初始化成功");
    }


    private void btnInitZone_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(this.tbApiKey.Text)) {
        MessageBox.Show("需要填入apiKey");
        return;
      }
      initZone(true);
    }

    private void cbZones_SelectedIndexChanged(object sender, EventArgs e) {
      var cbZones = (ComboBox) sender;
      if (cbZones.SelectedItem != null) {
        var zone = (Zone)cbZones.SelectedItem;
        this.cbEncounters.Items.Clear();
        this.cbEncounters.Items.Add(new Encounter() {
          id = null, name = "<未选择>"
        });
        foreach(var encounter in zone.encounters) {
          this.cbEncounters.Items.Add(encounter);
        }
      }
    }

    private void btnTest_Click(object sender, EventArgs e) {
      if (string.IsNullOrEmpty(tbTestName.Text)) {
        MessageBox.Show("请输入玩家名");
        return;
      }
      playlogs(new Character(tbTestName.Text + tbTestServer.Text));
    }

  }
}
