namespace AirVPN.Gui.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripMenuItem mnuContextCopyAll;
			System.Windows.Forms.ToolStripMenuItem mnuContextSaveAll;
			System.Windows.Forms.ToolStripMenuItem mnuContextCopySelected;
			System.Windows.Forms.ToolStripMenuItem mnuContextSaveSelected;
			System.Windows.Forms.ColumnHeader colStatsKey;
			System.Windows.Forms.ColumnHeader colStatsValue;
			System.Windows.Forms.ColumnHeader colIcon;
			System.Windows.Forms.ColumnHeader colDate;
			System.Windows.Forms.ColumnHeader colMessage;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.imgButtons = new System.Windows.Forms.ImageList(this.components);
			this.mnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuStatus = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuHomePage = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPorts = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSpeedTest = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDevelopers = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDevelopersManText = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDevelopersManBBCode = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDevelopersUpdateManifest = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDevelopersDefaultManifest = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDevelopersReset = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPortForwarding = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsNetworkMonitor = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.imgCountries = new System.Windows.Forms.ImageList(this.components);
			this.tip = new System.Windows.Forms.ToolTip(this.components);
			this.cboScoreType = new AirVPN.Gui.Skin.ComboBox();
			this.chkLockLast = new AirVPN.Gui.Skin.CheckBox();
			this.cmdServersUndefined = new AirVPN.Gui.Skin.Button();
			this.cmdServersBlackList = new AirVPN.Gui.Skin.Button();
			this.cmdServersWhiteList = new AirVPN.Gui.Skin.Button();
			this.cmdServersConnect = new AirVPN.Gui.Skin.Button();
			this.cmdAreasUndefined = new AirVPN.Gui.Skin.Button();
			this.cmdAreasBlackList = new AirVPN.Gui.Skin.Button();
			this.cmdAreasWhiteList = new AirVPN.Gui.Skin.Button();
			this.cmdLogsSupport = new AirVPN.Gui.Skin.Button();
			this.cmdLogsOpenVpnManagement = new AirVPN.Gui.Skin.Button();
			this.cmdLogsClean = new AirVPN.Gui.Skin.Button();
			this.cmdLogsCopy = new AirVPN.Gui.Skin.Button();
			this.cmdLogsSave = new AirVPN.Gui.Skin.Button();
			this.cmdServersRefresh = new AirVPN.Gui.Skin.Button();
			this.lblNetLockStatus = new System.Windows.Forms.Label();
			this.mnuLogsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.mnuServers = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuServersConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuServersSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuServersWhiteList = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuServersBlackList = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuServersUndefined = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuServersRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAreas = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuAreasWhiteList = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAreasBlackList = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAreasUndefined = new System.Windows.Forms.ToolStripMenuItem();
			this.tabMain = new AirVPN.Gui.Skin.TabControl();
			this.tabOverview = new AirVPN.Gui.Skin.TabPage();
			this.pnlWelcome = new AirVPN.Gui.Skin.Panel();
			this.lblConnectSubtitle = new AirVPN.Gui.Skin.Label();
			this.cmdLockedNetwork = new AirVPN.Gui.Skin.Button();
			this.lblLoginIcon = new System.Windows.Forms.Label();
			this.imgLockedNetwork = new AirVPN.Gui.Skin.Label();
			this.cmdLogin = new AirVPN.Gui.Skin.Button();
			this.lblPassword = new AirVPN.Gui.Skin.Label();
			this.lblLogin = new AirVPN.Gui.Skin.Label();
			this.cmdConnect = new AirVPN.Gui.Skin.Button();
			this.chkRemember = new AirVPN.Gui.Skin.CheckBox();
			this.txtPassword = new AirVPN.Gui.Skin.TextBox();
			this.txtLogin = new AirVPN.Gui.Skin.TextBox();
			this.pnlConnected = new AirVPN.Gui.Skin.Panel();
			this.txtConnectedExitIp = new AirVPN.Gui.Skin.Label();
			this.lblConnectedExitIp = new AirVPN.Gui.Skin.Label();
			this.lblConnectedUpload = new AirVPN.Gui.Skin.Label();
			this.txtConnectedUpload = new System.Windows.Forms.Label();
			this.txtConnectedDownload = new System.Windows.Forms.Label();
			this.lblConnectedDownload = new AirVPN.Gui.Skin.Label();
			this.txtConnectedSince = new AirVPN.Gui.Skin.Label();
			this.lblConnectedSince = new AirVPN.Gui.Skin.Label();
			this.cmdDisconnect = new AirVPN.Gui.Skin.Button();
			this.lblConnectedLocation = new AirVPN.Gui.Skin.Label();
			this.lblConnectedTo = new AirVPN.Gui.Skin.Label();
			this.lblConnectedServerName = new AirVPN.Gui.Skin.Label();
			this.lblConnectedCountry = new AirVPN.Gui.Skin.Label();
			this.pnlWaiting = new AirVPN.Gui.Skin.Panel();
			this.lblWait2 = new AirVPN.Gui.Skin.Label();
			this.lblWait1 = new AirVPN.Gui.Skin.Label();
			this.cmdCancel = new AirVPN.Gui.Skin.Button();
			this.tabServers = new AirVPN.Gui.Skin.TabPage();
			this.lblScoreType = new AirVPN.Gui.Skin.Label();
			this.chkShowAll = new AirVPN.Gui.Skin.CheckBox();
			this.pnlServers = new System.Windows.Forms.Panel();
			this.tabAreas = new AirVPN.Gui.Skin.TabPage();
			this.pnlAreas = new System.Windows.Forms.Panel();
			this.tabSpeed = new AirVPN.Gui.Skin.TabPage();
			this.lblSpeedResolution = new AirVPN.Gui.Skin.Label();
			this.holSpeedChart = new System.Windows.Forms.Label();
			this.cboSpeedResolution = new AirVPN.Gui.Skin.ComboBox();
			this.tabStats = new AirVPN.Gui.Skin.TabPage();
			this.lstStats = new AirVPN.Gui.Skin.ListView();
			this.tabLogs = new AirVPN.Gui.Skin.TabPage();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.lstLogs = new AirVPN.Gui.Skin.ListView();
			mnuContextCopyAll = new System.Windows.Forms.ToolStripMenuItem();
			mnuContextSaveAll = new System.Windows.Forms.ToolStripMenuItem();
			mnuContextCopySelected = new System.Windows.Forms.ToolStripMenuItem();
			mnuContextSaveSelected = new System.Windows.Forms.ToolStripMenuItem();
			colStatsKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			colStatsValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			colIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mnuMain.SuspendLayout();
			this.mnuLogsContext.SuspendLayout();
			this.mnuServers.SuspendLayout();
			this.mnuAreas.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.tabOverview.SuspendLayout();
			this.pnlWelcome.SuspendLayout();
			this.pnlConnected.SuspendLayout();
			this.pnlWaiting.SuspendLayout();
			this.tabServers.SuspendLayout();
			this.tabAreas.SuspendLayout();
			this.tabSpeed.SuspendLayout();
			this.tabStats.SuspendLayout();
			this.tabLogs.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuContextCopyAll
			// 
			mnuContextCopyAll.Image = global::AirVPN.Lib.Forms.Properties.Resources.copy_16;
			mnuContextCopyAll.Name = "mnuContextCopyAll";
			mnuContextCopyAll.Size = new System.Drawing.Size(242, 22);
			mnuContextCopyAll.Text = "Copy all lines to clipboard";
			mnuContextCopyAll.Click += new System.EventHandler(this.mnuContextCopyAll_Click);
			// 
			// mnuContextSaveAll
			// 
			mnuContextSaveAll.Image = global::AirVPN.Lib.Forms.Properties.Resources.save_16;
			mnuContextSaveAll.Name = "mnuContextSaveAll";
			mnuContextSaveAll.Size = new System.Drawing.Size(242, 22);
			mnuContextSaveAll.Text = "Save all lines to file";
			mnuContextSaveAll.Click += new System.EventHandler(this.mnuContextSaveAll_Click);
			// 
			// mnuContextCopySelected
			// 
			mnuContextCopySelected.Image = global::AirVPN.Lib.Forms.Properties.Resources.copy_16;
			mnuContextCopySelected.Name = "mnuContextCopySelected";
			mnuContextCopySelected.Size = new System.Drawing.Size(242, 22);
			mnuContextCopySelected.Text = "Copy selected lines to clipboard";
			mnuContextCopySelected.Click += new System.EventHandler(this.mnuContextCopySelected_Click);
			// 
			// mnuContextSaveSelected
			// 
			mnuContextSaveSelected.Image = global::AirVPN.Lib.Forms.Properties.Resources.save_16;
			mnuContextSaveSelected.Name = "mnuContextSaveSelected";
			mnuContextSaveSelected.Size = new System.Drawing.Size(242, 22);
			mnuContextSaveSelected.Text = "Save selected lines to file";
			mnuContextSaveSelected.Click += new System.EventHandler(this.mnuContextSaveSelected_Click);
			// 
			// colStatsKey
			// 
			colStatsKey.Text = "Name";
			colStatsKey.Width = 180;
			// 
			// colStatsValue
			// 
			colStatsValue.Text = "Value";
			colStatsValue.Width = 4000;
			// 
			// colIcon
			// 
			colIcon.Text = "";
			colIcon.Width = 22;
			// 
			// colDate
			// 
			colDate.Text = "Date";
			colDate.Width = 150;
			// 
			// colMessage
			// 
			colMessage.Text = "Message";
			colMessage.Width = 6000;
			// 
			// imgButtons
			// 
			this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
			this.imgButtons.TransparentColor = System.Drawing.Color.Transparent;
			this.imgButtons.Images.SetKeyName(0, "disconnect");
			this.imgButtons.Images.SetKeyName(1, "enter");
			this.imgButtons.Images.SetKeyName(2, "login");
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSeparator2,
            this.mnuStatus,
            this.mnuConnect,
            this.mnuSeparator3,
            this.mnuHomePage,
            this.mnuUser,
            this.mnuPorts,
            this.mnuSpeedTest,
            this.mnuSeparator1,
            this.mnuSettings,
            this.mnuDevelopers,
            this.mnuTools,
            this.mnuAbout,
            this.toolStripSeparator2,
            this.mnuRestore,
            this.mnuSeparator4,
            this.mnuExit});
			this.mnuMain.Name = "trayMenu";
			this.mnuMain.Size = new System.Drawing.Size(250, 298);
			// 
			// mnuSeparator2
			// 
			this.mnuSeparator2.Name = "mnuSeparator2";
			this.mnuSeparator2.Size = new System.Drawing.Size(246, 6);
			// 
			// mnuStatus
			// 
			this.mnuStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuStatus.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.mnuStatus.Image = global::AirVPN.Lib.Forms.Properties.Resources.status_yellow_16;
			this.mnuStatus.Name = "mnuStatus";
			this.mnuStatus.Size = new System.Drawing.Size(249, 22);
			this.mnuStatus.Text = "TODO - Status readonly text";
			this.mnuStatus.Click += new System.EventHandler(this.mnuStatus_Click);
			// 
			// mnuConnect
			// 
			this.mnuConnect.Image = global::AirVPN.Lib.Forms.Properties.Resources.connect;
			this.mnuConnect.Name = "mnuConnect";
			this.mnuConnect.Size = new System.Drawing.Size(249, 22);
			this.mnuConnect.Text = "TODO - Connect to o Disconnect";
			this.mnuConnect.Click += new System.EventHandler(this.mnuConnect_Click);
			// 
			// mnuSeparator3
			// 
			this.mnuSeparator3.Name = "mnuSeparator3";
			this.mnuSeparator3.Size = new System.Drawing.Size(246, 6);
			// 
			// mnuHomePage
			// 
			this.mnuHomePage.Image = global::AirVPN.Lib.Forms.Properties.Resources.home;
			this.mnuHomePage.Name = "mnuHomePage";
			this.mnuHomePage.Size = new System.Drawing.Size(249, 22);
			this.mnuHomePage.Text = "AirVPN Web Site";
			this.mnuHomePage.Click += new System.EventHandler(this.mnuHomePage_Click);
			// 
			// mnuUser
			// 
			this.mnuUser.Image = global::AirVPN.Lib.Forms.Properties.Resources.stats;
			this.mnuUser.Name = "mnuUser";
			this.mnuUser.Size = new System.Drawing.Size(249, 22);
			this.mnuUser.Text = "Your &details and statistics (Web)";
			this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
			// 
			// mnuPorts
			// 
			this.mnuPorts.Image = global::AirVPN.Lib.Forms.Properties.Resources.ports;
			this.mnuPorts.Name = "mnuPorts";
			this.mnuPorts.Size = new System.Drawing.Size(249, 22);
			this.mnuPorts.Text = "Forwarding &Ports (Web)";
			this.mnuPorts.Click += new System.EventHandler(this.mnuPorts_Click);
			// 
			// mnuSpeedTest
			// 
			this.mnuSpeedTest.Image = global::AirVPN.Lib.Forms.Properties.Resources.speed;
			this.mnuSpeedTest.Name = "mnuSpeedTest";
			this.mnuSpeedTest.Size = new System.Drawing.Size(249, 22);
			this.mnuSpeedTest.Text = "Speed Test (Web)";
			this.mnuSpeedTest.Click += new System.EventHandler(this.mnuSpeedTest_Click);
			// 
			// mnuSeparator1
			// 
			this.mnuSeparator1.Name = "mnuSeparator1";
			this.mnuSeparator1.Size = new System.Drawing.Size(246, 6);
			// 
			// mnuSettings
			// 
			this.mnuSettings.Image = global::AirVPN.Lib.Forms.Properties.Resources.settings;
			this.mnuSettings.Name = "mnuSettings";
			this.mnuSettings.Size = new System.Drawing.Size(249, 22);
			this.mnuSettings.Text = "&Preferences";
			this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
			// 
			// mnuDevelopers
			// 
			this.mnuDevelopers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDevelopersManText,
            this.mnuDevelopersManBBCode,
            this.mnuDevelopersUpdateManifest,
            this.mnuDevelopersDefaultManifest,
            this.mnuDevelopersReset});
			this.mnuDevelopers.Name = "mnuDevelopers";
			this.mnuDevelopers.Size = new System.Drawing.Size(249, 22);
			this.mnuDevelopers.Text = "&Developers";
			// 
			// mnuDevelopersManText
			// 
			this.mnuDevelopersManText.Name = "mnuDevelopersManText";
			this.mnuDevelopersManText.Size = new System.Drawing.Size(369, 22);
			this.mnuDevelopersManText.Text = "Man - Text Format";
			this.mnuDevelopersManText.Click += new System.EventHandler(this.mnuDevelopersManText_Click);
			// 
			// mnuDevelopersManBBCode
			// 
			this.mnuDevelopersManBBCode.Name = "mnuDevelopersManBBCode";
			this.mnuDevelopersManBBCode.Size = new System.Drawing.Size(369, 22);
			this.mnuDevelopersManBBCode.Text = "Man - BBCode Format";
			this.mnuDevelopersManBBCode.Click += new System.EventHandler(this.mnuDevelopersManBBCode_Click);
			// 
			// mnuDevelopersUpdateManifest
			// 
			this.mnuDevelopersUpdateManifest.Name = "mnuDevelopersUpdateManifest";
			this.mnuDevelopersUpdateManifest.Size = new System.Drawing.Size(369, 22);
			this.mnuDevelopersUpdateManifest.Text = "Update Manifest Now";
			this.mnuDevelopersUpdateManifest.Click += new System.EventHandler(this.mnuDevelopersUpdateManifest_Click);
			// 
			// mnuDevelopersDefaultManifest
			// 
			this.mnuDevelopersDefaultManifest.Name = "mnuDevelopersDefaultManifest";
			this.mnuDevelopersDefaultManifest.Size = new System.Drawing.Size(369, 22);
			this.mnuDevelopersDefaultManifest.Text = "Default Manifest - For executable embedding, as default";
			this.mnuDevelopersDefaultManifest.Click += new System.EventHandler(this.mnuDevelopersDefaultManifest_Click);
			// 
			// mnuDevelopersReset
			// 
			this.mnuDevelopersReset.Name = "mnuDevelopersReset";
			this.mnuDevelopersReset.Size = new System.Drawing.Size(369, 22);
			this.mnuDevelopersReset.Text = "Reset (pinger for now)";
			this.mnuDevelopersReset.Click += new System.EventHandler(this.mnuDevelopersReset_Click);
			// 
			// mnuTools
			// 
			this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsPortForwarding,
            this.mnuToolsNetworkMonitor});
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size(249, 22);
			this.mnuTools.Text = "&Tools";
			// 
			// mnuToolsPortForwarding
			// 
			this.mnuToolsPortForwarding.Name = "mnuToolsPortForwarding";
			this.mnuToolsPortForwarding.Size = new System.Drawing.Size(194, 22);
			this.mnuToolsPortForwarding.Text = "Port Forwarding Tester";
			this.mnuToolsPortForwarding.Click += new System.EventHandler(this.mnuToolsPortForwarding_Click);
			// 
			// mnuToolsNetworkMonitor
			// 
			this.mnuToolsNetworkMonitor.Name = "mnuToolsNetworkMonitor";
			this.mnuToolsNetworkMonitor.Size = new System.Drawing.Size(194, 22);
			this.mnuToolsNetworkMonitor.Text = "Network Monitor";
			this.mnuToolsNetworkMonitor.Click += new System.EventHandler(this.mnuToolsNetworkMonitor_Click);
			// 
			// mnuAbout
			// 
			this.mnuAbout.Image = global::AirVPN.Lib.Forms.Properties.Resources.about;
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(249, 22);
			this.mnuAbout.Text = "&About";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
			// 
			// mnuRestore
			// 
			this.mnuRestore.Image = global::AirVPN.Lib.Forms.Properties.Resources.restore;
			this.mnuRestore.Name = "mnuRestore";
			this.mnuRestore.Size = new System.Drawing.Size(249, 22);
			this.mnuRestore.Text = "&Restore";
			this.mnuRestore.Click += new System.EventHandler(this.mnuRestore_Click);
			// 
			// mnuSeparator4
			// 
			this.mnuSeparator4.Name = "mnuSeparator4";
			this.mnuSeparator4.Size = new System.Drawing.Size(246, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Image = global::AirVPN.Lib.Forms.Properties.Resources.exit;
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(249, 22);
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// imgCountries
			// 
			this.imgCountries.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCountries.ImageStream")));
			this.imgCountries.TransparentColor = System.Drawing.Color.Transparent;
			this.imgCountries.Images.SetKeyName(0, "ad");
			this.imgCountries.Images.SetKeyName(1, "ae");
			this.imgCountries.Images.SetKeyName(2, "af");
			this.imgCountries.Images.SetKeyName(3, "ag");
			this.imgCountries.Images.SetKeyName(4, "ai");
			this.imgCountries.Images.SetKeyName(5, "al");
			this.imgCountries.Images.SetKeyName(6, "am");
			this.imgCountries.Images.SetKeyName(7, "an");
			this.imgCountries.Images.SetKeyName(8, "ao");
			this.imgCountries.Images.SetKeyName(9, "ar");
			this.imgCountries.Images.SetKeyName(10, "as");
			this.imgCountries.Images.SetKeyName(11, "at");
			this.imgCountries.Images.SetKeyName(12, "au");
			this.imgCountries.Images.SetKeyName(13, "aw");
			this.imgCountries.Images.SetKeyName(14, "ax");
			this.imgCountries.Images.SetKeyName(15, "az");
			this.imgCountries.Images.SetKeyName(16, "ba");
			this.imgCountries.Images.SetKeyName(17, "bb");
			this.imgCountries.Images.SetKeyName(18, "bd");
			this.imgCountries.Images.SetKeyName(19, "be");
			this.imgCountries.Images.SetKeyName(20, "bf");
			this.imgCountries.Images.SetKeyName(21, "bg");
			this.imgCountries.Images.SetKeyName(22, "bh");
			this.imgCountries.Images.SetKeyName(23, "bi");
			this.imgCountries.Images.SetKeyName(24, "bj");
			this.imgCountries.Images.SetKeyName(25, "bm");
			this.imgCountries.Images.SetKeyName(26, "bn");
			this.imgCountries.Images.SetKeyName(27, "bo");
			this.imgCountries.Images.SetKeyName(28, "br");
			this.imgCountries.Images.SetKeyName(29, "bs");
			this.imgCountries.Images.SetKeyName(30, "bt");
			this.imgCountries.Images.SetKeyName(31, "bv");
			this.imgCountries.Images.SetKeyName(32, "bw");
			this.imgCountries.Images.SetKeyName(33, "by");
			this.imgCountries.Images.SetKeyName(34, "bz");
			this.imgCountries.Images.SetKeyName(35, "ca");
			this.imgCountries.Images.SetKeyName(36, "catalonia");
			this.imgCountries.Images.SetKeyName(37, "cc");
			this.imgCountries.Images.SetKeyName(38, "cd");
			this.imgCountries.Images.SetKeyName(39, "cf");
			this.imgCountries.Images.SetKeyName(40, "cg");
			this.imgCountries.Images.SetKeyName(41, "ch");
			this.imgCountries.Images.SetKeyName(42, "ci");
			this.imgCountries.Images.SetKeyName(43, "ck");
			this.imgCountries.Images.SetKeyName(44, "cl");
			this.imgCountries.Images.SetKeyName(45, "cm");
			this.imgCountries.Images.SetKeyName(46, "cn");
			this.imgCountries.Images.SetKeyName(47, "co");
			this.imgCountries.Images.SetKeyName(48, "cr");
			this.imgCountries.Images.SetKeyName(49, "cs");
			this.imgCountries.Images.SetKeyName(50, "cu");
			this.imgCountries.Images.SetKeyName(51, "cv");
			this.imgCountries.Images.SetKeyName(52, "cx");
			this.imgCountries.Images.SetKeyName(53, "cy");
			this.imgCountries.Images.SetKeyName(54, "cz");
			this.imgCountries.Images.SetKeyName(55, "de");
			this.imgCountries.Images.SetKeyName(56, "dj");
			this.imgCountries.Images.SetKeyName(57, "dk");
			this.imgCountries.Images.SetKeyName(58, "dm");
			this.imgCountries.Images.SetKeyName(59, "do");
			this.imgCountries.Images.SetKeyName(60, "dz");
			this.imgCountries.Images.SetKeyName(61, "ec");
			this.imgCountries.Images.SetKeyName(62, "ee");
			this.imgCountries.Images.SetKeyName(63, "eg");
			this.imgCountries.Images.SetKeyName(64, "eh");
			this.imgCountries.Images.SetKeyName(65, "england");
			this.imgCountries.Images.SetKeyName(66, "er");
			this.imgCountries.Images.SetKeyName(67, "es");
			this.imgCountries.Images.SetKeyName(68, "et");
			this.imgCountries.Images.SetKeyName(69, "europeanunion");
			this.imgCountries.Images.SetKeyName(70, "fam");
			this.imgCountries.Images.SetKeyName(71, "fi");
			this.imgCountries.Images.SetKeyName(72, "fj");
			this.imgCountries.Images.SetKeyName(73, "fk");
			this.imgCountries.Images.SetKeyName(74, "fm");
			this.imgCountries.Images.SetKeyName(75, "fo");
			this.imgCountries.Images.SetKeyName(76, "fr");
			this.imgCountries.Images.SetKeyName(77, "ga");
			this.imgCountries.Images.SetKeyName(78, "gb");
			this.imgCountries.Images.SetKeyName(79, "gd");
			this.imgCountries.Images.SetKeyName(80, "ge");
			this.imgCountries.Images.SetKeyName(81, "gf");
			this.imgCountries.Images.SetKeyName(82, "gh");
			this.imgCountries.Images.SetKeyName(83, "gi");
			this.imgCountries.Images.SetKeyName(84, "gl");
			this.imgCountries.Images.SetKeyName(85, "gm");
			this.imgCountries.Images.SetKeyName(86, "gn");
			this.imgCountries.Images.SetKeyName(87, "gp");
			this.imgCountries.Images.SetKeyName(88, "gq");
			this.imgCountries.Images.SetKeyName(89, "gr");
			this.imgCountries.Images.SetKeyName(90, "gs");
			this.imgCountries.Images.SetKeyName(91, "gt");
			this.imgCountries.Images.SetKeyName(92, "gu");
			this.imgCountries.Images.SetKeyName(93, "gw");
			this.imgCountries.Images.SetKeyName(94, "gy");
			this.imgCountries.Images.SetKeyName(95, "hk");
			this.imgCountries.Images.SetKeyName(96, "hm");
			this.imgCountries.Images.SetKeyName(97, "hn");
			this.imgCountries.Images.SetKeyName(98, "hr");
			this.imgCountries.Images.SetKeyName(99, "ht");
			this.imgCountries.Images.SetKeyName(100, "hu");
			this.imgCountries.Images.SetKeyName(101, "id");
			this.imgCountries.Images.SetKeyName(102, "ie");
			this.imgCountries.Images.SetKeyName(103, "il");
			this.imgCountries.Images.SetKeyName(104, "in");
			this.imgCountries.Images.SetKeyName(105, "io");
			this.imgCountries.Images.SetKeyName(106, "iq");
			this.imgCountries.Images.SetKeyName(107, "ir");
			this.imgCountries.Images.SetKeyName(108, "is");
			this.imgCountries.Images.SetKeyName(109, "it");
			this.imgCountries.Images.SetKeyName(110, "jm");
			this.imgCountries.Images.SetKeyName(111, "jo");
			this.imgCountries.Images.SetKeyName(112, "jp");
			this.imgCountries.Images.SetKeyName(113, "ke");
			this.imgCountries.Images.SetKeyName(114, "kg");
			this.imgCountries.Images.SetKeyName(115, "kh");
			this.imgCountries.Images.SetKeyName(116, "ki");
			this.imgCountries.Images.SetKeyName(117, "km");
			this.imgCountries.Images.SetKeyName(118, "kn");
			this.imgCountries.Images.SetKeyName(119, "kp");
			this.imgCountries.Images.SetKeyName(120, "kr");
			this.imgCountries.Images.SetKeyName(121, "kw");
			this.imgCountries.Images.SetKeyName(122, "ky");
			this.imgCountries.Images.SetKeyName(123, "kz");
			this.imgCountries.Images.SetKeyName(124, "la");
			this.imgCountries.Images.SetKeyName(125, "lb");
			this.imgCountries.Images.SetKeyName(126, "lc");
			this.imgCountries.Images.SetKeyName(127, "li");
			this.imgCountries.Images.SetKeyName(128, "lk");
			this.imgCountries.Images.SetKeyName(129, "lr");
			this.imgCountries.Images.SetKeyName(130, "ls");
			this.imgCountries.Images.SetKeyName(131, "lt");
			this.imgCountries.Images.SetKeyName(132, "lu");
			this.imgCountries.Images.SetKeyName(133, "lv");
			this.imgCountries.Images.SetKeyName(134, "ly");
			this.imgCountries.Images.SetKeyName(135, "ma");
			this.imgCountries.Images.SetKeyName(136, "mc");
			this.imgCountries.Images.SetKeyName(137, "md");
			this.imgCountries.Images.SetKeyName(138, "me");
			this.imgCountries.Images.SetKeyName(139, "mg");
			this.imgCountries.Images.SetKeyName(140, "mh");
			this.imgCountries.Images.SetKeyName(141, "mk");
			this.imgCountries.Images.SetKeyName(142, "ml");
			this.imgCountries.Images.SetKeyName(143, "mm");
			this.imgCountries.Images.SetKeyName(144, "mn");
			this.imgCountries.Images.SetKeyName(145, "mo");
			this.imgCountries.Images.SetKeyName(146, "mp");
			this.imgCountries.Images.SetKeyName(147, "mq");
			this.imgCountries.Images.SetKeyName(148, "mr");
			this.imgCountries.Images.SetKeyName(149, "ms");
			this.imgCountries.Images.SetKeyName(150, "mt");
			this.imgCountries.Images.SetKeyName(151, "mu");
			this.imgCountries.Images.SetKeyName(152, "mv");
			this.imgCountries.Images.SetKeyName(153, "mw");
			this.imgCountries.Images.SetKeyName(154, "mx");
			this.imgCountries.Images.SetKeyName(155, "my");
			this.imgCountries.Images.SetKeyName(156, "mz");
			this.imgCountries.Images.SetKeyName(157, "na");
			this.imgCountries.Images.SetKeyName(158, "nc");
			this.imgCountries.Images.SetKeyName(159, "ne");
			this.imgCountries.Images.SetKeyName(160, "nf");
			this.imgCountries.Images.SetKeyName(161, "ng");
			this.imgCountries.Images.SetKeyName(162, "ni");
			this.imgCountries.Images.SetKeyName(163, "nl");
			this.imgCountries.Images.SetKeyName(164, "no");
			this.imgCountries.Images.SetKeyName(165, "np");
			this.imgCountries.Images.SetKeyName(166, "nr");
			this.imgCountries.Images.SetKeyName(167, "nu");
			this.imgCountries.Images.SetKeyName(168, "nz");
			this.imgCountries.Images.SetKeyName(169, "om");
			this.imgCountries.Images.SetKeyName(170, "pa");
			this.imgCountries.Images.SetKeyName(171, "pe");
			this.imgCountries.Images.SetKeyName(172, "pf");
			this.imgCountries.Images.SetKeyName(173, "pg");
			this.imgCountries.Images.SetKeyName(174, "ph");
			this.imgCountries.Images.SetKeyName(175, "pk");
			this.imgCountries.Images.SetKeyName(176, "pl");
			this.imgCountries.Images.SetKeyName(177, "pm");
			this.imgCountries.Images.SetKeyName(178, "pn");
			this.imgCountries.Images.SetKeyName(179, "pr");
			this.imgCountries.Images.SetKeyName(180, "ps");
			this.imgCountries.Images.SetKeyName(181, "pt");
			this.imgCountries.Images.SetKeyName(182, "pw");
			this.imgCountries.Images.SetKeyName(183, "py");
			this.imgCountries.Images.SetKeyName(184, "qa");
			this.imgCountries.Images.SetKeyName(185, "re");
			this.imgCountries.Images.SetKeyName(186, "ro");
			this.imgCountries.Images.SetKeyName(187, "rs");
			this.imgCountries.Images.SetKeyName(188, "ru");
			this.imgCountries.Images.SetKeyName(189, "rw");
			this.imgCountries.Images.SetKeyName(190, "sa");
			this.imgCountries.Images.SetKeyName(191, "sb");
			this.imgCountries.Images.SetKeyName(192, "sc");
			this.imgCountries.Images.SetKeyName(193, "scotland");
			this.imgCountries.Images.SetKeyName(194, "sd");
			this.imgCountries.Images.SetKeyName(195, "se");
			this.imgCountries.Images.SetKeyName(196, "sg");
			this.imgCountries.Images.SetKeyName(197, "sh");
			this.imgCountries.Images.SetKeyName(198, "si");
			this.imgCountries.Images.SetKeyName(199, "sj");
			this.imgCountries.Images.SetKeyName(200, "sk");
			this.imgCountries.Images.SetKeyName(201, "sl");
			this.imgCountries.Images.SetKeyName(202, "sm");
			this.imgCountries.Images.SetKeyName(203, "sn");
			this.imgCountries.Images.SetKeyName(204, "so");
			this.imgCountries.Images.SetKeyName(205, "sr");
			this.imgCountries.Images.SetKeyName(206, "st");
			this.imgCountries.Images.SetKeyName(207, "sv");
			this.imgCountries.Images.SetKeyName(208, "sy");
			this.imgCountries.Images.SetKeyName(209, "sz");
			this.imgCountries.Images.SetKeyName(210, "tc");
			this.imgCountries.Images.SetKeyName(211, "td");
			this.imgCountries.Images.SetKeyName(212, "tf");
			this.imgCountries.Images.SetKeyName(213, "tg");
			this.imgCountries.Images.SetKeyName(214, "th");
			this.imgCountries.Images.SetKeyName(215, "tj");
			this.imgCountries.Images.SetKeyName(216, "tk");
			this.imgCountries.Images.SetKeyName(217, "tl");
			this.imgCountries.Images.SetKeyName(218, "tm");
			this.imgCountries.Images.SetKeyName(219, "tn");
			this.imgCountries.Images.SetKeyName(220, "to");
			this.imgCountries.Images.SetKeyName(221, "tr");
			this.imgCountries.Images.SetKeyName(222, "tt");
			this.imgCountries.Images.SetKeyName(223, "tv");
			this.imgCountries.Images.SetKeyName(224, "tw");
			this.imgCountries.Images.SetKeyName(225, "tz");
			this.imgCountries.Images.SetKeyName(226, "ua");
			this.imgCountries.Images.SetKeyName(227, "ug");
			this.imgCountries.Images.SetKeyName(228, "um");
			this.imgCountries.Images.SetKeyName(229, "us");
			this.imgCountries.Images.SetKeyName(230, "uy");
			this.imgCountries.Images.SetKeyName(231, "uz");
			this.imgCountries.Images.SetKeyName(232, "va");
			this.imgCountries.Images.SetKeyName(233, "vc");
			this.imgCountries.Images.SetKeyName(234, "ve");
			this.imgCountries.Images.SetKeyName(235, "vg");
			this.imgCountries.Images.SetKeyName(236, "vi");
			this.imgCountries.Images.SetKeyName(237, "vn");
			this.imgCountries.Images.SetKeyName(238, "vu");
			this.imgCountries.Images.SetKeyName(239, "wales");
			this.imgCountries.Images.SetKeyName(240, "wf");
			this.imgCountries.Images.SetKeyName(241, "ws");
			this.imgCountries.Images.SetKeyName(242, "ye");
			this.imgCountries.Images.SetKeyName(243, "yt");
			this.imgCountries.Images.SetKeyName(244, "za");
			this.imgCountries.Images.SetKeyName(245, "zm");
			this.imgCountries.Images.SetKeyName(246, "zw");
			// 
			// cboScoreType
			// 
			this.cboScoreType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cboScoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboScoreType.FormattingEnabled = true;
			this.cboScoreType.Items.AddRange(new object[] {
            "Speed",
            "Latency"});
			this.cboScoreType.Location = new System.Drawing.Point(457, 278);
			this.cboScoreType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboScoreType.Name = "cboScoreType";
			this.cboScoreType.Size = new System.Drawing.Size(63, 21);
			this.cboScoreType.TabIndex = 49;
			this.tip.SetToolTip(this.cboScoreType, "xxx");
			this.cboScoreType.SelectedIndexChanged += new System.EventHandler(this.cboScoreType_SelectedIndexChanged);
			// 
			// chkLockLast
			// 
			this.chkLockLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkLockLast.AutoSize = true;
			this.chkLockLast.Location = new System.Drawing.Point(543, 280);
			this.chkLockLast.Margin = new System.Windows.Forms.Padding(2);
			this.chkLockLast.Name = "chkLockLast";
			this.chkLockLast.Size = new System.Drawing.Size(87, 17);
			this.chkLockLast.TabIndex = 46;
			this.chkLockLast.Text = "Lock Current";
			this.tip.SetToolTip(this.chkLockLast, "Never leave the current server. \r\nFor example if you don\'t want to change your IP" +
        " for port forwarding reasons.");
			this.chkLockLast.UseVisualStyleBackColor = true;
			this.chkLockLast.CheckedChanged += new System.EventHandler(this.chkLockCurrent_CheckedChanged);
			// 
			// cmdServersUndefined
			// 
			this.cmdServersUndefined.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdServersUndefined.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdServersUndefined.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdServersUndefined.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdServersUndefined.FlatAppearance.BorderSize = 0;
			this.cmdServersUndefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdServersUndefined.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_2;
			this.cmdServersUndefined.Location = new System.Drawing.Point(630, 110);
			this.cmdServersUndefined.Margin = new System.Windows.Forms.Padding(2);
			this.cmdServersUndefined.Name = "cmdServersUndefined";
			this.cmdServersUndefined.Size = new System.Drawing.Size(26, 28);
			this.cmdServersUndefined.TabIndex = 45;
			this.tip.SetToolTip(this.cmdServersUndefined, "Clean the selected servers from whitelist and blacklist");
			this.cmdServersUndefined.UseVisualStyleBackColor = true;
			this.cmdServersUndefined.Click += new System.EventHandler(this.cmdServersUndefined_Click);
			// 
			// cmdServersBlackList
			// 
			this.cmdServersBlackList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdServersBlackList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdServersBlackList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdServersBlackList.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdServersBlackList.FlatAppearance.BorderSize = 0;
			this.cmdServersBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdServersBlackList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_1;
			this.cmdServersBlackList.Location = new System.Drawing.Point(630, 77);
			this.cmdServersBlackList.Margin = new System.Windows.Forms.Padding(2);
			this.cmdServersBlackList.Name = "cmdServersBlackList";
			this.cmdServersBlackList.Size = new System.Drawing.Size(26, 28);
			this.cmdServersBlackList.TabIndex = 44;
			this.tip.SetToolTip(this.cmdServersBlackList, "Add the selected servers to blacklist. \r\nThe system will never connect to blackli" +
        "sted servers.");
			this.cmdServersBlackList.UseVisualStyleBackColor = true;
			this.cmdServersBlackList.Click += new System.EventHandler(this.cmdServersBlackList_Click);
			// 
			// cmdServersWhiteList
			// 
			this.cmdServersWhiteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdServersWhiteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdServersWhiteList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdServersWhiteList.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdServersWhiteList.FlatAppearance.BorderSize = 0;
			this.cmdServersWhiteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdServersWhiteList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_0;
			this.cmdServersWhiteList.Location = new System.Drawing.Point(630, 45);
			this.cmdServersWhiteList.Margin = new System.Windows.Forms.Padding(2);
			this.cmdServersWhiteList.Name = "cmdServersWhiteList";
			this.cmdServersWhiteList.Size = new System.Drawing.Size(26, 28);
			this.cmdServersWhiteList.TabIndex = 43;
			this.tip.SetToolTip(this.cmdServersWhiteList, "Add the selected server to whitelist.\r\nThe system will only connect to whiteliste" +
        "d servers.");
			this.cmdServersWhiteList.UseVisualStyleBackColor = true;
			this.cmdServersWhiteList.Click += new System.EventHandler(this.cmdServersWhiteList_Click);
			// 
			// cmdServersConnect
			// 
			this.cmdServersConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdServersConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdServersConnect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdServersConnect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdServersConnect.FlatAppearance.BorderSize = 0;
			this.cmdServersConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdServersConnect.Image = global::AirVPN.Lib.Forms.Properties.Resources.connect_16;
			this.cmdServersConnect.Location = new System.Drawing.Point(630, 4);
			this.cmdServersConnect.Margin = new System.Windows.Forms.Padding(2);
			this.cmdServersConnect.Name = "cmdServersConnect";
			this.cmdServersConnect.Size = new System.Drawing.Size(26, 28);
			this.cmdServersConnect.TabIndex = 42;
			this.tip.SetToolTip(this.cmdServersConnect, "Connect to the selected server now");
			this.cmdServersConnect.UseVisualStyleBackColor = true;
			this.cmdServersConnect.Click += new System.EventHandler(this.cmdServersConnect_Click);
			// 
			// cmdAreasUndefined
			// 
			this.cmdAreasUndefined.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAreasUndefined.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAreasUndefined.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdAreasUndefined.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdAreasUndefined.FlatAppearance.BorderSize = 0;
			this.cmdAreasUndefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAreasUndefined.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_2;
			this.cmdAreasUndefined.Location = new System.Drawing.Point(630, 68);
			this.cmdAreasUndefined.Margin = new System.Windows.Forms.Padding(2);
			this.cmdAreasUndefined.Name = "cmdAreasUndefined";
			this.cmdAreasUndefined.Size = new System.Drawing.Size(26, 28);
			this.cmdAreasUndefined.TabIndex = 48;
			this.tip.SetToolTip(this.cmdAreasUndefined, "Clean the selected areas from whitelist and blacklist");
			this.cmdAreasUndefined.UseVisualStyleBackColor = true;
			this.cmdAreasUndefined.Click += new System.EventHandler(this.cmdAreasUndefined_Click);
			// 
			// cmdAreasBlackList
			// 
			this.cmdAreasBlackList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAreasBlackList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAreasBlackList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdAreasBlackList.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdAreasBlackList.FlatAppearance.BorderSize = 0;
			this.cmdAreasBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAreasBlackList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_1;
			this.cmdAreasBlackList.Location = new System.Drawing.Point(630, 36);
			this.cmdAreasBlackList.Margin = new System.Windows.Forms.Padding(2);
			this.cmdAreasBlackList.Name = "cmdAreasBlackList";
			this.cmdAreasBlackList.Size = new System.Drawing.Size(26, 28);
			this.cmdAreasBlackList.TabIndex = 47;
			this.tip.SetToolTip(this.cmdAreasBlackList, "Add the selected areas to blacklist. \r\nThe system will never connect to servers i" +
        "n blacklisted areas.\r\n");
			this.cmdAreasBlackList.UseVisualStyleBackColor = true;
			this.cmdAreasBlackList.Click += new System.EventHandler(this.cmdAreasBlackList_Click);
			// 
			// cmdAreasWhiteList
			// 
			this.cmdAreasWhiteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAreasWhiteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAreasWhiteList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdAreasWhiteList.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdAreasWhiteList.FlatAppearance.BorderSize = 0;
			this.cmdAreasWhiteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAreasWhiteList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_0;
			this.cmdAreasWhiteList.Location = new System.Drawing.Point(630, 4);
			this.cmdAreasWhiteList.Margin = new System.Windows.Forms.Padding(2);
			this.cmdAreasWhiteList.Name = "cmdAreasWhiteList";
			this.cmdAreasWhiteList.Size = new System.Drawing.Size(26, 28);
			this.cmdAreasWhiteList.TabIndex = 46;
			this.tip.SetToolTip(this.cmdAreasWhiteList, "Add the selected area to whitelist.\r\nThe system will only connect to servers in w" +
        "hitelisted areas.\r\n");
			this.cmdAreasWhiteList.UseVisualStyleBackColor = true;
			this.cmdAreasWhiteList.Click += new System.EventHandler(this.cmdAreasWhiteList_Click);
			// 
			// cmdLogsSupport
			// 
			this.cmdLogsSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdLogsSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdLogsSupport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdLogsSupport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdLogsSupport.FlatAppearance.BorderSize = 0;
			this.cmdLogsSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLogsSupport.Image = global::AirVPN.Lib.Forms.Properties.Resources.support;
			this.cmdLogsSupport.Location = new System.Drawing.Point(630, 117);
			this.cmdLogsSupport.Margin = new System.Windows.Forms.Padding(2);
			this.cmdLogsSupport.Name = "cmdLogsSupport";
			this.cmdLogsSupport.Size = new System.Drawing.Size(26, 28);
			this.cmdLogsSupport.TabIndex = 51;
			this.tip.SetToolTip(this.cmdLogsSupport, "Save to file");
			this.cmdLogsSupport.UseVisualStyleBackColor = true;
			this.cmdLogsSupport.Click += new System.EventHandler(this.cmdLogsSupport_Click);
			// 
			// cmdLogsOpenVpnManagement
			// 
			this.cmdLogsOpenVpnManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdLogsOpenVpnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdLogsOpenVpnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdLogsOpenVpnManagement.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdLogsOpenVpnManagement.FlatAppearance.BorderSize = 0;
			this.cmdLogsOpenVpnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLogsOpenVpnManagement.Image = global::AirVPN.Lib.Forms.Properties.Resources.execute_16;
			this.cmdLogsOpenVpnManagement.Location = new System.Drawing.Point(630, 273);
			this.cmdLogsOpenVpnManagement.Margin = new System.Windows.Forms.Padding(2);
			this.cmdLogsOpenVpnManagement.Name = "cmdLogsOpenVpnManagement";
			this.cmdLogsOpenVpnManagement.Size = new System.Drawing.Size(26, 28);
			this.cmdLogsOpenVpnManagement.TabIndex = 50;
			this.tip.SetToolTip(this.cmdLogsOpenVpnManagement, "Run a OpenVPN Management command");
			this.cmdLogsOpenVpnManagement.UseVisualStyleBackColor = true;
			this.cmdLogsOpenVpnManagement.Click += new System.EventHandler(this.cmdLogsOpenVpnManagement_Click);
			// 
			// cmdLogsClean
			// 
			this.cmdLogsClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdLogsClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdLogsClean.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdLogsClean.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdLogsClean.FlatAppearance.BorderSize = 0;
			this.cmdLogsClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLogsClean.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_2;
			this.cmdLogsClean.Location = new System.Drawing.Point(630, 0);
			this.cmdLogsClean.Margin = new System.Windows.Forms.Padding(2);
			this.cmdLogsClean.Name = "cmdLogsClean";
			this.cmdLogsClean.Size = new System.Drawing.Size(26, 28);
			this.cmdLogsClean.TabIndex = 48;
			this.tip.SetToolTip(this.cmdLogsClean, "Clean logs");
			this.cmdLogsClean.UseVisualStyleBackColor = true;
			this.cmdLogsClean.Click += new System.EventHandler(this.cmdLogsClean_Click);
			// 
			// cmdLogsCopy
			// 
			this.cmdLogsCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdLogsCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdLogsCopy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdLogsCopy.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdLogsCopy.FlatAppearance.BorderSize = 0;
			this.cmdLogsCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLogsCopy.Image = global::AirVPN.Lib.Forms.Properties.Resources.copy_16;
			this.cmdLogsCopy.Location = new System.Drawing.Point(630, 32);
			this.cmdLogsCopy.Margin = new System.Windows.Forms.Padding(2);
			this.cmdLogsCopy.Name = "cmdLogsCopy";
			this.cmdLogsCopy.Size = new System.Drawing.Size(26, 28);
			this.cmdLogsCopy.TabIndex = 47;
			this.tip.SetToolTip(this.cmdLogsCopy, "Copy to clipboard");
			this.cmdLogsCopy.UseVisualStyleBackColor = true;
			this.cmdLogsCopy.Click += new System.EventHandler(this.cmdLogsCopy_Click);
			// 
			// cmdLogsSave
			// 
			this.cmdLogsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdLogsSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdLogsSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdLogsSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdLogsSave.FlatAppearance.BorderSize = 0;
			this.cmdLogsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLogsSave.Image = global::AirVPN.Lib.Forms.Properties.Resources.save_16;
			this.cmdLogsSave.Location = new System.Drawing.Point(630, 64);
			this.cmdLogsSave.Margin = new System.Windows.Forms.Padding(2);
			this.cmdLogsSave.Name = "cmdLogsSave";
			this.cmdLogsSave.Size = new System.Drawing.Size(26, 28);
			this.cmdLogsSave.TabIndex = 46;
			this.tip.SetToolTip(this.cmdLogsSave, "Save to file");
			this.cmdLogsSave.UseVisualStyleBackColor = true;
			this.cmdLogsSave.Click += new System.EventHandler(this.cmdLogsSave_Click);
			// 
			// cmdServersRefresh
			// 
			this.cmdServersRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdServersRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdServersRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdServersRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdServersRefresh.FlatAppearance.BorderSize = 0;
			this.cmdServersRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdServersRefresh.Image = global::AirVPN.Lib.Forms.Properties.Resources.reload;
			this.cmdServersRefresh.Location = new System.Drawing.Point(630, 248);
			this.cmdServersRefresh.Margin = new System.Windows.Forms.Padding(2);
			this.cmdServersRefresh.Name = "cmdServersRefresh";
			this.cmdServersRefresh.Size = new System.Drawing.Size(26, 28);
			this.cmdServersRefresh.TabIndex = 66;
			this.tip.SetToolTip(this.cmdServersRefresh, "Refresh the servers list");
			this.cmdServersRefresh.UseVisualStyleBackColor = true;
			this.cmdServersRefresh.Click += new System.EventHandler(this.cmdServersRefresh_Click);
			// 
			// lblNetLockStatus
			// 
			this.lblNetLockStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNetLockStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblNetLockStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNetLockStatus.Image = global::AirVPN.Lib.Forms.Properties.Resources.netlock_status_off;
			this.lblNetLockStatus.Location = new System.Drawing.Point(802, 0);
			this.lblNetLockStatus.Name = "lblNetLockStatus";
			this.lblNetLockStatus.Size = new System.Drawing.Size(30, 30);
			this.lblNetLockStatus.TabIndex = 74;
			this.tip.SetToolTip(this.lblNetLockStatus, "gatto");
			// 
			// mnuLogsContext
			// 
			this.mnuLogsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuContextCopyAll,
            mnuContextSaveAll,
            this.toolStripSeparator1,
            mnuContextCopySelected,
            mnuContextSaveSelected});
			this.mnuLogsContext.Name = "mnuContext";
			this.mnuLogsContext.Size = new System.Drawing.Size(243, 98);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
			// 
			// mnuServers
			// 
			this.mnuServers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServersConnect,
            this.mnuServersSeparator1,
            this.mnuServersWhiteList,
            this.mnuServersBlackList,
            this.mnuServersUndefined,
            this.toolStripSeparator3,
            this.mnuServersRefresh});
			this.mnuServers.Name = "mnuServers";
			this.mnuServers.Size = new System.Drawing.Size(146, 126);
			// 
			// mnuServersConnect
			// 
			this.mnuServersConnect.Image = global::AirVPN.Lib.Forms.Properties.Resources.connect_16;
			this.mnuServersConnect.Name = "mnuServersConnect";
			this.mnuServersConnect.Size = new System.Drawing.Size(145, 22);
			this.mnuServersConnect.Text = "Connect now";
			this.mnuServersConnect.Click += new System.EventHandler(this.mnuServersConnect_Click);
			// 
			// mnuServersSeparator1
			// 
			this.mnuServersSeparator1.Name = "mnuServersSeparator1";
			this.mnuServersSeparator1.Size = new System.Drawing.Size(142, 6);
			// 
			// mnuServersWhiteList
			// 
			this.mnuServersWhiteList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_0;
			this.mnuServersWhiteList.Name = "mnuServersWhiteList";
			this.mnuServersWhiteList.Size = new System.Drawing.Size(145, 22);
			this.mnuServersWhiteList.Text = "Whitelist";
			this.mnuServersWhiteList.Click += new System.EventHandler(this.mnuServersWhitelist_Click);
			// 
			// mnuServersBlackList
			// 
			this.mnuServersBlackList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_1;
			this.mnuServersBlackList.Name = "mnuServersBlackList";
			this.mnuServersBlackList.Size = new System.Drawing.Size(145, 22);
			this.mnuServersBlackList.Text = "Blacklist";
			this.mnuServersBlackList.Click += new System.EventHandler(this.mnuServersBlacklist_Click);
			// 
			// mnuServersUndefined
			// 
			this.mnuServersUndefined.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_2;
			this.mnuServersUndefined.Name = "mnuServersUndefined";
			this.mnuServersUndefined.Size = new System.Drawing.Size(145, 22);
			this.mnuServersUndefined.Text = "Undefined";
			this.mnuServersUndefined.Click += new System.EventHandler(this.mnuServersUndefined_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
			// 
			// mnuServersRefresh
			// 
			this.mnuServersRefresh.Image = global::AirVPN.Lib.Forms.Properties.Resources.reload;
			this.mnuServersRefresh.Name = "mnuServersRefresh";
			this.mnuServersRefresh.Size = new System.Drawing.Size(145, 22);
			this.mnuServersRefresh.Text = "Refresh list";
			this.mnuServersRefresh.Click += new System.EventHandler(this.mnuServersRefresh_Click);
			// 
			// mnuAreas
			// 
			this.mnuAreas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAreasWhiteList,
            this.mnuAreasBlackList,
            this.mnuAreasUndefined});
			this.mnuAreas.Name = "mnuAreas";
			this.mnuAreas.Size = new System.Drawing.Size(130, 70);
			// 
			// mnuAreasWhiteList
			// 
			this.mnuAreasWhiteList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_0;
			this.mnuAreasWhiteList.Name = "mnuAreasWhiteList";
			this.mnuAreasWhiteList.Size = new System.Drawing.Size(129, 22);
			this.mnuAreasWhiteList.Text = "Whitelist";
			this.mnuAreasWhiteList.Click += new System.EventHandler(this.mnuAreasWhiteList_Click);
			// 
			// mnuAreasBlackList
			// 
			this.mnuAreasBlackList.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_1;
			this.mnuAreasBlackList.Name = "mnuAreasBlackList";
			this.mnuAreasBlackList.Size = new System.Drawing.Size(129, 22);
			this.mnuAreasBlackList.Text = "Blacklist";
			this.mnuAreasBlackList.Click += new System.EventHandler(this.cmdAreasBlackList_Click);
			// 
			// mnuAreasUndefined
			// 
			this.mnuAreasUndefined.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_2;
			this.mnuAreasUndefined.Name = "mnuAreasUndefined";
			this.mnuAreasUndefined.Size = new System.Drawing.Size(129, 22);
			this.mnuAreasUndefined.Text = "Undefined";
			this.mnuAreasUndefined.Click += new System.EventHandler(this.mnuAreasUndefined_Click);
			// 
			// tabMain
			// 
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabMain.Controls.Add(this.tabOverview);
			this.tabMain.Controls.Add(this.tabServers);
			this.tabMain.Controls.Add(this.tabAreas);
			this.tabMain.Controls.Add(this.tabSpeed);
			this.tabMain.Controls.Add(this.tabStats);
			this.tabMain.Controls.Add(this.tabLogs);
			this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabMain.ItemSize = new System.Drawing.Size(80, 20);
			this.tabMain.Location = new System.Drawing.Point(12, 12);
			this.tabMain.Multiline = true;
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(668, 329);
			this.tabMain.TabIndex = 21;
			// 
			// tabOverview
			// 
			this.tabOverview.Controls.Add(this.pnlWelcome);
			this.tabOverview.Controls.Add(this.pnlConnected);
			this.tabOverview.Controls.Add(this.pnlWaiting);
			this.tabOverview.Location = new System.Drawing.Point(4, 24);
			this.tabOverview.Name = "tabOverview";
			this.tabOverview.Size = new System.Drawing.Size(660, 301);
			this.tabOverview.TabIndex = 4;
			this.tabOverview.Text = "Overview";
			this.tabOverview.UseVisualStyleBackColor = true;
			// 
			// pnlWelcome
			// 
			this.pnlWelcome.BackColor = System.Drawing.Color.Transparent;
			this.pnlWelcome.Controls.Add(this.lblConnectSubtitle);
			this.pnlWelcome.Controls.Add(this.cmdLockedNetwork);
			this.pnlWelcome.Controls.Add(this.lblLoginIcon);
			this.pnlWelcome.Controls.Add(this.imgLockedNetwork);
			this.pnlWelcome.Controls.Add(this.cmdLogin);
			this.pnlWelcome.Controls.Add(this.lblPassword);
			this.pnlWelcome.Controls.Add(this.lblLogin);
			this.pnlWelcome.Controls.Add(this.cmdConnect);
			this.pnlWelcome.Controls.Add(this.chkRemember);
			this.pnlWelcome.Controls.Add(this.txtPassword);
			this.pnlWelcome.Controls.Add(this.txtLogin);
			this.pnlWelcome.Location = new System.Drawing.Point(11, 22);
			this.pnlWelcome.Margin = new System.Windows.Forms.Padding(2);
			this.pnlWelcome.Name = "pnlWelcome";
			this.pnlWelcome.Size = new System.Drawing.Size(440, 190);
			this.pnlWelcome.TabIndex = 53;
			// 
			// lblConnectSubtitle
			// 
			this.lblConnectSubtitle.Location = new System.Drawing.Point(16, 125);
			this.lblConnectSubtitle.Name = "lblConnectSubtitle";
			this.lblConnectSubtitle.Size = new System.Drawing.Size(406, 18);
			this.lblConnectSubtitle.TabIndex = 73;
			this.lblConnectSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdLockedNetwork
			// 
			this.cmdLockedNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdLockedNetwork.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdLockedNetwork.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdLockedNetwork.FlatAppearance.BorderSize = 0;
			this.cmdLockedNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLockedNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdLockedNetwork.ImageKey = "enter";
			this.cmdLockedNetwork.Location = new System.Drawing.Point(58, 151);
			this.cmdLockedNetwork.Margin = new System.Windows.Forms.Padding(0);
			this.cmdLockedNetwork.Name = "cmdLockedNetwork";
			this.cmdLockedNetwork.Size = new System.Drawing.Size(364, 35);
			this.cmdLockedNetwork.TabIndex = 71;
			this.cmdLockedNetwork.Text = "Enter";
			this.cmdLockedNetwork.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.cmdLockedNetwork.UseVisualStyleBackColor = true;
			this.cmdLockedNetwork.Click += new System.EventHandler(this.cmdLockedNetwork_Click);
			// 
			// lblLoginIcon
			// 
			this.lblLoginIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblLoginIcon.Image = global::AirVPN.Lib.Forms.Properties.Resources.login;
			this.lblLoginIcon.Location = new System.Drawing.Point(14, 4);
			this.lblLoginIcon.Name = "lblLoginIcon";
			this.lblLoginIcon.Size = new System.Drawing.Size(65, 78);
			this.lblLoginIcon.TabIndex = 70;
			// 
			// imgLockedNetwork
			// 
			this.imgLockedNetwork.Location = new System.Drawing.Point(16, 148);
			this.imgLockedNetwork.Name = "imgLockedNetwork";
			this.imgLockedNetwork.Size = new System.Drawing.Size(38, 38);
			this.imgLockedNetwork.TabIndex = 63;
			this.imgLockedNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdLogin
			// 
			this.cmdLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdLogin.FlatAppearance.BorderSize = 0;
			this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdLogin.ImageKey = "enter";
			this.cmdLogin.Location = new System.Drawing.Point(343, 2);
			this.cmdLogin.Margin = new System.Windows.Forms.Padding(0);
			this.cmdLogin.Name = "cmdLogin";
			this.cmdLogin.Size = new System.Drawing.Size(79, 56);
			this.cmdLogin.TabIndex = 61;
			this.cmdLogin.Text = "Login";
			this.cmdLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.cmdLogin.UseVisualStyleBackColor = true;
			this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.Black;
			this.lblPassword.Location = new System.Drawing.Point(83, 34);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(71, 22);
			this.lblPassword.TabIndex = 56;
			this.lblPassword.Text = "Password:";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLogin
			// 
			this.lblLogin.BackColor = System.Drawing.Color.Transparent;
			this.lblLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.Color.Black;
			this.lblLogin.Location = new System.Drawing.Point(83, 5);
			this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(71, 22);
			this.lblLogin.TabIndex = 55;
			this.lblLogin.Text = "Login:";
			this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdConnect
			// 
			this.cmdConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdConnect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdConnect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdConnect.FlatAppearance.BorderSize = 0;
			this.cmdConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdConnect.ImageKey = "enter";
			this.cmdConnect.Location = new System.Drawing.Point(16, 87);
			this.cmdConnect.Margin = new System.Windows.Forms.Padding(0);
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size(406, 35);
			this.cmdConnect.TabIndex = 60;
			this.cmdConnect.Text = "Enter";
			this.cmdConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.cmdConnect.UseVisualStyleBackColor = true;
			this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
			// 
			// chkRemember
			// 
			this.chkRemember.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkRemember.ForeColor = System.Drawing.Color.White;
			this.chkRemember.Location = new System.Drawing.Point(236, 62);
			this.chkRemember.Margin = new System.Windows.Forms.Padding(2);
			this.chkRemember.Name = "chkRemember";
			this.chkRemember.Size = new System.Drawing.Size(99, 17);
			this.chkRemember.TabIndex = 52;
			this.chkRemember.Text = "Remember";
			this.chkRemember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkRemember.CheckedChanged += new System.EventHandler(this.chkRemember_CheckedChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(158, 31);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(178, 27);
			this.txtPassword.TabIndex = 51;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// txtLogin
			// 
			this.txtLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogin.Location = new System.Drawing.Point(158, 2);
			this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(178, 27);
			this.txtLogin.TabIndex = 50;
			this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
			// 
			// pnlConnected
			// 
			this.pnlConnected.BackColor = System.Drawing.Color.Transparent;
			this.pnlConnected.Controls.Add(this.txtConnectedExitIp);
			this.pnlConnected.Controls.Add(this.lblConnectedExitIp);
			this.pnlConnected.Controls.Add(this.lblConnectedUpload);
			this.pnlConnected.Controls.Add(this.txtConnectedUpload);
			this.pnlConnected.Controls.Add(this.txtConnectedDownload);
			this.pnlConnected.Controls.Add(this.lblConnectedDownload);
			this.pnlConnected.Controls.Add(this.txtConnectedSince);
			this.pnlConnected.Controls.Add(this.lblConnectedSince);
			this.pnlConnected.Controls.Add(this.cmdDisconnect);
			this.pnlConnected.Controls.Add(this.lblConnectedLocation);
			this.pnlConnected.Controls.Add(this.lblConnectedTo);
			this.pnlConnected.Controls.Add(this.lblConnectedServerName);
			this.pnlConnected.Controls.Add(this.lblConnectedCountry);
			this.pnlConnected.Location = new System.Drawing.Point(211, 47);
			this.pnlConnected.Name = "pnlConnected";
			this.pnlConnected.Size = new System.Drawing.Size(440, 190);
			this.pnlConnected.TabIndex = 66;
			// 
			// txtConnectedExitIp
			// 
			this.txtConnectedExitIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConnectedExitIp.Location = new System.Drawing.Point(118, 112);
			this.txtConnectedExitIp.Name = "txtConnectedExitIp";
			this.txtConnectedExitIp.Size = new System.Drawing.Size(319, 15);
			this.txtConnectedExitIp.TabIndex = 69;
			this.txtConnectedExitIp.Text = "1.2.3.4";
			this.txtConnectedExitIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblConnectedExitIp
			// 
			this.lblConnectedExitIp.Location = new System.Drawing.Point(12, 112);
			this.lblConnectedExitIp.Name = "lblConnectedExitIp";
			this.lblConnectedExitIp.Size = new System.Drawing.Size(100, 15);
			this.lblConnectedExitIp.TabIndex = 68;
			this.lblConnectedExitIp.Text = "Public Exit IP:";
			this.lblConnectedExitIp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblConnectedUpload
			// 
			this.lblConnectedUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnectedUpload.Location = new System.Drawing.Point(225, 74);
			this.lblConnectedUpload.Name = "lblConnectedUpload";
			this.lblConnectedUpload.Size = new System.Drawing.Size(61, 15);
			this.lblConnectedUpload.TabIndex = 65;
			this.lblConnectedUpload.Text = "Upload:";
			this.lblConnectedUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtConnectedUpload
			// 
			this.txtConnectedUpload.BackColor = System.Drawing.Color.White;
			this.txtConnectedUpload.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConnectedUpload.ForeColor = System.Drawing.Color.ForestGreen;
			this.txtConnectedUpload.Location = new System.Drawing.Point(289, 68);
			this.txtConnectedUpload.Name = "txtConnectedUpload";
			this.txtConnectedUpload.Size = new System.Drawing.Size(135, 30);
			this.txtConnectedUpload.TabIndex = 67;
			this.txtConnectedUpload.Text = "14332 kb/s";
			this.txtConnectedUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtConnectedDownload
			// 
			this.txtConnectedDownload.BackColor = System.Drawing.Color.White;
			this.txtConnectedDownload.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConnectedDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
			this.txtConnectedDownload.Location = new System.Drawing.Point(85, 68);
			this.txtConnectedDownload.Name = "txtConnectedDownload";
			this.txtConnectedDownload.Size = new System.Drawing.Size(135, 30);
			this.txtConnectedDownload.TabIndex = 65;
			this.txtConnectedDownload.Text = "14332 kb/s";
			this.txtConnectedDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblConnectedDownload
			// 
			this.lblConnectedDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnectedDownload.Location = new System.Drawing.Point(12, 76);
			this.lblConnectedDownload.Name = "lblConnectedDownload";
			this.lblConnectedDownload.Size = new System.Drawing.Size(70, 15);
			this.lblConnectedDownload.TabIndex = 64;
			this.lblConnectedDownload.Text = "Download:";
			this.lblConnectedDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtConnectedSince
			// 
			this.txtConnectedSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConnectedSince.Location = new System.Drawing.Point(118, 127);
			this.txtConnectedSince.Name = "txtConnectedSince";
			this.txtConnectedSince.Size = new System.Drawing.Size(319, 15);
			this.txtConnectedSince.TabIndex = 63;
			this.txtConnectedSince.Text = "VPN Time";
			this.txtConnectedSince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblConnectedSince
			// 
			this.lblConnectedSince.Location = new System.Drawing.Point(12, 127);
			this.lblConnectedSince.Name = "lblConnectedSince";
			this.lblConnectedSince.Size = new System.Drawing.Size(100, 15);
			this.lblConnectedSince.TabIndex = 62;
			this.lblConnectedSince.Text = "Connection time:";
			this.lblConnectedSince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdDisconnect
			// 
			this.cmdDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdDisconnect.FlatAppearance.BorderSize = 0;
			this.cmdDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDisconnect.ImageKey = "enter";
			this.cmdDisconnect.Location = new System.Drawing.Point(15, 155);
			this.cmdDisconnect.Margin = new System.Windows.Forms.Padding(0);
			this.cmdDisconnect.Name = "cmdDisconnect";
			this.cmdDisconnect.Size = new System.Drawing.Size(410, 30);
			this.cmdDisconnect.TabIndex = 61;
			this.cmdDisconnect.Text = "Disconnect";
			this.cmdDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.cmdDisconnect.UseVisualStyleBackColor = true;
			this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
			// 
			// lblConnectedLocation
			// 
			this.lblConnectedLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnectedLocation.Location = new System.Drawing.Point(156, 40);
			this.lblConnectedLocation.Name = "lblConnectedLocation";
			this.lblConnectedLocation.Size = new System.Drawing.Size(266, 24);
			this.lblConnectedLocation.TabIndex = 3;
			this.lblConnectedLocation.Text = "Location";
			this.lblConnectedLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblConnectedTo
			// 
			this.lblConnectedTo.Location = new System.Drawing.Point(9, 11);
			this.lblConnectedTo.Name = "lblConnectedTo";
			this.lblConnectedTo.Size = new System.Drawing.Size(100, 20);
			this.lblConnectedTo.TabIndex = 2;
			this.lblConnectedTo.Text = "Connected to:";
			this.lblConnectedTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblConnectedServerName
			// 
			this.lblConnectedServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.lblConnectedServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnectedServerName.Location = new System.Drawing.Point(154, 10);
			this.lblConnectedServerName.Name = "lblConnectedServerName";
			this.lblConnectedServerName.Size = new System.Drawing.Size(271, 29);
			this.lblConnectedServerName.TabIndex = 1;
			this.lblConnectedServerName.Text = "Server Name";
			this.lblConnectedServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblConnectedCountry
			// 
			this.lblConnectedCountry.BackColor = System.Drawing.Color.Transparent;
			this.lblConnectedCountry.Image = global::AirVPN.Lib.Forms.Properties.Resources.blacklist_1;
			this.lblConnectedCountry.Location = new System.Drawing.Point(127, 13);
			this.lblConnectedCountry.Name = "lblConnectedCountry";
			this.lblConnectedCountry.Size = new System.Drawing.Size(20, 20);
			this.lblConnectedCountry.TabIndex = 0;
			this.lblConnectedCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlWaiting
			// 
			this.pnlWaiting.BackColor = System.Drawing.Color.Transparent;
			this.pnlWaiting.Controls.Add(this.lblWait2);
			this.pnlWaiting.Controls.Add(this.lblWait1);
			this.pnlWaiting.Controls.Add(this.cmdCancel);
			this.pnlWaiting.Location = new System.Drawing.Point(69, 224);
			this.pnlWaiting.Name = "pnlWaiting";
			this.pnlWaiting.Size = new System.Drawing.Size(231, 74);
			this.pnlWaiting.TabIndex = 65;
			// 
			// lblWait2
			// 
			this.lblWait2.BackColor = System.Drawing.Color.Transparent;
			this.lblWait2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWait2.Location = new System.Drawing.Point(14, 41);
			this.lblWait2.Name = "lblWait2";
			this.lblWait2.Size = new System.Drawing.Size(158, 21);
			this.lblWait2.TabIndex = 64;
			this.lblWait2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblWait1
			// 
			this.lblWait1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWait1.Location = new System.Drawing.Point(3, 0);
			this.lblWait1.Name = "lblWait1";
			this.lblWait1.Size = new System.Drawing.Size(74, 25);
			this.lblWait1.TabIndex = 63;
			this.lblWait1.Text = "label1";
			this.lblWait1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmdCancel
			// 
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdCancel.FlatAppearance.BorderSize = 0;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancel.ImageKey = "enter";
			this.cmdCancel.Location = new System.Drawing.Point(75, 54);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(2);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(69, 20);
			this.cmdCancel.TabIndex = 61;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.cmdCancel.UseVisualStyleBackColor = true;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// tabServers
			// 
			this.tabServers.BackColor = System.Drawing.Color.Transparent;
			this.tabServers.Controls.Add(this.cmdServersRefresh);
			this.tabServers.Controls.Add(this.lblScoreType);
			this.tabServers.Controls.Add(this.cboScoreType);
			this.tabServers.Controls.Add(this.chkShowAll);
			this.tabServers.Controls.Add(this.chkLockLast);
			this.tabServers.Controls.Add(this.pnlServers);
			this.tabServers.Controls.Add(this.cmdServersUndefined);
			this.tabServers.Controls.Add(this.cmdServersBlackList);
			this.tabServers.Controls.Add(this.cmdServersWhiteList);
			this.tabServers.Controls.Add(this.cmdServersConnect);
			this.tabServers.Location = new System.Drawing.Point(4, 24);
			this.tabServers.Margin = new System.Windows.Forms.Padding(2);
			this.tabServers.Name = "tabServers";
			this.tabServers.Padding = new System.Windows.Forms.Padding(2);
			this.tabServers.Size = new System.Drawing.Size(660, 301);
			this.tabServers.TabIndex = 0;
			this.tabServers.Text = "Servers";
			// 
			// lblScoreType
			// 
			this.lblScoreType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblScoreType.Location = new System.Drawing.Point(347, 279);
			this.lblScoreType.Name = "lblScoreType";
			this.lblScoreType.Size = new System.Drawing.Size(105, 18);
			this.lblScoreType.TabIndex = 65;
			this.lblScoreType.Text = "Scoring Rule:";
			this.lblScoreType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkShowAll
			// 
			this.chkShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkShowAll.AutoSize = true;
			this.chkShowAll.Location = new System.Drawing.Point(2, 279);
			this.chkShowAll.Margin = new System.Windows.Forms.Padding(2);
			this.chkShowAll.Name = "chkShowAll";
			this.chkShowAll.Size = new System.Drawing.Size(67, 17);
			this.chkShowAll.TabIndex = 7;
			this.chkShowAll.Text = "Show All";
			this.chkShowAll.UseVisualStyleBackColor = true;
			this.chkShowAll.CheckedChanged += new System.EventHandler(this.chkShowAll_CheckedChanged);
			// 
			// pnlServers
			// 
			this.pnlServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlServers.Location = new System.Drawing.Point(0, 0);
			this.pnlServers.Margin = new System.Windows.Forms.Padding(2);
			this.pnlServers.Name = "pnlServers";
			this.pnlServers.Size = new System.Drawing.Size(626, 275);
			this.pnlServers.TabIndex = 47;
			// 
			// tabAreas
			// 
			this.tabAreas.BackColor = System.Drawing.Color.Transparent;
			this.tabAreas.Controls.Add(this.pnlAreas);
			this.tabAreas.Controls.Add(this.cmdAreasUndefined);
			this.tabAreas.Controls.Add(this.cmdAreasBlackList);
			this.tabAreas.Controls.Add(this.cmdAreasWhiteList);
			this.tabAreas.Location = new System.Drawing.Point(4, 24);
			this.tabAreas.Margin = new System.Windows.Forms.Padding(2);
			this.tabAreas.Name = "tabAreas";
			this.tabAreas.Padding = new System.Windows.Forms.Padding(2);
			this.tabAreas.Size = new System.Drawing.Size(660, 301);
			this.tabAreas.TabIndex = 1;
			this.tabAreas.Text = "Countries";
			// 
			// pnlAreas
			// 
			this.pnlAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAreas.Location = new System.Drawing.Point(0, 0);
			this.pnlAreas.Margin = new System.Windows.Forms.Padding(2);
			this.pnlAreas.Name = "pnlAreas";
			this.pnlAreas.Size = new System.Drawing.Size(626, 301);
			this.pnlAreas.TabIndex = 49;
			// 
			// tabSpeed
			// 
			this.tabSpeed.Controls.Add(this.lblSpeedResolution);
			this.tabSpeed.Controls.Add(this.holSpeedChart);
			this.tabSpeed.Controls.Add(this.cboSpeedResolution);
			this.tabSpeed.Location = new System.Drawing.Point(4, 24);
			this.tabSpeed.Name = "tabSpeed";
			this.tabSpeed.Size = new System.Drawing.Size(660, 301);
			this.tabSpeed.TabIndex = 5;
			this.tabSpeed.Text = "Speed";
			this.tabSpeed.UseVisualStyleBackColor = true;
			// 
			// lblSpeedResolution
			// 
			this.lblSpeedResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSpeedResolution.Location = new System.Drawing.Point(3, 280);
			this.lblSpeedResolution.Name = "lblSpeedResolution";
			this.lblSpeedResolution.Size = new System.Drawing.Size(92, 19);
			this.lblSpeedResolution.TabIndex = 65;
			this.lblSpeedResolution.Text = "Resolution:";
			this.lblSpeedResolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// holSpeedChart
			// 
			this.holSpeedChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.holSpeedChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.holSpeedChart.Location = new System.Drawing.Point(0, 0);
			this.holSpeedChart.Name = "holSpeedChart";
			this.holSpeedChart.Size = new System.Drawing.Size(660, 277);
			this.holSpeedChart.TabIndex = 51;
			this.holSpeedChart.Text = "Speed Chart";
			this.holSpeedChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboSpeedResolution
			// 
			this.cboSpeedResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboSpeedResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSpeedResolution.FormattingEnabled = true;
			this.cboSpeedResolution.Location = new System.Drawing.Point(101, 279);
			this.cboSpeedResolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboSpeedResolution.Name = "cboSpeedResolution";
			this.cboSpeedResolution.Size = new System.Drawing.Size(556, 21);
			this.cboSpeedResolution.TabIndex = 50;
			this.cboSpeedResolution.SelectedIndexChanged += new System.EventHandler(this.cboSpeedResolution_SelectedIndexChanged);
			// 
			// tabStats
			// 
			this.tabStats.BackColor = System.Drawing.Color.Transparent;
			this.tabStats.Controls.Add(this.lstStats);
			this.tabStats.Location = new System.Drawing.Point(4, 24);
			this.tabStats.Margin = new System.Windows.Forms.Padding(2);
			this.tabStats.Name = "tabStats";
			this.tabStats.Size = new System.Drawing.Size(660, 301);
			this.tabStats.TabIndex = 2;
			this.tabStats.Text = "Stats";
			// 
			// lstStats
			// 
			this.lstStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colStatsKey,
            colStatsValue});
			this.lstStats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstStats.FullRowSelect = true;
			this.lstStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lstStats.HideSelection = false;
			this.lstStats.Location = new System.Drawing.Point(0, 0);
			this.lstStats.Margin = new System.Windows.Forms.Padding(2);
			this.lstStats.MultiSelect = false;
			this.lstStats.Name = "lstStats";
			this.lstStats.OwnerDraw = true;
			this.lstStats.ShowItemToolTips = true;
			this.lstStats.Size = new System.Drawing.Size(660, 301);
			this.lstStats.TabIndex = 1;
			this.lstStats.UseCompatibleStateImageBehavior = false;
			this.lstStats.View = System.Windows.Forms.View.Details;
			this.lstStats.DoubleClick += new System.EventHandler(this.lstStats_DoubleClick);
			// 
			// tabLogs
			// 
			this.tabLogs.BackColor = System.Drawing.Color.Transparent;
			this.tabLogs.Controls.Add(this.txtCommand);
			this.tabLogs.Controls.Add(this.cmdLogsSupport);
			this.tabLogs.Controls.Add(this.cmdLogsOpenVpnManagement);
			this.tabLogs.Controls.Add(this.lstLogs);
			this.tabLogs.Controls.Add(this.cmdLogsClean);
			this.tabLogs.Controls.Add(this.cmdLogsCopy);
			this.tabLogs.Controls.Add(this.cmdLogsSave);
			this.tabLogs.Location = new System.Drawing.Point(4, 24);
			this.tabLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabLogs.Name = "tabLogs";
			this.tabLogs.Size = new System.Drawing.Size(660, 301);
			this.tabLogs.TabIndex = 3;
			this.tabLogs.Text = "Logs";
			// 
			// txtCommand
			// 
			this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCommand.Location = new System.Drawing.Point(1, 280);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(625, 20);
			this.txtCommand.TabIndex = 52;
			this.txtCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyUp);
			// 
			// lstLogs
			// 
			this.lstLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colIcon,
            colDate,
            colMessage});
			this.lstLogs.ContextMenuStrip = this.mnuLogsContext;
			this.lstLogs.FullRowSelect = true;
			this.lstLogs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstLogs.HideSelection = false;
			this.lstLogs.LabelWrap = false;
			this.lstLogs.Location = new System.Drawing.Point(0, 0);
			this.lstLogs.Margin = new System.Windows.Forms.Padding(2);
			this.lstLogs.Name = "lstLogs";
			this.lstLogs.OwnerDraw = true;
			this.lstLogs.ShowItemToolTips = true;
			this.lstLogs.Size = new System.Drawing.Size(626, 280);
			this.lstLogs.TabIndex = 49;
			this.lstLogs.UseCompatibleStateImageBehavior = false;
			this.lstLogs.View = System.Windows.Forms.View.Details;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Fuchsia;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(833, 468);
			this.Controls.Add(this.lblNetLockStatus);
			this.Controls.Add(this.tabMain);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Main";
			this.Text = "AirVPN";
			this.mnuMain.ResumeLayout(false);
			this.mnuLogsContext.ResumeLayout(false);
			this.mnuServers.ResumeLayout(false);
			this.mnuAreas.ResumeLayout(false);
			this.tabMain.ResumeLayout(false);
			this.tabOverview.ResumeLayout(false);
			this.pnlWelcome.ResumeLayout(false);
			this.pnlWelcome.PerformLayout();
			this.pnlConnected.ResumeLayout(false);
			this.pnlWaiting.ResumeLayout(false);
			this.tabServers.ResumeLayout(false);
			this.tabServers.PerformLayout();
			this.tabAreas.ResumeLayout(false);
			this.tabSpeed.ResumeLayout(false);
			this.tabStats.ResumeLayout(false);
			this.tabLogs.ResumeLayout(false);
			this.tabLogs.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuRestore;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.ImageList imgButtons;
		private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuHomePage;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuPorts;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator2;        
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
		private System.Windows.Forms.ToolStripMenuItem mnuSpeedTest;
        public System.Windows.Forms.ImageList imgCountries;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuDevelopers;
        private System.Windows.Forms.ToolStripMenuItem mnuDevelopersManText;
        private System.Windows.Forms.ToolStripMenuItem mnuDevelopersUpdateManifest;
		private System.Windows.Forms.ToolStripMenuItem mnuDevelopersDefaultManifest;
		private Skin.Panel pnlWelcome;
		private Skin.Label lblPassword;
		private Skin.Label lblLogin;
		private Skin.CheckBox chkRemember;
		private Skin.TextBox txtPassword;
		public Skin.TextBox txtLogin;
		private Skin.Button cmdCancel;
		private Skin.Button cmdConnect;
		private System.Windows.Forms.ToolStripMenuItem mnuTools;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsPortForwarding;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsNetworkMonitor;
		private Skin.TabControl tabMain;
		private Skin.TabPage tabServers;
		private Skin.ComboBox cboScoreType;
		private Skin.CheckBox chkShowAll;
		private Skin.CheckBox chkLockLast;
		private System.Windows.Forms.Panel pnlServers;
		private Skin.Button cmdServersUndefined;
		private Skin.Button cmdServersBlackList;
		private Skin.Button cmdServersWhiteList;
		private Skin.Button cmdServersConnect;
		private Skin.TabPage tabAreas;
		private System.Windows.Forms.Panel pnlAreas;
		private Skin.Button cmdAreasUndefined;
		private Skin.Button cmdAreasBlackList;
		private Skin.Button cmdAreasWhiteList;
		private Skin.TabPage tabStats;
		private Skin.ListView lstStats;
		private Skin.TabPage tabLogs;
		private Skin.Button cmdLogsOpenVpnManagement;
		private Skin.ListView lstLogs;
		private Skin.Button cmdLogsClean;
		private Skin.Button cmdLogsCopy;
		private Skin.Button cmdLogsSave;
		private System.Windows.Forms.ContextMenuStrip mnuLogsContext;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ContextMenuStrip mnuServers;
		private System.Windows.Forms.ToolStripMenuItem mnuServersConnect;
		private System.Windows.Forms.ToolStripSeparator mnuServersSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuServersWhiteList;
		private System.Windows.Forms.ToolStripMenuItem mnuServersBlackList;
		private System.Windows.Forms.ToolStripMenuItem mnuServersUndefined;
		private System.Windows.Forms.ContextMenuStrip mnuAreas;
		private System.Windows.Forms.ToolStripMenuItem mnuAreasWhiteList;
		private System.Windows.Forms.ToolStripMenuItem mnuAreasBlackList;
		private System.Windows.Forms.ToolStripMenuItem mnuAreasUndefined;
		private Skin.TabPage tabOverview;
		private Skin.TabPage tabSpeed;
		private Skin.ComboBox cboSpeedResolution;
		private System.Windows.Forms.Label holSpeedChart;
		private Skin.Button cmdLogin;
		private Skin.Panel pnlWaiting;
		private Skin.Label lblWait2;
		private Skin.Label lblWait1;
		private Skin.Button cmdLogsSupport;
		private Skin.Label lblSpeedResolution;
		private Skin.Label lblScoreType;
		private Skin.Panel pnlConnected;
		private Skin.Label txtConnectedExitIp;
		private Skin.Label lblConnectedExitIp;
		private Skin.Label lblConnectedUpload;
		private System.Windows.Forms.Label txtConnectedUpload;
		private System.Windows.Forms.Label txtConnectedDownload;
		private Skin.Label lblConnectedDownload;
		private Skin.Label txtConnectedSince;
		private Skin.Label lblConnectedSince;
		private Skin.Button cmdDisconnect;
		private Skin.Label lblConnectedLocation;
		private Skin.Label lblConnectedTo;
		private Skin.Label lblConnectedServerName;
		private Skin.Label lblConnectedCountry;
		private Skin.Label imgLockedNetwork;
		private System.Windows.Forms.ToolStripMenuItem mnuDevelopersManBBCode;
		private System.Windows.Forms.Label lblLoginIcon;
		private System.Windows.Forms.ToolStripMenuItem mnuStatus;
		private System.Windows.Forms.ToolStripMenuItem mnuConnect;
		private System.Windows.Forms.ToolStripSeparator mnuSeparator4;
		private System.Windows.Forms.ToolStripSeparator mnuSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private Skin.Button cmdLockedNetwork;
		private System.Windows.Forms.ToolStripMenuItem mnuDevelopersReset;
		private Skin.Label lblConnectSubtitle;
		private Skin.Button cmdServersRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuServersRefresh;
		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Label lblNetLockStatus;		
    }
}

