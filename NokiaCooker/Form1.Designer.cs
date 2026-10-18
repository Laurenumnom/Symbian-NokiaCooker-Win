
namespace FuzzyByte.NokiaCooker
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFATMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importROFSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importUnknMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractRomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nokiaCookerBETA01MarcoBellinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewAdv1 = new System.Windows.Forms.TreeView();
            this.contextTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridFiles1 = new System.Windows.Forms.ListView();
            this.contextFileView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblFolders = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstimatedSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPartSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bwOpenFile = new System.ComponentModel.BackgroundWorker();
            this.bwRepack = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.openROFS = new System.Windows.Forms.OpenFileDialog();
            this.openFAT = new System.Windows.Forms.OpenFileDialog();
            this.openUnkn = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.contextToolBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLargeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnExplore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUnlockRofs = new System.Windows.Forms.ToolStripButton();
            this.btnRofs1Increase = new System.Windows.Forms.ToolStripButton();
            this.btnRepartition = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textAreaAdv1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolPlugins = new System.Windows.Forms.ToolStrip();
            this.contextPlugin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuitemPluginUseBigIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemPluginShowText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.addNewPluginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removePluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timerCompute = new System.Windows.Forms.Timer(this.components);
            this.bwComputeSize = new System.ComponentModel.BackgroundWorker();
            this.bwFilesOperation = new System.ComponentModel.BackgroundWorker();
            this.updateSizeLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.bwDeleteTrashFolder = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextTreeView.SuspendLayout();
            this.contextFileView.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.contextToolBar.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolPlugins.SuspendLayout();
            this.contextPlugin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel4.Text = "Other useful stuff:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel2.Text = "IconHider";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "ROMPatcher+";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel3.Text = "Guardian IRIDIUM";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.closeMenuItem,
            this.saveMenuItem,
            this.recentFilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Folder_open;
            this.openMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Enabled = false;
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Enabled = false;
            this.saveMenuItem.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.SaveHH;
            this.saveMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFATMenuItem,
            this.importROFSMenuItem,
            this.importUnknMenuItem,
            this.extractRomMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // importFATMenuItem
            // 
            this.importFATMenuItem.Enabled = false;
            this.importFATMenuItem.Name = "importFATMenuItem";
            this.importFATMenuItem.Size = new System.Drawing.Size(255, 22);
            this.importFATMenuItem.Text = "Repack using fat data: FAT.IMA";
            this.importFATMenuItem.Click += new System.EventHandler(this.importFATIMAToolStripMenuItem_Click);
            // 
            // importROFSMenuItem
            // 
            this.importROFSMenuItem.Enabled = false;
            this.importROFSMenuItem.Name = "importROFSMenuItem";
            this.importROFSMenuItem.Size = new System.Drawing.Size(255, 22);
            this.importROFSMenuItem.Text = "Repack using rofs data: ROFS.ROM";
            this.importROFSMenuItem.Click += new System.EventHandler(this.importROFSROMToolStripMenuItem_Click);
            // 
            // importUnknMenuItem
            // 
            this.importUnknMenuItem.Enabled = false;
            this.importUnknMenuItem.Name = "importUnknMenuItem";
            this.importUnknMenuItem.Size = new System.Drawing.Size(255, 22);
            this.importUnknMenuItem.Text = "Repack using raw data: UNKN.BIN";
            this.importUnknMenuItem.Click += new System.EventHandler(this.repackUnknMenuItem_Click);
            // 
            // extractRomMenuItem
            // 
            this.extractRomMenuItem.Enabled = false;
            this.extractRomMenuItem.Name = "extractRomMenuItem";
            this.extractRomMenuItem.Size = new System.Drawing.Size(255, 22);
            this.extractRomMenuItem.Text = "Extract ROM to file...";
            this.extractRomMenuItem.Click += new System.EventHandler(this.extractRomMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nokiaCookerBETA01MarcoBellinoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // nokiaCookerBETA01MarcoBellinoToolStripMenuItem
            // 
            this.nokiaCookerBETA01MarcoBellinoToolStripMenuItem.Name = "nokiaCookerBETA01MarcoBellinoToolStripMenuItem";
            this.nokiaCookerBETA01MarcoBellinoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.nokiaCookerBETA01MarcoBellinoToolStripMenuItem.Text = "NokiaCooker by Marco Bellino";
            this.nokiaCookerBETA01MarcoBellinoToolStripMenuItem.Click += new System.EventHandler(this.nokiaCookerBETA01MarcoBellinoToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewAdv1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridFiles1);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(761, 25);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 6;
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowDrop = true;
            this.treeViewAdv1.ContextMenuStrip = this.contextTreeView;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeViewAdv1.HideSelection = false;
            this.treeViewAdv1.HotTracking = true;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.ShowRootLines = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(25, 25);
            this.treeViewAdv1.TabIndex = 1;
            this.treeViewAdv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAdv1_AfterSelect);
            this.treeViewAdv1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewAdv1_DragDrop);
            this.treeViewAdv1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewAdv1_DragEnter);
            // 
            // contextTreeView
            // 
            this.contextTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.contextTreeView.Name = "contextMenuStrip1";
            this.contextTreeView.Size = new System.Drawing.Size(135, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Cancel24;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem1.Text = "Remove";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Windows_Explorer;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem2.Text = "Explore";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.add;
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.minus;
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // gridFiles1
            // 
            this.gridFiles1.AllowDrop = true;
            this.gridFiles1.ContextMenuStrip = this.contextFileView;
            this.gridFiles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFiles1.HideSelection = false;
            this.gridFiles1.Location = new System.Drawing.Point(0, 0);
            this.gridFiles1.Margin = new System.Windows.Forms.Padding(2);
            this.gridFiles1.MultiSelect = false;
            this.gridFiles1.Name = "gridFiles1";
            this.gridFiles1.Size = new System.Drawing.Size(732, 3);
            this.gridFiles1.TabIndex = 12;
            this.gridFiles1.UseCompatibleStateImageBehavior = false;
            this.gridFiles1.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridFiles1_DragDrop);
            this.gridFiles1.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridFiles1_DragEnter);
            this.gridFiles1.DoubleClick += new System.EventHandler(this.gridFiles1_DoubleClick);
            // 
            // contextFileView
            // 
            this.contextFileView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFilesToolStripMenuItem,
            this.exploreToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.contextFileView.Name = "contextMenuStrip1";
            this.contextFileView.Size = new System.Drawing.Size(121, 70);
            this.contextFileView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // removeFilesToolStripMenuItem
            // 
            this.removeFilesToolStripMenuItem.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Cancel24;
            this.removeFilesToolStripMenuItem.Name = "removeFilesToolStripMenuItem";
            this.removeFilesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.removeFilesToolStripMenuItem.Text = "Remove";
            // 
            // exploreToolStripMenuItem
            // 
            this.exploreToolStripMenuItem.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Windows_Explorer;
            this.exploreToolStripMenuItem.Name = "exploreToolStripMenuItem";
            this.exploreToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exploreToolStripMenuItem.Text = "Explore";
            this.exploreToolStripMenuItem.Click += new System.EventHandler(this.exploreToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFolders,
            this.lblFiles,
            this.toolStripStatusLabel8,
            this.lblSize,
            this.toolStripStatusLabel6,
            this.lblEstimatedSize,
            this.toolStripStatusLabel7,
            this.lblPartSize});
            this.statusStrip2.Location = new System.Drawing.Point(0, 3);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(732, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 10;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblFolders
            // 
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.Size = new System.Drawing.Size(48, 17);
            this.lblFolders.Text = "Folders:";
            // 
            // lblFiles
            // 
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(33, 17);
            this.lblFiles.Text = "Files:";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel8.Text = "|";
            // 
            // lblSize
            // 
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 17);
            this.lblSize.Text = "Size:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(423, 17);
            this.toolStripStatusLabel6.Spring = true;
            // 
            // lblEstimatedSize
            // 
            this.lblEstimatedSize.Name = "lblEstimatedSize";
            this.lblEstimatedSize.Size = new System.Drawing.Size(86, 17);
            this.lblEstimatedSize.Text = "Estimated Size: ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // lblPartSize
            // 
            this.lblPartSize.Name = "lblPartSize";
            this.lblPartSize.Size = new System.Drawing.Size(77, 17);
            this.lblPartSize.Text = "Partition Size:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Firmware files (*.fpsx; *.v??; *.c??)|*.fpsx;*.v??;*.c??|All files (*.*)|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Firmware File";
            // 
            // bwOpenFile
            // 
            this.bwOpenFile.WorkerReportsProgress = true;
            this.bwOpenFile.WorkerSupportsCancellation = true;
            this.bwOpenFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwOpenFile_DoWork);
            this.bwOpenFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwOpenFile_ProgressChanged);
            this.bwOpenFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwOpenFile_RunWorkerCompleted);
            // 
            // bwRepack
            // 
            this.bwRepack.WorkerReportsProgress = true;
            this.bwRepack.WorkerSupportsCancellation = true;
            this.bwRepack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRepack_DoWork);
            this.bwRepack.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwRepack_ProgressChanged);
            this.bwRepack.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRepack_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openROFS
            // 
            this.openROFS.Filter = "ROFS-ROFX files (*.rom)|*.rom|All files (*.*)|*.*";
            this.openROFS.RestoreDirectory = true;
            this.openROFS.Title = "Select ROFS-ROFX File";
            // 
            // openFAT
            // 
            this.openFAT.Filter = "FAT files (*.ima)|*.ima|All files (*.*)|*.*";
            this.openFAT.RestoreDirectory = true;
            this.openFAT.Title = "Select FAT File";
            // 
            // openUnkn
            // 
            this.openUnkn.Filter = "RAW data file (*.bin;*.raw)|*.bin;*.raw|All files (*.*)|*.*";
            this.openUnkn.RestoreDirectory = true;
            this.openUnkn.Title = "Select RAW data file";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolbar
            // 
            this.toolbar.ContextMenuStrip = this.contextToolBar;
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeStripItem,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnExplore,
            this.toolStripSeparator5,
            this.btnUnlockRofs,
            this.btnRofs1Increase,
            this.btnRepartition});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(761, 52);
            this.toolbar.TabIndex = 2;
            this.toolbar.Text = "toolStrip1";
            // 
            // contextToolBar
            // 
            this.contextToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLargeIconsToolStripMenuItem,
            this.showTextToolStripMenuItem});
            this.contextToolBar.Name = "contextToolBar";
            this.contextToolBar.Size = new System.Drawing.Size(144, 48);
            // 
            // showLargeIconsToolStripMenuItem
            // 
            this.showLargeIconsToolStripMenuItem.Name = "showLargeIconsToolStripMenuItem";
            this.showLargeIconsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.showLargeIconsToolStripMenuItem.Text = "Use Big Icons";
            this.showLargeIconsToolStripMenuItem.Click += new System.EventHandler(this.showLargeIconsToolStripMenuItem_Click);
            // 
            // showTextToolStripMenuItem
            // 
            this.showTextToolStripMenuItem.Name = "showTextToolStripMenuItem";
            this.showTextToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.showTextToolStripMenuItem.Text = "Show Text";
            this.showTextToolStripMenuItem.Click += new System.EventHandler(this.showTextToolStripMenuItem_Click);
            // 
            // closeStripItem
            // 
            this.closeStripItem.Enabled = false;
            this.closeStripItem.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Cancel24;
            this.closeStripItem.Name = "closeStripItem";
            this.closeStripItem.Size = new System.Drawing.Size(47, 52);
            this.closeStripItem.Text = "Close";
            this.closeStripItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeStripItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Folder_open;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 49);
            this.btnOpen.Text = "Open Firmware";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpen.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Save_File;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 49);
            this.btnSave.Text = "Save Firmware";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // btnExplore
            // 
            this.btnExplore.Enabled = false;
            this.btnExplore.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Windows_Explorer;
            this.btnExplore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 49);
            this.btnExplore.Text = "Explore Files";
            this.btnExplore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // btnUnlockRofs
            // 
            this.btnUnlockRofs.Enabled = false;
            this.btnUnlockRofs.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Unlock;
            this.btnUnlockRofs.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnUnlockRofs.Name = "btnUnlockRofs";
            this.btnUnlockRofs.Size = new System.Drawing.Size(78, 49);
            this.btnUnlockRofs.Text = "Unlock ROFS";
            this.btnUnlockRofs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnlockRofs.Click += new System.EventHandler(this.btnUnlockRofs_Click);
            // 
            // btnRofs1Increase
            // 
            this.btnRofs1Increase.Enabled = false;
            this.btnRofs1Increase.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.Resize_ROFS;
            this.btnRofs1Increase.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRofs1Increase.Name = "btnRofs1Increase";
            this.btnRofs1Increase.Size = new System.Drawing.Size(83, 49);
            this.btnRofs1Increase.Text = "Extend ROFS1";
            this.btnRofs1Increase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRofs1Increase.Click += new System.EventHandler(this.btnRofs1Increase_Click);
            // 
            // btnRepartition
            // 
            this.btnRepartition.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.partitions;
            this.btnRepartition.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRepartition.Name = "btnRepartition";
            this.btnRepartition.Size = new System.Drawing.Size(104, 49);
            this.btnRepartition.Text = "Partition Manager";
            this.btnRepartition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRepartition.Click += new System.EventHandler(this.btnRepartition_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 106);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textAreaAdv1);
            this.splitContainer2.Size = new System.Drawing.Size(761, 213);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 8;
            // 
            // textAreaAdv1
            // 
            this.textAreaAdv1.BackColor = System.Drawing.SystemColors.Info;
            this.textAreaAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAreaAdv1.Location = new System.Drawing.Point(0, 0);
            this.textAreaAdv1.Margin = new System.Windows.Forms.Padding(4);
            this.textAreaAdv1.Multiline = true;
            this.textAreaAdv1.Name = "textAreaAdv1";
            this.textAreaAdv1.ReadOnly = true;
            this.textAreaAdv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAreaAdv1.Size = new System.Drawing.Size(761, 184);
            this.textAreaAdv1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(444, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "don\'t unpack";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolPlugins
            // 
            this.toolPlugins.AllowDrop = true;
            this.toolPlugins.ContextMenuStrip = this.contextPlugin;
            this.toolPlugins.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator4});
            this.toolPlugins.Location = new System.Drawing.Point(0, 76);
            this.toolPlugins.Name = "toolPlugins";
            this.toolPlugins.Size = new System.Drawing.Size(761, 30);
            this.toolPlugins.TabIndex = 10;
            this.toolPlugins.Text = "c";
            this.toolPlugins.DragDrop += new System.Windows.Forms.DragEventHandler(this.toolStrip2_DragDrop);
            this.toolPlugins.DragEnter += new System.Windows.Forms.DragEventHandler(this.toolStrip2_DragEnter);
            // 
            // contextPlugin
            // 
            this.contextPlugin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemPluginUseBigIcons,
            this.menuitemPluginShowText});
            this.contextPlugin.Name = "contextToolBar";
            this.contextPlugin.Size = new System.Drawing.Size(144, 48);
            // 
            // menuitemPluginUseBigIcons
            // 
            this.menuitemPluginUseBigIcons.Name = "menuitemPluginUseBigIcons";
            this.menuitemPluginUseBigIcons.Size = new System.Drawing.Size(143, 22);
            this.menuitemPluginUseBigIcons.Text = "Use Big Icons";
            this.menuitemPluginUseBigIcons.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuitemPluginShowText
            // 
            this.menuitemPluginShowText.Name = "menuitemPluginShowText";
            this.menuitemPluginShowText.Size = new System.Drawing.Size(143, 22);
            this.menuitemPluginShowText.Text = "Show Text";
            this.menuitemPluginShowText.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPluginToolStripMenuItem1,
            this.removePluginsToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::FuzzyByte.NokiaCooker.Properties.Resources.add_remove2;
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(75, 27);
            this.toolStripSplitButton1.Text = "Plugins:";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // addNewPluginToolStripMenuItem1
            // 
            this.addNewPluginToolStripMenuItem1.Name = "addNewPluginToolStripMenuItem1";
            this.addNewPluginToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.addNewPluginToolStripMenuItem1.Text = "Add New Plugins...";
            this.addNewPluginToolStripMenuItem1.Click += new System.EventHandler(this.addNewPluginToolStripMenuItem1_Click);
            // 
            // removePluginsToolStripMenuItem
            // 
            this.removePluginsToolStripMenuItem.Name = "removePluginsToolStripMenuItem";
            this.removePluginsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removePluginsToolStripMenuItem.Text = "Remove Plugins";
            this.removePluginsToolStripMenuItem.Click += new System.EventHandler(this.removePluginsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Executable files |*.exe";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.RestoreDirectory = true;
            this.openFileDialog2.Title = "Select Executable File";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Extr Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "FixCRC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.NotifyFilter = ((System.IO.NotifyFilters)(((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.Size)));
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // timerCompute
            // 
            this.timerCompute.Interval = 2000;
            this.timerCompute.Tick += new System.EventHandler(this.timerCompute_Tick);
            // 
            // bwComputeSize
            // 
            this.bwComputeSize.WorkerReportsProgress = true;
            this.bwComputeSize.WorkerSupportsCancellation = true;
            this.bwComputeSize.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwComputeSize_DoWork);
            this.bwComputeSize.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwComputeSize_ProgressChanged);
            this.bwComputeSize.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwComputeSize_RunWorkerCompleted);
            // 
            // bwFilesOperation
            // 
            this.bwFilesOperation.WorkerReportsProgress = true;
            this.bwFilesOperation.WorkerSupportsCancellation = true;
            this.bwFilesOperation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwFilesOperation_DoWork);
            this.bwFilesOperation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwFilesOperation_ProgressChanged);
            this.bwFilesOperation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwFilesOperation_RunWorkerCompleted);
            // 
            // updateSizeLabelTimer
            // 
            this.updateSizeLabelTimer.Interval = 300;
            this.updateSizeLabelTimer.Tick += new System.EventHandler(this.updateSizeLabelTimer_Tick);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "All files (*.*)|*.*";
            this.openFileDialog3.Multiselect = true;
            this.openFileDialog3.RestoreDirectory = true;
            this.openFileDialog3.Title = "Add Files";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "dmp";
            this.saveFileDialog1.FileName = "RomDumpPlus_Core.dmp";
            this.saveFileDialog1.Filter = "Rom Dump File (*.dmp)|*.dmp";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save ROM to File...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 341);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolPlugins);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(619, 292);
            this.Name = "Form1";
            this.Text = "NokiaCooker 3.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.contextTreeView.ResumeLayout(false);
            this.contextFileView.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.contextToolBar.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.toolPlugins.ResumeLayout(false);
            this.toolPlugins.PerformLayout();
            this.contextPlugin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nokiaCookerBETA01MarcoBellinoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwOpenFile;
        private System.ComponentModel.BackgroundWorker bwRepack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFATMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importROFSMenuItem;
        private System.Windows.Forms.OpenFileDialog openROFS;
        private System.Windows.Forms.TreeView treeViewAdv1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lblFolders;
        private System.Windows.Forms.ToolStripStatusLabel lblFiles;
        private System.Windows.Forms.ToolStripStatusLabel lblSize;
        private System.Windows.Forms.OpenFileDialog openFAT;
        private System.Windows.Forms.ToolStripMenuItem importUnknMenuItem;
        private System.Windows.Forms.OpenFileDialog openUnkn;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textAreaAdv1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolPlugins;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem removePluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPluginToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripStatusLabel lblPartSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel lblEstimatedSize;
        private System.Windows.Forms.Button button3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripButton btnUnlockRofs;
        private System.Windows.Forms.Timer timerCompute;
        private System.ComponentModel.BackgroundWorker bwComputeSize;
        private System.ComponentModel.BackgroundWorker bwFilesOperation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.Timer updateSizeLabelTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExplore;
        private System.Windows.Forms.ListView gridFiles1;
        private System.ComponentModel.BackgroundWorker bwDeleteTrashFolder;
        private System.Windows.Forms.ContextMenuStrip contextFileView;
        private System.Windows.Forms.ToolStripMenuItem removeFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextTreeView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton btnRofs1Increase;
        private System.Windows.Forms.ContextMenuStrip contextToolBar;
        private System.Windows.Forms.ToolStripMenuItem showLargeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextPlugin;
        private System.Windows.Forms.ToolStripMenuItem menuitemPluginUseBigIcons;
        private System.Windows.Forms.ToolStripMenuItem menuitemPluginShowText;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractRomMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton btnRepartition;
        private System.Windows.Forms.ToolStripMenuItem closeStripItem;
    }
}

