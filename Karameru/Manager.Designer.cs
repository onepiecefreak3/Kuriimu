﻿namespace Karameru
{
	partial class frmManager
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
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gBATempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlsMain = new System.Windows.Forms.ToolStrip();
			this.tsbNew = new System.Windows.Forms.ToolStripButton();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.tsbSave = new System.Windows.Forms.ToolStripButton();
			this.tsbSaveAs = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbFind = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbKukkii = new System.Windows.Forms.ToolStripButton();
			this.tsbProperties = new System.Windows.Forms.ToolStripButton();
			this.tsbKuriimu = new System.Windows.Forms.ToolStripButton();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.splMain = new System.Windows.Forms.SplitContainer();
			this.treEntries = new System.Windows.Forms.TreeView();
			this.tlsEntries = new System.Windows.Forms.ToolStrip();
			this.tslFiles = new System.Windows.Forms.ToolStripLabel();
			this.tsbEntryAdd = new System.Windows.Forms.ToolStripButton();
			this.tsbEntryRename = new System.Windows.Forms.ToolStripButton();
			this.tsbEntryDelete = new System.Windows.Forms.ToolStripButton();
			this.tsbEntryProperties = new System.Windows.Forms.ToolStripButton();
			this.pnlPreview = new System.Windows.Forms.Panel();
			this.tlsPreview = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.tsbPreviewEnabled = new System.Windows.Forms.ToolStripButton();
			this.tsbPreviewSave = new System.Windows.Forms.ToolStripButton();
			this.tsbPreviewCopy = new System.Windows.Forms.ToolStripButton();
			this.imlFiles = new System.Windows.Forms.ImageList(this.components);
			this.mnuMain.SuspendLayout();
			this.tlsMain.SuspendLayout();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
			this.splMain.Panel1.SuspendLayout();
			this.splMain.Panel2.SuspendLayout();
			this.splMain.SuspendLayout();
			this.tlsEntries.SuspendLayout();
			this.tlsPreview.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.tolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.mnuMain.Size = new System.Drawing.Size(949, 24);
			this.mnuMain.TabIndex = 1;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Enabled = false;
			this.newToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_new;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.newToolStripMenuItem.Text = "&New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_open;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_save;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Enabled = false;
			this.saveAsToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_save_as;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.saveAsToolStripMenuItem.Text = "S&ave As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_exit;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.toolStripMenuItem1,
            this.propertiesToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Enabled = false;
			this.findToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_find;
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.findToolStripMenuItem.Text = "&Find";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
			// 
			// propertiesToolStripMenuItem
			// 
			this.propertiesToolStripMenuItem.Enabled = false;
			this.propertiesToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_properties;
			this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
			this.propertiesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.propertiesToolStripMenuItem.Text = "&Properties";
			this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
			// 
			// tolsToolStripMenuItem
			// 
			this.tolsToolStripMenuItem.Name = "tolsToolStripMenuItem";
			this.tolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.tolsToolStripMenuItem.Text = "&Tools";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gBATempToolStripMenuItem,
            this.gitHubToolStripMenuItem,
            this.toolStripSeparator7,
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.aboutToolStripMenuItem.Text = "&Help";
			// 
			// gBATempToolStripMenuItem
			// 
			this.gBATempToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_gbatemp;
			this.gBATempToolStripMenuItem.Name = "gBATempToolStripMenuItem";
			this.gBATempToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.gBATempToolStripMenuItem.Text = "GBATemp";
			this.gBATempToolStripMenuItem.Click += new System.EventHandler(this.gBATempToolStripMenuItem_Click);
			// 
			// gitHubToolStripMenuItem
			// 
			this.gitHubToolStripMenuItem.Image = global::Karameru.Properties.Resources.menu_git;
			this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
			this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.gitHubToolStripMenuItem.Text = "GitHub";
			this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(125, 6);
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Image = global::Karameru.Properties.Resources.menu_about;
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
			this.aboutToolStripMenuItem1.Text = "&About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// tlsMain
			// 
			this.tlsMain.AutoSize = false;
			this.tlsMain.BackColor = System.Drawing.Color.Transparent;
			this.tlsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.tsbSaveAs,
            this.toolStripSeparator2,
            this.tsbFind,
            this.toolStripSeparator3,
            this.tsbKukkii,
            this.tsbProperties,
            this.tsbKuriimu});
			this.tlsMain.Location = new System.Drawing.Point(0, 24);
			this.tlsMain.Name = "tlsMain";
			this.tlsMain.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.tlsMain.Size = new System.Drawing.Size(949, 27);
			this.tlsMain.TabIndex = 3;
			// 
			// tsbNew
			// 
			this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNew.Enabled = false;
			this.tsbNew.Image = global::Karameru.Properties.Resources.menu_new;
			this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNew.Name = "tsbNew";
			this.tsbNew.Size = new System.Drawing.Size(23, 22);
			this.tsbNew.Text = "New";
			// 
			// tsbOpen
			// 
			this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbOpen.Image = global::Karameru.Properties.Resources.menu_open;
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(23, 22);
			this.tsbOpen.Text = "Open";
			this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
			// 
			// tsbSave
			// 
			this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSave.Enabled = false;
			this.tsbSave.Image = global::Karameru.Properties.Resources.menu_save;
			this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSave.Name = "tsbSave";
			this.tsbSave.Size = new System.Drawing.Size(23, 22);
			this.tsbSave.Text = "Save";
			this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
			// 
			// tsbSaveAs
			// 
			this.tsbSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSaveAs.Enabled = false;
			this.tsbSaveAs.Image = global::Karameru.Properties.Resources.menu_save_as;
			this.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSaveAs.Name = "tsbSaveAs";
			this.tsbSaveAs.Size = new System.Drawing.Size(23, 22);
			this.tsbSaveAs.Text = "Save As...";
			this.tsbSaveAs.Click += new System.EventHandler(this.tsbSaveAs_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbFind
			// 
			this.tsbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbFind.Enabled = false;
			this.tsbFind.Image = global::Karameru.Properties.Resources.menu_find;
			this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbFind.Name = "tsbFind";
			this.tsbFind.Size = new System.Drawing.Size(23, 22);
			this.tsbFind.Text = "Find";
			this.tsbFind.Click += new System.EventHandler(this.tsbFind_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbKukkii
			// 
			this.tsbKukkii.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbKukkii.Image = global::Karameru.Properties.Resources.kukkii;
			this.tsbKukkii.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbKukkii.Name = "tsbKukkii";
			this.tsbKukkii.Size = new System.Drawing.Size(59, 22);
			this.tsbKukkii.Text = "Kukkii";
			this.tsbKukkii.Click += new System.EventHandler(this.tsbKukkii_Click);
			// 
			// tsbProperties
			// 
			this.tsbProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbProperties.Enabled = false;
			this.tsbProperties.Image = global::Karameru.Properties.Resources.menu_properties;
			this.tsbProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbProperties.Name = "tsbProperties";
			this.tsbProperties.Size = new System.Drawing.Size(23, 22);
			this.tsbProperties.Text = "Properties";
			this.tsbProperties.Click += new System.EventHandler(this.tsbProperties_Click);
			// 
			// tsbKuriimu
			// 
			this.tsbKuriimu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbKuriimu.Image = global::Karameru.Properties.Resources.kuriimu;
			this.tsbKuriimu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbKuriimu.Name = "tsbKuriimu";
			this.tsbKuriimu.Size = new System.Drawing.Size(69, 22);
			this.tsbKuriimu.Text = "Kuriimu";
			this.tsbKuriimu.Click += new System.EventHandler(this.tsbKuriimu_Click);
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.splMain);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 51);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Padding = new System.Windows.Forms.Padding(6);
			this.pnlMain.Size = new System.Drawing.Size(949, 576);
			this.pnlMain.TabIndex = 4;
			// 
			// splMain
			// 
			this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splMain.Enabled = false;
			this.splMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splMain.Location = new System.Drawing.Point(6, 6);
			this.splMain.Name = "splMain";
			// 
			// splMain.Panel1
			// 
			this.splMain.Panel1.Controls.Add(this.treEntries);
			this.splMain.Panel1.Controls.Add(this.tlsEntries);
			// 
			// splMain.Panel2
			// 
			this.splMain.Panel2.Controls.Add(this.pnlPreview);
			this.splMain.Panel2.Controls.Add(this.tlsPreview);
			this.splMain.Size = new System.Drawing.Size(937, 564);
			this.splMain.SplitterDistance = 320;
			this.splMain.SplitterWidth = 6;
			this.splMain.TabIndex = 1;
			// 
			// treEntries
			// 
			this.treEntries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treEntries.FullRowSelect = true;
			this.treEntries.HideSelection = false;
			this.treEntries.Indent = 16;
			this.treEntries.ItemHeight = 14;
			this.treEntries.Location = new System.Drawing.Point(0, 27);
			this.treEntries.Name = "treEntries";
			this.treEntries.ShowLines = false;
			this.treEntries.ShowPlusMinus = false;
			this.treEntries.ShowRootLines = false;
			this.treEntries.Size = new System.Drawing.Size(320, 537);
			this.treEntries.TabIndex = 4;
			// 
			// tlsEntries
			// 
			this.tlsEntries.AutoSize = false;
			this.tlsEntries.BackColor = System.Drawing.Color.Transparent;
			this.tlsEntries.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tlsEntries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFiles,
            this.tsbEntryAdd,
            this.tsbEntryRename,
            this.tsbEntryDelete,
            this.tsbEntryProperties});
			this.tlsEntries.Location = new System.Drawing.Point(0, 0);
			this.tlsEntries.Name = "tlsEntries";
			this.tlsEntries.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.tlsEntries.Size = new System.Drawing.Size(320, 27);
			this.tlsEntries.TabIndex = 0;
			// 
			// tslFiles
			// 
			this.tslFiles.Name = "tslFiles";
			this.tslFiles.Size = new System.Drawing.Size(33, 22);
			this.tslFiles.Text = "Files:";
			// 
			// tsbEntryAdd
			// 
			this.tsbEntryAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEntryAdd.Enabled = false;
			this.tsbEntryAdd.Image = global::Karameru.Properties.Resources.menu_add;
			this.tsbEntryAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEntryAdd.Name = "tsbEntryAdd";
			this.tsbEntryAdd.Size = new System.Drawing.Size(23, 22);
			this.tsbEntryAdd.Text = "Add Entry";
			this.tsbEntryAdd.Click += new System.EventHandler(this.tsbEntryAdd_Click);
			// 
			// tsbEntryRename
			// 
			this.tsbEntryRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEntryRename.Enabled = false;
			this.tsbEntryRename.Image = global::Karameru.Properties.Resources.menu_field_properties;
			this.tsbEntryRename.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEntryRename.Name = "tsbEntryRename";
			this.tsbEntryRename.Size = new System.Drawing.Size(23, 22);
			this.tsbEntryRename.Text = "Rename Entry";
			// 
			// tsbEntryDelete
			// 
			this.tsbEntryDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEntryDelete.Enabled = false;
			this.tsbEntryDelete.Image = global::Karameru.Properties.Resources.menu_delete;
			this.tsbEntryDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEntryDelete.Name = "tsbEntryDelete";
			this.tsbEntryDelete.Size = new System.Drawing.Size(23, 22);
			this.tsbEntryDelete.Text = "Delete Entry";
			// 
			// tsbEntryProperties
			// 
			this.tsbEntryProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEntryProperties.Enabled = false;
			this.tsbEntryProperties.Image = global::Karameru.Properties.Resources.menu_properties;
			this.tsbEntryProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEntryProperties.Name = "tsbEntryProperties";
			this.tsbEntryProperties.Size = new System.Drawing.Size(23, 22);
			this.tsbEntryProperties.Text = "Entry Properties";
			// 
			// pnlPreview
			// 
			this.pnlPreview.BackColor = System.Drawing.Color.DarkGray;
			this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPreview.Location = new System.Drawing.Point(0, 27);
			this.pnlPreview.Name = "pnlPreview";
			this.pnlPreview.Size = new System.Drawing.Size(611, 537);
			this.pnlPreview.TabIndex = 5;
			// 
			// tlsPreview
			// 
			this.tlsPreview.AutoSize = false;
			this.tlsPreview.BackColor = System.Drawing.Color.Transparent;
			this.tlsPreview.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tlsPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsbPreviewEnabled,
            this.tsbPreviewSave,
            this.tsbPreviewCopy});
			this.tlsPreview.Location = new System.Drawing.Point(0, 0);
			this.tlsPreview.Name = "tlsPreview";
			this.tlsPreview.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.tlsPreview.Size = new System.Drawing.Size(611, 27);
			this.tlsPreview.TabIndex = 4;
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
			this.toolStripLabel2.Text = "Preview:";
			// 
			// tsbPreviewEnabled
			// 
			this.tsbPreviewEnabled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPreviewEnabled.Enabled = false;
			this.tsbPreviewEnabled.Image = global::Karameru.Properties.Resources.menu_preview_visible;
			this.tsbPreviewEnabled.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPreviewEnabled.Name = "tsbPreviewEnabled";
			this.tsbPreviewEnabled.Size = new System.Drawing.Size(23, 22);
			this.tsbPreviewEnabled.Text = "Enable Preview";
			// 
			// tsbPreviewSave
			// 
			this.tsbPreviewSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPreviewSave.Enabled = false;
			this.tsbPreviewSave.Image = global::Karameru.Properties.Resources.menu_preview_save;
			this.tsbPreviewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPreviewSave.Name = "tsbPreviewSave";
			this.tsbPreviewSave.Size = new System.Drawing.Size(23, 22);
			this.tsbPreviewSave.Text = "Save Preview";
			// 
			// tsbPreviewCopy
			// 
			this.tsbPreviewCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPreviewCopy.Enabled = false;
			this.tsbPreviewCopy.Image = global::Karameru.Properties.Resources.menu_preview_copy;
			this.tsbPreviewCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPreviewCopy.Name = "tsbPreviewCopy";
			this.tsbPreviewCopy.Size = new System.Drawing.Size(23, 22);
			this.tsbPreviewCopy.Text = "Copy Preview";
			// 
			// imlFiles
			// 
			this.imlFiles.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imlFiles.ImageSize = new System.Drawing.Size(16, 16);
			this.imlFiles.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// frmManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 627);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.tlsMain);
			this.Controls.Add(this.mnuMain);
			this.Name = "frmManager";
			this.Text = "Karameru";
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.tlsMain.ResumeLayout(false);
			this.tlsMain.PerformLayout();
			this.pnlMain.ResumeLayout(false);
			this.splMain.Panel1.ResumeLayout(false);
			this.splMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
			this.splMain.ResumeLayout(false);
			this.tlsEntries.ResumeLayout(false);
			this.tlsEntries.PerformLayout();
			this.tlsPreview.ResumeLayout(false);
			this.tlsPreview.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gBATempToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStrip tlsMain;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.ToolStripButton tsbSave;
		private System.Windows.Forms.ToolStripButton tsbSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbFind;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbKukkii;
		private System.Windows.Forms.ToolStripButton tsbProperties;
		private System.Windows.Forms.ToolStripButton tsbKuriimu;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.SplitContainer splMain;
		private System.Windows.Forms.TreeView treEntries;
		private System.Windows.Forms.ToolStrip tlsEntries;
		private System.Windows.Forms.ToolStripLabel tslFiles;
		private System.Windows.Forms.ToolStripButton tsbEntryAdd;
		private System.Windows.Forms.ToolStripButton tsbEntryRename;
		private System.Windows.Forms.ToolStripButton tsbEntryDelete;
		private System.Windows.Forms.ToolStripButton tsbEntryProperties;
		private System.Windows.Forms.ToolStrip tlsPreview;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripButton tsbPreviewEnabled;
		private System.Windows.Forms.ToolStripButton tsbPreviewSave;
		private System.Windows.Forms.ToolStripButton tsbPreviewCopy;
		private System.Windows.Forms.Panel pnlPreview;
		private System.Windows.Forms.ImageList imlFiles;
	}
}

