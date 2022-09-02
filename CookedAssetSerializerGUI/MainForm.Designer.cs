﻿using CookedAssetSerializer;
using CookedAssetSerializerGUI.Properties;
using ExtendedTreeView;

namespace CookedAssetSerializerGUI;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    


    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tTipTree = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cntxtMainStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAllPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restorePathsToDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreAllSettingsToDefaultthisTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreAllSettingsToDefaultallTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAuthors = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbRun = new System.Windows.Forms.TabPage();
            this.rtxtProfileName = new System.Windows.Forms.RichTextBox();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.rtxtContentDir = new System.Windows.Forms.RichTextBox();
            this.rtxtJSONDir = new System.Windows.Forms.RichTextBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.chkAutoLoad = new System.Windows.Forms.CheckBox();
            this.chkDumNativ = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnSelectContentDir = new System.Windows.Forms.Button();
            this.btnOpenAllTypes = new System.Windows.Forms.Button();
            this.btnOpenAssetTypes = new System.Windows.Forms.Button();
            this.btnOpenLogs = new System.Windows.Forms.Button();
            this.btnSelectJSONDir = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnSerializeAssets = new System.Windows.Forms.Button();
            this.btnScanAssets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRefreshAssets = new System.Windows.Forms.CheckBox();
            this.cbUEVersion = new System.Windows.Forms.ComboBox();
            this.tbSerialSettings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.chkSettDNS = new System.Windows.Forms.CheckBox();
            this.rtxtSimpleAssets = new System.Windows.Forms.RichTextBox();
            this.chkDummyWithProps = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDummyAssets = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAssetsToSkipSerialization = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtCircularDependancy = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtLogDir = new System.Windows.Forms.RichTextBox();
            this.btnLogDir = new System.Windows.Forms.Button();
            this.tbNativSett = new System.Windows.Forms.TabPage();
            this.btnDfltGamCnfg = new System.Windows.Forms.Button();
            this.rtxtDfltGamCnfg = new System.Windows.Forms.RichTextBox();
            this.rtxtCXXDir = new System.Windows.Forms.RichTextBox();
            this.rtxtNativAssets = new System.Windows.Forms.RichTextBox();
            this.btnCXXDir = new System.Windows.Forms.Button();
            this.lbNativMode = new System.Windows.Forms.Label();
            this.cbNativMethod = new System.Windows.Forms.ComboBox();
            this.chkUserEnumStruct = new System.Windows.Forms.CheckBox();
            this.lbNativAssets = new System.Windows.Forms.Label();
            this.tabCpyDlt = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rtxtMoveFrom = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAssetsToDelete = new System.Windows.Forms.ListBox();
            this.btnMoveCookedAssets = new System.Windows.Forms.Button();
            this.rtxtMoveTo = new System.Windows.Forms.RichTextBox();
            this.btnSelectCookedDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtCookedAssets = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.treeParseDir = new ExtendedTreeView.ExTreeView();
            this.cntxtTreeParse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.cntxtMainStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbRun.SuspendLayout();
            this.tbSerialSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbNativSett.SuspendLayout();
            this.tabCpyDlt.SuspendLayout();
            this.panel4.SuspendLayout();
            this.cntxtTreeParse.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.ContextMenuStrip = this.cntxtMainStrip;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1241, 726);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // cntxtMainStrip
            // 
            this.cntxtMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllPathsToolStripMenuItem,
            this.restorePathsToDefaultsToolStripMenuItem,
            this.pauseSerializationToolStripMenuItem,
            this.cancelSerializationToolStripMenuItem,
            this.restoreAllSettingsToDefaultthisTabToolStripMenuItem,
            this.restoreAllSettingsToDefaultallTabsToolStripMenuItem});
            this.cntxtMainStrip.Name = "cntxtMainStrip";
            this.cntxtMainStrip.Size = new System.Drawing.Size(277, 136);
            this.cntxtMainStrip.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtMainStrip_Opening);
            // 
            // clearAllPathsToolStripMenuItem
            // 
            this.clearAllPathsToolStripMenuItem.Name = "clearAllPathsToolStripMenuItem";
            this.clearAllPathsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.clearAllPathsToolStripMenuItem.Text = "Clear all paths";
            this.clearAllPathsToolStripMenuItem.Click += new System.EventHandler(this.clearAllPathsToolStripMenuItem_Click);
            // 
            // restorePathsToDefaultsToolStripMenuItem
            // 
            this.restorePathsToDefaultsToolStripMenuItem.Name = "restorePathsToDefaultsToolStripMenuItem";
            this.restorePathsToDefaultsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.restorePathsToDefaultsToolStripMenuItem.Text = "Restore paths to defaults";
            this.restorePathsToDefaultsToolStripMenuItem.Click += new System.EventHandler(this.restorePathsToDefaultsToolStripMenuItem_Click);
            // 
            // pauseSerializationToolStripMenuItem
            // 
            this.pauseSerializationToolStripMenuItem.Name = "pauseSerializationToolStripMenuItem";
            this.pauseSerializationToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.pauseSerializationToolStripMenuItem.Text = "Pause Serialization";
            this.pauseSerializationToolStripMenuItem.Click += new System.EventHandler(this.cancelSerializationToolStripMenuItem_Click);
            // 
            // cancelSerializationToolStripMenuItem
            // 
            this.cancelSerializationToolStripMenuItem.Name = "cancelSerializationToolStripMenuItem";
            this.cancelSerializationToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.cancelSerializationToolStripMenuItem.Text = "Cancel Serialization";
            this.cancelSerializationToolStripMenuItem.Click += new System.EventHandler(this.cancelSerializationToolStripMenuItem_Click_1);
            // 
            // restoreAllSettingsToDefaultthisTabToolStripMenuItem
            // 
            this.restoreAllSettingsToDefaultthisTabToolStripMenuItem.Name = "restoreAllSettingsToDefaultthisTabToolStripMenuItem";
            this.restoreAllSettingsToDefaultthisTabToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.restoreAllSettingsToDefaultthisTabToolStripMenuItem.Text = "Restore all settings to default (this tab)";
            this.restoreAllSettingsToDefaultthisTabToolStripMenuItem.Click += new System.EventHandler(this.restoreAllSettingsToDefaultthisTabToolStripMenuItem_Click);
            // 
            // restoreAllSettingsToDefaultallTabsToolStripMenuItem
            // 
            this.restoreAllSettingsToDefaultallTabsToolStripMenuItem.Name = "restoreAllSettingsToDefaultallTabsToolStripMenuItem";
            this.restoreAllSettingsToDefaultallTabsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.restoreAllSettingsToDefaultallTabsToolStripMenuItem.Text = "Restore all settings to default (all tabs)";
            this.restoreAllSettingsToDefaultallTabsToolStripMenuItem.Click += new System.EventHandler(this.restoreAllSettingsToDefaultallTabsToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lbAuthors);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 720);
            this.panel2.TabIndex = 1;
            // 
            // lbAuthors
            // 
            this.lbAuthors.AutoSize = true;
            this.lbAuthors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lbAuthors.Location = new System.Drawing.Point(519, 1);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(393, 15);
            this.lbAuthors.TabIndex = 40;
            this.lbAuthors.Text = "Written by LongerWarrior, Buckminsterfullerene and atenfyr (UAAPI)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbRun);
            this.tabControl1.Controls.Add(this.tbSerialSettings);
            this.tabControl1.Controls.Add(this.tbNativSett);
            this.tabControl1.Controls.Add(this.tabCpyDlt);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 709);
            this.tabControl1.TabIndex = 39;
            // 
            // tbRun
            // 
            this.tbRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbRun.Controls.Add(this.richTextBox1);
            this.tbRun.Controls.Add(this.button5);
            this.tbRun.Controls.Add(this.rtxtProfileName);
            this.tbRun.Controls.Add(this.rtxtOutput);
            this.tbRun.Controls.Add(this.rtxtContentDir);
            this.tbRun.Controls.Add(this.rtxtJSONDir);
            this.tbRun.Controls.Add(this.btnProfile);
            this.tbRun.Controls.Add(this.chkAutoLoad);
            this.tbRun.Controls.Add(this.chkDumNativ);
            this.tbRun.Controls.Add(this.label2);
            this.tbRun.Controls.Add(this.btnLoadConfig);
            this.tbRun.Controls.Add(this.btnSaveConfig);
            this.tbRun.Controls.Add(this.btnSelectContentDir);
            this.tbRun.Controls.Add(this.btnOpenAllTypes);
            this.tbRun.Controls.Add(this.btnOpenAssetTypes);
            this.tbRun.Controls.Add(this.btnOpenLogs);
            this.tbRun.Controls.Add(this.btnSelectJSONDir);
            this.tbRun.Controls.Add(this.lblProgress);
            this.tbRun.Controls.Add(this.btnClearLogs);
            this.tbRun.Controls.Add(this.btnSerializeAssets);
            this.tbRun.Controls.Add(this.btnScanAssets);
            this.tbRun.Controls.Add(this.label1);
            this.tbRun.Controls.Add(this.chkRefreshAssets);
            this.tbRun.Controls.Add(this.cbUEVersion);
            this.tbRun.Location = new System.Drawing.Point(4, 24);
            this.tbRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRun.Name = "tbRun";
            this.tbRun.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRun.Size = new System.Drawing.Size(956, 681);
            this.tbRun.TabIndex = 0;
            this.tbRun.Text = "Run";
            // 
            // rtxtProfileName
            // 
            this.rtxtProfileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtProfileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProfileName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtProfileName.Location = new System.Drawing.Point(150, 18);
            this.rtxtProfileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtProfileName.Multiline = false;
            this.rtxtProfileName.Name = "rtxtProfileName";
            this.rtxtProfileName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtProfileName.Size = new System.Drawing.Size(787, 30);
            this.rtxtProfileName.TabIndex = 41;
            this.rtxtProfileName.Text = "Enter Game Name";
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtOutput.Location = new System.Drawing.Point(16, 342);
            this.rtxtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.ReadOnly = true;
            this.rtxtOutput.Size = new System.Drawing.Size(925, 284);
            this.rtxtOutput.TabIndex = 23;
            this.rtxtOutput.Text = "";
            this.rtxtOutput.WordWrap = false;
            // 
            // rtxtContentDir
            // 
            this.rtxtContentDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtContentDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtContentDir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtContentDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtContentDir.Location = new System.Drawing.Point(150, 52);
            this.rtxtContentDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtContentDir.Multiline = false;
            this.rtxtContentDir.Name = "rtxtContentDir";
            this.rtxtContentDir.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtContentDir.Size = new System.Drawing.Size(787, 30);
            this.rtxtContentDir.TabIndex = 1;
            this.rtxtContentDir.Text = "C:\\ExamplePath\\Content";
            this.rtxtContentDir.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateContentDir);
            // 
            // rtxtJSONDir
            // 
            this.rtxtJSONDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtJSONDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtJSONDir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtJSONDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtJSONDir.Location = new System.Drawing.Point(150, 120);
            this.rtxtJSONDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtJSONDir.Multiline = false;
            this.rtxtJSONDir.Name = "rtxtJSONDir";
            this.rtxtJSONDir.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtJSONDir.Size = new System.Drawing.Size(787, 30);
            this.rtxtJSONDir.TabIndex = 3;
            this.rtxtJSONDir.Text = "C:\\ExamplePath\\AssetDump";
            this.rtxtJSONDir.Enter += new System.EventHandler(this.rtxtJSONDir_Enter);
            this.rtxtJSONDir.Leave += new System.EventHandler(this.rtxtJSONDir_Leave);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnProfile.FlatAppearance.BorderSize = 2;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnProfile.Location = new System.Drawing.Point(13, 18);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(122, 30);
            this.btnProfile.TabIndex = 40;
            this.btnProfile.Text = "Profile Name";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // chkAutoLoad
            // 
            this.chkAutoLoad.AutoSize = true;
            this.chkAutoLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkAutoLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.chkAutoLoad.Location = new System.Drawing.Point(24, 224);
            this.chkAutoLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAutoLoad.Name = "chkAutoLoad";
            this.chkAutoLoad.Size = new System.Drawing.Size(245, 25);
            this.chkAutoLoad.TabIndex = 39;
            this.chkAutoLoad.Text = "Auto Load Profile on Launch";
            this.chkAutoLoad.UseVisualStyleBackColor = true;
            this.chkAutoLoad.CheckedChanged += new System.EventHandler(this.chkAutoLoad_CheckedChanged);
            // 
            // chkDumNativ
            // 
            this.chkDumNativ.AutoSize = true;
            this.chkDumNativ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkDumNativ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.chkDumNativ.Location = new System.Drawing.Point(316, 170);
            this.chkDumNativ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDumNativ.Name = "chkDumNativ";
            this.chkDumNativ.Size = new System.Drawing.Size(164, 25);
            this.chkDumNativ.TabIndex = 38;
            this.chkDumNativ.Text = "Uses Nativ. Assets";
            this.chkDumNativ.UseVisualStyleBackColor = true;
            this.chkDumNativ.CheckedChanged += new System.EventHandler(this.chkDumNativ_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(434, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Output";
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnLoadConfig.FlatAppearance.BorderSize = 2;
            this.btnLoadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnLoadConfig.Location = new System.Drawing.Point(556, 637);
            this.btnLoadConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(114, 30);
            this.btnLoadConfig.TabIndex = 29;
            this.btnLoadConfig.Text = "Load Profile";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnSaveConfig.FlatAppearance.BorderSize = 2;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSaveConfig.Location = new System.Drawing.Point(426, 637);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(124, 30);
            this.btnSaveConfig.TabIndex = 30;
            this.btnSaveConfig.Text = "Save Profile";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnSelectContentDir
            // 
            this.btnSelectContentDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnSelectContentDir.FlatAppearance.BorderSize = 2;
            this.btnSelectContentDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectContentDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectContentDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSelectContentDir.Location = new System.Drawing.Point(13, 52);
            this.btnSelectContentDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectContentDir.Name = "btnSelectContentDir";
            this.btnSelectContentDir.Size = new System.Drawing.Size(122, 30);
            this.btnSelectContentDir.TabIndex = 0;
            this.btnSelectContentDir.Text = "Content Dir";
            this.btnSelectContentDir.UseVisualStyleBackColor = true;
            this.btnSelectContentDir.Click += new System.EventHandler(this.btnSelectContentDir_Click);
            // 
            // btnOpenAllTypes
            // 
            this.btnOpenAllTypes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnOpenAllTypes.FlatAppearance.BorderSize = 2;
            this.btnOpenAllTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAllTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenAllTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnOpenAllTypes.Location = new System.Drawing.Point(16, 637);
            this.btnOpenAllTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenAllTypes.Name = "btnOpenAllTypes";
            this.btnOpenAllTypes.Size = new System.Drawing.Size(160, 30);
            this.btnOpenAllTypes.TabIndex = 25;
            this.btnOpenAllTypes.Text = "Open Asset List";
            this.btnOpenAllTypes.UseVisualStyleBackColor = true;
            this.btnOpenAllTypes.Click += new System.EventHandler(this.btnOpenAllTypes_Click);
            // 
            // btnOpenAssetTypes
            // 
            this.btnOpenAssetTypes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnOpenAssetTypes.FlatAppearance.BorderSize = 2;
            this.btnOpenAssetTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAssetTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenAssetTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnOpenAssetTypes.Location = new System.Drawing.Point(197, 637);
            this.btnOpenAssetTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenAssetTypes.Name = "btnOpenAssetTypes";
            this.btnOpenAssetTypes.Size = new System.Drawing.Size(177, 30);
            this.btnOpenAssetTypes.TabIndex = 24;
            this.btnOpenAssetTypes.Text = "Open AssetTypes";
            this.btnOpenAssetTypes.UseVisualStyleBackColor = true;
            this.btnOpenAssetTypes.Click += new System.EventHandler(this.btnOpenAssetTypes_Click);
            // 
            // btnOpenLogs
            // 
            this.btnOpenLogs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnOpenLogs.FlatAppearance.BorderSize = 2;
            this.btnOpenLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnOpenLogs.Location = new System.Drawing.Point(677, 637);
            this.btnOpenLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.Size = new System.Drawing.Size(121, 30);
            this.btnOpenLogs.TabIndex = 26;
            this.btnOpenLogs.Text = "Open Logs";
            this.btnOpenLogs.UseVisualStyleBackColor = true;
            this.btnOpenLogs.Click += new System.EventHandler(this.btnOpenLogs_Click);
            // 
            // btnSelectJSONDir
            // 
            this.btnSelectJSONDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnSelectJSONDir.FlatAppearance.BorderSize = 2;
            this.btnSelectJSONDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectJSONDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectJSONDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSelectJSONDir.Location = new System.Drawing.Point(13, 120);
            this.btnSelectJSONDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectJSONDir.Name = "btnSelectJSONDir";
            this.btnSelectJSONDir.Size = new System.Drawing.Size(122, 30);
            this.btnSelectJSONDir.TabIndex = 2;
            this.btnSelectJSONDir.Text = "Result Dir";
            this.btnSelectJSONDir.UseVisualStyleBackColor = true;
            this.btnSelectJSONDir.Click += new System.EventHandler(this.btnSelectJSONDir_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lblProgress.Location = new System.Drawing.Point(362, 265);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(233, 30);
            this.lblProgress.TabIndex = 31;
            this.lblProgress.Text = "0/0";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnClearLogs.FlatAppearance.BorderSize = 2;
            this.btnClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnClearLogs.Location = new System.Drawing.Point(820, 637);
            this.btnClearLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(121, 30);
            this.btnClearLogs.TabIndex = 28;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // btnSerializeAssets
            // 
            this.btnSerializeAssets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnSerializeAssets.FlatAppearance.BorderSize = 2;
            this.btnSerializeAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerializeAssets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSerializeAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSerializeAssets.Location = new System.Drawing.Point(556, 219);
            this.btnSerializeAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSerializeAssets.Name = "btnSerializeAssets";
            this.btnSerializeAssets.Size = new System.Drawing.Size(198, 30);
            this.btnSerializeAssets.TabIndex = 18;
            this.btnSerializeAssets.Text = "Serialize Assets";
            this.btnSerializeAssets.UseVisualStyleBackColor = true;
            this.btnSerializeAssets.Click += new System.EventHandler(this.btnSerializeAssets_Click);
            // 
            // btnScanAssets
            // 
            this.btnScanAssets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnScanAssets.FlatAppearance.BorderSize = 2;
            this.btnScanAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanAssets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScanAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnScanAssets.Location = new System.Drawing.Point(556, 166);
            this.btnScanAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScanAssets.Name = "btnScanAssets";
            this.btnScanAssets.Size = new System.Drawing.Size(198, 30);
            this.btnScanAssets.TabIndex = 16;
            this.btnScanAssets.Text = "Scan Asset Registry";
            this.btnScanAssets.UseVisualStyleBackColor = true;
            this.btnScanAssets.Click += new System.EventHandler(this.btnScanAssets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(24, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "UE Version:";
            // 
            // chkRefreshAssets
            // 
            this.chkRefreshAssets.AutoSize = true;
            this.chkRefreshAssets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkRefreshAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.chkRefreshAssets.Location = new System.Drawing.Point(316, 199);
            this.chkRefreshAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRefreshAssets.Name = "chkRefreshAssets";
            this.chkRefreshAssets.Size = new System.Drawing.Size(137, 25);
            this.chkRefreshAssets.TabIndex = 8;
            this.chkRefreshAssets.Text = "Refresh Assets";
            this.chkRefreshAssets.UseVisualStyleBackColor = true;
            // 
            // cbUEVersion
            // 
            this.cbUEVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.cbUEVersion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUEVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbUEVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbUEVersion.FormattingEnabled = true;
            this.cbUEVersion.Location = new System.Drawing.Point(139, 180);
            this.cbUEVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUEVersion.Name = "cbUEVersion";
            this.cbUEVersion.Size = new System.Drawing.Size(156, 29);
            this.cbUEVersion.TabIndex = 7;
            // 
            // tbSerialSettings
            // 
            this.tbSerialSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbSerialSettings.Controls.Add(this.panel1);
            this.tbSerialSettings.Controls.Add(this.rtxtSimpleAssets);
            this.tbSerialSettings.Controls.Add(this.chkDummyWithProps);
            this.tbSerialSettings.Controls.Add(this.label9);
            this.tbSerialSettings.Controls.Add(this.lbDummyAssets);
            this.tbSerialSettings.Controls.Add(this.label3);
            this.tbSerialSettings.Controls.Add(this.lbAssetsToSkipSerialization);
            this.tbSerialSettings.Controls.Add(this.label5);
            this.tbSerialSettings.Controls.Add(this.rtxtCircularDependancy);
            this.tbSerialSettings.Controls.Add(this.label6);
            this.tbSerialSettings.Location = new System.Drawing.Point(4, 24);
            this.tbSerialSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerialSettings.Name = "tbSerialSettings";
            this.tbSerialSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerialSettings.Size = new System.Drawing.Size(956, 681);
            this.tbSerialSettings.TabIndex = 1;
            this.tbSerialSettings.Text = "Serialization Settings";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.chkSettDNS);
            this.panel1.Controls.Add(this.rtxtLogDir);
            this.panel1.Controls.Add(this.btnLogDir);
            this.panel1.Location = new System.Drawing.Point(21, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 177);
            this.panel1.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label10.Location = new System.Drawing.Point(394, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "General Settings";
            // 
            // chkSettDNS
            // 
            this.chkSettDNS.AutoSize = true;
            this.chkSettDNS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkSettDNS.Location = new System.Drawing.Point(322, 44);
            this.chkSettDNS.Name = "chkSettDNS";
            this.chkSettDNS.Size = new System.Drawing.Size(268, 23);
            this.chkSettDNS.TabIndex = 41;
            this.chkSettDNS.Text = "Do Not Show Save Prompt on Close";
            this.chkSettDNS.UseVisualStyleBackColor = true;
            this.chkSettDNS.CheckedChanged += new System.EventHandler(this.chkSettDNS_CheckedChanged);
            // 
            // rtxtSimpleAssets
            // 
            this.rtxtSimpleAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtSimpleAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtSimpleAssets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtSimpleAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtSimpleAssets.Location = new System.Drawing.Point(14, 33);
            this.rtxtSimpleAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtSimpleAssets.Name = "rtxtSimpleAssets";
            this.rtxtSimpleAssets.Size = new System.Drawing.Size(472, 189);
            this.rtxtSimpleAssets.TabIndex = 15;
            this.rtxtSimpleAssets.Text = resources.GetString("rtxtSimpleAssets.Text");
            this.rtxtSimpleAssets.WordWrap = false;
            // 
            // chkDummyWithProps
            // 
            this.chkDummyWithProps.AutoSize = true;
            this.chkDummyWithProps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkDummyWithProps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.chkDummyWithProps.Location = new System.Drawing.Point(633, 414);
            this.chkDummyWithProps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDummyWithProps.Name = "chkDummyWithProps";
            this.chkDummyWithProps.Size = new System.Drawing.Size(213, 25);
            this.chkDummyWithProps.TabIndex = 38;
            this.chkDummyWithProps.Text = "Dummy With Properties";
            this.chkDummyWithProps.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label9.Location = new System.Drawing.Point(613, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 30);
            this.label9.TabIndex = 34;
            this.label9.Text = "Assets Types to dummy";
            // 
            // lbDummyAssets
            // 
            this.lbDummyAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.lbDummyAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDummyAssets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDummyAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lbDummyAssets.FormattingEnabled = true;
            this.lbDummyAssets.ItemHeight = 21;
            this.lbDummyAssets.Location = new System.Drawing.Point(510, 263);
            this.lbDummyAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDummyAssets.Name = "lbDummyAssets";
            this.lbDummyAssets.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDummyAssets.Size = new System.Drawing.Size(428, 147);
            this.lbDummyAssets.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(570, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Assets Types to skip serializing";
            // 
            // lbAssetsToSkipSerialization
            // 
            this.lbAssetsToSkipSerialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.lbAssetsToSkipSerialization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAssetsToSkipSerialization.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAssetsToSkipSerialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lbAssetsToSkipSerialization.FormattingEnabled = true;
            this.lbAssetsToSkipSerialization.ItemHeight = 21;
            this.lbAssetsToSkipSerialization.Location = new System.Drawing.Point(510, 33);
            this.lbAssetsToSkipSerialization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAssetsToSkipSerialization.Name = "lbAssetsToSkipSerialization";
            this.lbAssetsToSkipSerialization.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAssetsToSkipSerialization.Size = new System.Drawing.Size(428, 189);
            this.lbAssetsToSkipSerialization.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(156, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Simple assets";
            // 
            // rtxtCircularDependancy
            // 
            this.rtxtCircularDependancy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtCircularDependancy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCircularDependancy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtCircularDependancy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtCircularDependancy.Location = new System.Drawing.Point(14, 263);
            this.rtxtCircularDependancy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtCircularDependancy.Name = "rtxtCircularDependancy";
            this.rtxtCircularDependancy.Size = new System.Drawing.Size(472, 147);
            this.rtxtCircularDependancy.TabIndex = 20;
            this.rtxtCircularDependancy.Text = "/Script/Engine.SoundClass\n/Script/Engine.SoundSubmix\n/Script/Engine.EndpointSubmi" +
    "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(54, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Assets with a circular dependancy";
            // 
            // rtxtLogDir
            // 
            this.rtxtLogDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtLogDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtLogDir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtLogDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtLogDir.Location = new System.Drawing.Point(141, 140);
            this.rtxtLogDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtLogDir.Multiline = false;
            this.rtxtLogDir.Name = "rtxtLogDir";
            this.rtxtLogDir.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtLogDir.Size = new System.Drawing.Size(768, 30);
            this.rtxtLogDir.TabIndex = 37;
            this.rtxtLogDir.Text = "C:\\ExamplePath\\Logs";
            this.rtxtLogDir.Enter += new System.EventHandler(this.rtxtInfoDir_Enter);
            this.rtxtLogDir.Leave += new System.EventHandler(this.rtxtInfoDir_Leave);
            // 
            // btnLogDir
            // 
            this.btnLogDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnLogDir.FlatAppearance.BorderSize = 2;
            this.btnLogDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnLogDir.Location = new System.Drawing.Point(3, 140);
            this.btnLogDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogDir.Name = "btnLogDir";
            this.btnLogDir.Size = new System.Drawing.Size(132, 30);
            this.btnLogDir.TabIndex = 36;
            this.btnLogDir.Text = "Log Dir";
            this.btnLogDir.UseVisualStyleBackColor = true;
            this.btnLogDir.Click += new System.EventHandler(this.btnInfoDir_Click);
            // 
            // tbNativSett
            // 
            this.tbNativSett.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbNativSett.Controls.Add(this.btnDfltGamCnfg);
            this.tbNativSett.Controls.Add(this.rtxtDfltGamCnfg);
            this.tbNativSett.Controls.Add(this.rtxtCXXDir);
            this.tbNativSett.Controls.Add(this.rtxtNativAssets);
            this.tbNativSett.Controls.Add(this.btnCXXDir);
            this.tbNativSett.Controls.Add(this.lbNativMode);
            this.tbNativSett.Controls.Add(this.cbNativMethod);
            this.tbNativSett.Controls.Add(this.chkUserEnumStruct);
            this.tbNativSett.Controls.Add(this.lbNativAssets);
            this.tbNativSett.Location = new System.Drawing.Point(4, 24);
            this.tbNativSett.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNativSett.Name = "tbNativSett";
            this.tbNativSett.Padding = new System.Windows.Forms.Padding(3);
            this.tbNativSett.Size = new System.Drawing.Size(956, 681);
            this.tbNativSett.TabIndex = 2;
            this.tbNativSett.Text = "Nativ. Asset Settings";
            // 
            // btnDfltGamCnfg
            // 
            this.btnDfltGamCnfg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnDfltGamCnfg.FlatAppearance.BorderSize = 2;
            this.btnDfltGamCnfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDfltGamCnfg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDfltGamCnfg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnDfltGamCnfg.Location = new System.Drawing.Point(14, 16);
            this.btnDfltGamCnfg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDfltGamCnfg.Name = "btnDfltGamCnfg";
            this.btnDfltGamCnfg.Size = new System.Drawing.Size(122, 30);
            this.btnDfltGamCnfg.TabIndex = 23;
            this.btnDfltGamCnfg.Text = "Game .ini";
            this.btnDfltGamCnfg.UseVisualStyleBackColor = true;
            this.btnDfltGamCnfg.Click += new System.EventHandler(this.btnDfltGamCnfg_Click);
            // 
            // rtxtDfltGamCnfg
            // 
            this.rtxtDfltGamCnfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtDfltGamCnfg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDfltGamCnfg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtDfltGamCnfg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtDfltGamCnfg.Location = new System.Drawing.Point(151, 16);
            this.rtxtDfltGamCnfg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtDfltGamCnfg.Multiline = false;
            this.rtxtDfltGamCnfg.Name = "rtxtDfltGamCnfg";
            this.rtxtDfltGamCnfg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtDfltGamCnfg.Size = new System.Drawing.Size(787, 30);
            this.rtxtDfltGamCnfg.TabIndex = 24;
            this.rtxtDfltGamCnfg.Text = "C:\\ExamplePath\\DefaultGame.ini";
            this.rtxtDfltGamCnfg.TextChanged += new System.EventHandler(this.rtxtDfltGamCnfg_TextChanged);
            // 
            // rtxtCXXDir
            // 
            this.rtxtCXXDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtCXXDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCXXDir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtCXXDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtCXXDir.Location = new System.Drawing.Point(151, 61);
            this.rtxtCXXDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtCXXDir.Multiline = false;
            this.rtxtCXXDir.Name = "rtxtCXXDir";
            this.rtxtCXXDir.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtCXXDir.Size = new System.Drawing.Size(787, 30);
            this.rtxtCXXDir.TabIndex = 22;
            this.rtxtCXXDir.Text = "C:\\ExamplePath\\CXXHeaderDump";
            this.rtxtCXXDir.TextChanged += new System.EventHandler(this.rtxtCXXDir_TextChanged);
            // 
            // rtxtNativAssets
            // 
            this.rtxtNativAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtNativAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNativAssets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtNativAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtNativAssets.Location = new System.Drawing.Point(213, 163);
            this.rtxtNativAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtNativAssets.Name = "rtxtNativAssets";
            this.rtxtNativAssets.Size = new System.Drawing.Size(543, 189);
            this.rtxtNativAssets.TabIndex = 17;
            this.rtxtNativAssets.Text = "Copy/Paste List of Nativized Assets from DefaultGame.ini or Select DefaultGame.in" +
    "i Above";
            // 
            // btnCXXDir
            // 
            this.btnCXXDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnCXXDir.FlatAppearance.BorderSize = 2;
            this.btnCXXDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCXXDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCXXDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnCXXDir.Location = new System.Drawing.Point(14, 61);
            this.btnCXXDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCXXDir.Name = "btnCXXDir";
            this.btnCXXDir.Size = new System.Drawing.Size(122, 30);
            this.btnCXXDir.TabIndex = 21;
            this.btnCXXDir.Text = "CXX Hdr Dir";
            this.btnCXXDir.UseVisualStyleBackColor = true;
            this.btnCXXDir.Click += new System.EventHandler(this.btnCXXDir_Click);
            // 
            // lbNativMode
            // 
            this.lbNativMode.AutoSize = true;
            this.lbNativMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNativMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lbNativMode.Location = new System.Drawing.Point(218, 363);
            this.lbNativMode.Name = "lbNativMode";
            this.lbNativMode.Size = new System.Drawing.Size(157, 21);
            this.lbNativMode.TabIndex = 19;
            this.lbNativMode.Text = "Nativization Mode:";
            // 
            // cbNativMethod
            // 
            this.cbNativMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.cbNativMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNativMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbNativMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cbNativMethod.FormattingEnabled = true;
            this.cbNativMethod.Location = new System.Drawing.Point(378, 357);
            this.cbNativMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNativMethod.Name = "cbNativMethod";
            this.cbNativMethod.Size = new System.Drawing.Size(156, 29);
            this.cbNativMethod.TabIndex = 20;
            // 
            // chkUserEnumStruct
            // 
            this.chkUserEnumStruct.AutoSize = true;
            this.chkUserEnumStruct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkUserEnumStruct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.chkUserEnumStruct.Location = new System.Drawing.Point(218, 409);
            this.chkUserEnumStruct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUserEnumStruct.Name = "chkUserEnumStruct";
            this.chkUserEnumStruct.Size = new System.Drawing.Size(325, 25);
            this.chkUserEnumStruct.TabIndex = 18;
            this.chkUserEnumStruct.Text = "Create User Defined Enums and Structs";
            this.chkUserEnumStruct.UseVisualStyleBackColor = true;
            // 
            // lbNativAssets
            // 
            this.lbNativAssets.AutoSize = true;
            this.lbNativAssets.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNativAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lbNativAssets.Location = new System.Drawing.Point(336, 133);
            this.lbNativAssets.Name = "lbNativAssets";
            this.lbNativAssets.Size = new System.Drawing.Size(286, 30);
            this.lbNativAssets.TabIndex = 16;
            this.lbNativAssets.Text = "Nativized Blueprint Assets";
            // 
            // tabCpyDlt
            // 
            this.tabCpyDlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tabCpyDlt.Controls.Add(this.button3);
            this.tabCpyDlt.Controls.Add(this.button2);
            this.tabCpyDlt.Controls.Add(this.rtxtMoveFrom);
            this.tabCpyDlt.Controls.Add(this.button1);
            this.tabCpyDlt.Controls.Add(this.label8);
            this.tabCpyDlt.Controls.Add(this.label7);
            this.tabCpyDlt.Controls.Add(this.lbAssetsToDelete);
            this.tabCpyDlt.Controls.Add(this.btnMoveCookedAssets);
            this.tabCpyDlt.Controls.Add(this.rtxtMoveTo);
            this.tabCpyDlt.Controls.Add(this.btnSelectCookedDir);
            this.tabCpyDlt.Controls.Add(this.label4);
            this.tabCpyDlt.Controls.Add(this.rtxtCookedAssets);
            this.tabCpyDlt.Location = new System.Drawing.Point(4, 24);
            this.tabCpyDlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCpyDlt.Name = "tabCpyDlt";
            this.tabCpyDlt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCpyDlt.Size = new System.Drawing.Size(956, 681);
            this.tabCpyDlt.TabIndex = 4;
            this.tabCpyDlt.Text = "Copy/Move/Delete";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.button3.Location = new System.Drawing.Point(383, 527);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 30);
            this.button3.TabIndex = 45;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.button2.Location = new System.Drawing.Point(383, 471);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 30);
            this.button2.TabIndex = 44;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rtxtMoveFrom
            // 
            this.rtxtMoveFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtMoveFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMoveFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtMoveFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtMoveFrom.Location = new System.Drawing.Point(150, 78);
            this.rtxtMoveFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtMoveFrom.Multiline = false;
            this.rtxtMoveFrom.Name = "rtxtMoveFrom";
            this.rtxtMoveFrom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtMoveFrom.Size = new System.Drawing.Size(787, 30);
            this.rtxtMoveFrom.TabIndex = 43;
            this.rtxtMoveFrom.Text = "C:\\ExamplePath\\OriginalDir";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(13, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 42;
            this.button1.Text = "Move From Dir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(182, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Asset Types";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(330, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 30);
            this.label7.TabIndex = 39;
            this.label7.Text = "Copy, Delete, or Move Assets";
            // 
            // lbAssetsToDelete
            // 
            this.lbAssetsToDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.lbAssetsToDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAssetsToDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAssetsToDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lbAssetsToDelete.FormattingEnabled = true;
            this.lbAssetsToDelete.ItemHeight = 21;
            this.lbAssetsToDelete.Location = new System.Drawing.Point(52, 200);
            this.lbAssetsToDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAssetsToDelete.Name = "lbAssetsToDelete";
            this.lbAssetsToDelete.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAssetsToDelete.Size = new System.Drawing.Size(413, 189);
            this.lbAssetsToDelete.TabIndex = 40;
            // 
            // btnMoveCookedAssets
            // 
            this.btnMoveCookedAssets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnMoveCookedAssets.FlatAppearance.BorderSize = 2;
            this.btnMoveCookedAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveCookedAssets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMoveCookedAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnMoveCookedAssets.Location = new System.Drawing.Point(383, 412);
            this.btnMoveCookedAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveCookedAssets.Name = "btnMoveCookedAssets";
            this.btnMoveCookedAssets.Size = new System.Drawing.Size(198, 30);
            this.btnMoveCookedAssets.TabIndex = 17;
            this.btnMoveCookedAssets.Text = "Move";
            this.btnMoveCookedAssets.UseVisualStyleBackColor = true;
            this.btnMoveCookedAssets.Click += new System.EventHandler(this.btnMoveCookedAssets_Click);
            // 
            // rtxtMoveTo
            // 
            this.rtxtMoveTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtMoveTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMoveTo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtMoveTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtMoveTo.Location = new System.Drawing.Point(150, 122);
            this.rtxtMoveTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtMoveTo.Multiline = false;
            this.rtxtMoveTo.Name = "rtxtMoveTo";
            this.rtxtMoveTo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtMoveTo.Size = new System.Drawing.Size(787, 30);
            this.rtxtMoveTo.TabIndex = 5;
            this.rtxtMoveTo.Text = "C:\\ExamplePath\\MoveToDir";
            this.rtxtMoveTo.Enter += new System.EventHandler(this.rtxtCookedDir_Enter);
            this.rtxtMoveTo.Leave += new System.EventHandler(this.rtxtCookedDir_Leave);
            // 
            // btnSelectCookedDir
            // 
            this.btnSelectCookedDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.btnSelectCookedDir.FlatAppearance.BorderSize = 2;
            this.btnSelectCookedDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCookedDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectCookedDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnSelectCookedDir.Location = new System.Drawing.Point(13, 122);
            this.btnSelectCookedDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCookedDir.Name = "btnSelectCookedDir";
            this.btnSelectCookedDir.Size = new System.Drawing.Size(122, 30);
            this.btnSelectCookedDir.TabIndex = 4;
            this.btnSelectCookedDir.Text = "Move To Dir";
            this.btnSelectCookedDir.UseVisualStyleBackColor = true;
            this.btnSelectCookedDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(556, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cooked asset types to copy";
            // 
            // rtxtCookedAssets
            // 
            this.rtxtCookedAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.rtxtCookedAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCookedAssets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rtxtCookedAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtxtCookedAssets.Location = new System.Drawing.Point(492, 200);
            this.rtxtCookedAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtCookedAssets.Name = "rtxtCookedAssets";
            this.rtxtCookedAssets.Size = new System.Drawing.Size(413, 189);
            this.rtxtCookedAssets.TabIndex = 13;
            this.rtxtCookedAssets.Text = resources.GetString("rtxtCookedAssets.Text");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.treeParseDir);
            this.panel4.Location = new System.Drawing.Point(979, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 720);
            this.panel4.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.button4.Location = new System.Drawing.Point(154, 685);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 30);
            this.button4.TabIndex = 46;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // treeParseDir
            // 
            this.treeParseDir.CheckBoxes = true;
            this.treeParseDir.ContextMenuStrip = this.cntxtTreeParse;
            this.treeParseDir.Location = new System.Drawing.Point(3, 3);
            this.treeParseDir.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.treeParseDir.Name = "treeParseDir";
            this.treeParseDir.ShowNodeToolTips = true;
            this.treeParseDir.Size = new System.Drawing.Size(247, 677);
            this.treeParseDir.TabIndex = 2;
            this.treeParseDir.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeParseDir_AfterCheck);
            this.treeParseDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeParseDir_BeforeExpand);
            this.treeParseDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeParseDir_KeyDown);
            this.treeParseDir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeParseDir_MouseDown);
            this.treeParseDir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeParseDir_MouseMove);
            // 
            // cntxtTreeParse
            // 
            this.cntxtTreeParse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.copyPathToolStripMenuItem,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.refreshAllToolStripMenuItem});
            this.cntxtTreeParse.Name = "cntxtTreeParse";
            this.cntxtTreeParse.Size = new System.Drawing.Size(130, 114);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // copyPathToolStripMenuItem
            // 
            this.copyPathToolStripMenuItem.Name = "copyPathToolStripMenuItem";
            this.copyPathToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.copyPathToolStripMenuItem.Text = "&Copy path";
            this.copyPathToolStripMenuItem.Click += new System.EventHandler(this.copyPathToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.expandAllToolStripMenuItem.Text = "&Expand";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.collapseAllToolStripMenuItem.Text = "Collap&se";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // refreshAllToolStripMenuItem
            // 
            this.refreshAllToolStripMenuItem.Name = "refreshAllToolStripMenuItem";
            this.refreshAllToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.refreshAllToolStripMenuItem.Text = "&Refresh";
            this.refreshAllToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.richTextBox1.Location = new System.Drawing.Point(150, 86);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(787, 30);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "C:\\ExamplePath\\AssetRegistry.bin";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.button5.Location = new System.Drawing.Point(13, 86);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 30);
            this.button5.TabIndex = 42;
            this.button5.Text = "Asset Reg";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1250, 736);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooked Asset Serializer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.cntxtMainStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbRun.ResumeLayout(false);
            this.tbRun.PerformLayout();
            this.tbSerialSettings.ResumeLayout(false);
            this.tbSerialSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbNativSett.ResumeLayout(false);
            this.tbNativSett.PerformLayout();
            this.tabCpyDlt.ResumeLayout(false);
            this.tabCpyDlt.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.cntxtTreeParse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private ToolTip tTipTree;
    private FlowLayoutPanel flowLayoutPanel1;
    private ExTreeView treeParseDir;
    private Panel panel2;
    private Label lbAuthors;
    private ContextMenuStrip cntxtTreeParse;
    private ToolStripMenuItem expandAllToolStripMenuItem;
    private ToolStripMenuItem collapseAllToolStripMenuItem;
    private ToolStripMenuItem refreshAllToolStripMenuItem;
    private ContextMenuStrip cntxtMainStrip;
    private ToolStripMenuItem clearAllPathsToolStripMenuItem;
    private ToolStripMenuItem restorePathsToDefaultsToolStripMenuItem;
    private ToolStripMenuItem pauseSerializationToolStripMenuItem;
    private ToolStripMenuItem cancelSerializationToolStripMenuItem;
    private ToolStripMenuItem restoreAllSettingsToDefaultthisTabToolStripMenuItem;
    private ToolStripMenuItem restoreAllSettingsToDefaultallTabsToolStripMenuItem;
    private ToolStripMenuItem copyPathToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private Panel panel4;
    private TabControl tabControl1;
    private TabPage tbRun;
    private RichTextBox rtxtProfileName;
    private RichTextBox rtxtLogDir;
    private RichTextBox rtxtOutput;
    private RichTextBox rtxtContentDir;
    private RichTextBox rtxtJSONDir;
    private RichTextBox rtxtMoveTo;
    private Button btnProfile;
    private CheckBox chkAutoLoad;
    private CheckBox chkDumNativ;
    private Label label2;
    private Button btnLoadConfig;
    private Button btnSaveConfig;
    private Button btnSelectContentDir;
    private Button btnLogDir;
    private Button btnOpenAllTypes;
    private Button btnOpenAssetTypes;
    private Button btnOpenLogs;
    private Button btnSelectJSONDir;
    private Label lblProgress;
    private Button btnClearLogs;
    private Button btnSerializeAssets;
    private Button btnSelectCookedDir;
    private Button btnMoveCookedAssets;
    private Button btnScanAssets;
    private Label label1;
    private CheckBox chkRefreshAssets;
    private ComboBox cbUEVersion;
    private TabPage tbSerialSettings;
    private CheckBox chkSettDNS;
    private Label label7;
    private ListBox lbAssetsToDelete;
    private CheckBox chkDummyWithProps;
    private Label label9;
    private ListBox lbDummyAssets;
    private Label label3;
    private ListBox lbAssetsToSkipSerialization;
    private Label label5;
    private Label label4;
    private RichTextBox rtxtCookedAssets;
    private RichTextBox rtxtSimpleAssets;
    private RichTextBox rtxtCircularDependancy;
    private Label label6;
    private TabPage tbNativSett;
    private Button btnDfltGamCnfg;
    private RichTextBox rtxtDfltGamCnfg;
    private RichTextBox rtxtCXXDir;
    private RichTextBox rtxtNativAssets;
    private Button btnCXXDir;
    private Label lbNativMode;
    private ComboBox cbNativMethod;
    private CheckBox chkUserEnumStruct;
    private Label lbNativAssets;
    private TabPage tabCpyDlt;
    private Label label8;
    private Button button3;
    private Button button2;
    private RichTextBox rtxtMoveFrom;
    private Button button1;
    private Button button4;
    private Label label10;
    private Panel panel1;
    private RichTextBox richTextBox1;
    private Button button5;
}
