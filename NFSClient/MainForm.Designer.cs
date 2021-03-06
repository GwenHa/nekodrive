namespace NFSClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblRemoteDevices = new System.Windows.Forms.Label();
            this.cboxRemoteDevices = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbTargetConnection = new System.Windows.Forms.GroupBox();
            this.chkUseSecurePort = new System.Windows.Forms.CheckBox();
            this.chkUseUnicode = new System.Windows.Forms.CheckBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.nupTimeOut = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.cboxVer = new System.Windows.Forms.ComboBox();
            this.ipAddressControl1 = new NFSClient.IPAddressControl();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewLocal = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbLocalPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewRemote = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbTargetConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeOut)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemoteDevices
            // 
            this.lblRemoteDevices.AutoSize = true;
            this.lblRemoteDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoteDevices.Location = new System.Drawing.Point(87, 14);
            this.lblRemoteDevices.Name = "lblRemoteDevices";
            this.lblRemoteDevices.Size = new System.Drawing.Size(100, 13);
            this.lblRemoteDevices.TabIndex = 0;
            this.lblRemoteDevices.Text = "Remote Devices";
            // 
            // cboxRemoteDevices
            // 
            this.cboxRemoteDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxRemoteDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRemoteDevices.FormattingEnabled = true;
            this.cboxRemoteDevices.Location = new System.Drawing.Point(189, 10);
            this.cboxRemoteDevices.Name = "cboxRemoteDevices";
            this.cboxRemoteDevices.Size = new System.Drawing.Size(298, 21);
            this.cboxRemoteDevices.TabIndex = 1;
            this.cboxRemoteDevices.SelectedIndexChanged += new System.EventHandler(this.cboxRemoteDevices_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(282, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbTargetConnection
            // 
            this.gbTargetConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTargetConnection.Controls.Add(this.chkUseSecurePort);
            this.gbTargetConnection.Controls.Add(this.chkUseUnicode);
            this.gbTargetConnection.Controls.Add(this.lblTimeOut);
            this.gbTargetConnection.Controls.Add(this.nupTimeOut);
            this.gbTargetConnection.Controls.Add(this.btnCancel);
            this.gbTargetConnection.Controls.Add(this.lblCurrentFile);
            this.gbTargetConnection.Controls.Add(this.pb);
            this.gbTargetConnection.Controls.Add(this.cboxVer);
            this.gbTargetConnection.Controls.Add(this.ipAddressControl1);
            this.gbTargetConnection.Controls.Add(this.btnConnect);
            this.gbTargetConnection.Location = new System.Drawing.Point(13, 13);
            this.gbTargetConnection.Name = "gbTargetConnection";
            this.gbTargetConnection.Size = new System.Drawing.Size(983, 54);
            this.gbTargetConnection.TabIndex = 4;
            this.gbTargetConnection.TabStop = false;
            this.gbTargetConnection.Text = "Target Connection";
            // 
            // chkUseSecurePort
            // 
            this.chkUseSecurePort.AutoSize = true;
            this.chkUseSecurePort.Checked = true;
            this.chkUseSecurePort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseSecurePort.Location = new System.Drawing.Point(458, 21);
            this.chkUseSecurePort.Name = "chkUseSecurePort";
            this.chkUseSecurePort.Size = new System.Drawing.Size(121, 17);
            this.chkUseSecurePort.TabIndex = 10;
            this.chkUseSecurePort.Text = "Use Privileged Ports";
            this.chkUseSecurePort.UseVisualStyleBackColor = true;
            // 
            // chkUseUnicode
            // 
            this.chkUseUnicode.AutoSize = true;
            this.chkUseUnicode.Location = new System.Drawing.Point(364, 21);
            this.chkUseUnicode.Name = "chkUseUnicode";
            this.chkUseUnicode.Size = new System.Drawing.Size(88, 17);
            this.chkUseUnicode.TabIndex = 10;
            this.chkUseUnicode.Text = "Use Unicode";
            this.chkUseUnicode.UseVisualStyleBackColor = true;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(177, 21);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(50, 13);
            this.lblTimeOut.TabIndex = 9;
            this.lblTimeOut.Text = "Time Out";
            // 
            // nupTimeOut
            // 
            this.nupTimeOut.Location = new System.Drawing.Point(233, 19);
            this.nupTimeOut.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nupTimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupTimeOut.Name = "nupTimeOut";
            this.nupTimeOut.Size = new System.Drawing.Size(43, 20);
            this.nupTimeOut.TabIndex = 8;
            this.nupTimeOut.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(726, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(782, 13);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentFile.TabIndex = 6;
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(782, 23);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(195, 16);
            this.pb.TabIndex = 5;
            // 
            // cboxVer
            // 
            this.cboxVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxVer.FormattingEnabled = true;
            this.cboxVer.Items.AddRange(new object[] {
            "V2",
            "V3"});
            this.cboxVer.Location = new System.Drawing.Point(124, 21);
            this.cboxVer.Name = "cboxVer";
            this.cboxVer.Size = new System.Drawing.Size(46, 21);
            this.cboxVer.TabIndex = 4;
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.Location = new System.Drawing.Point(6, 22);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(112, 20);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(112, 20);
            this.ipAddressControl1.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(13, 74);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(983, 551);
            this.pnlMain.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewLocal);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewRemote);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(954, 532);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.TabIndex = 6;
            // 
            // listViewLocal
            // 
            this.listViewLocal.AllowDrop = true;
            this.listViewLocal.AutoArrange = false;
            this.listViewLocal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLocal.FullRowSelect = true;
            this.listViewLocal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewLocal.LabelEdit = true;
            this.listViewLocal.Location = new System.Drawing.Point(0, 41);
            this.listViewLocal.Name = "listViewLocal";
            this.listViewLocal.ShowGroups = false;
            this.listViewLocal.Size = new System.Drawing.Size(454, 491);
            this.listViewLocal.SmallImageList = this.imageList1;
            this.listViewLocal.TabIndex = 1;
            this.listViewLocal.UseCompatibleStateImageBehavior = false;
            this.listViewLocal.View = System.Windows.Forms.View.Details;
            this.listViewLocal.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewLocal_AfterLabelEdit);
            this.listViewLocal.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewLocal_ItemDrag);
            this.listViewLocal.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewLocal_DragDrop);
            this.listViewLocal.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewLocal_DragEnter);
            this.listViewLocal.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewLocal_DragOver);
            this.listViewLocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewLocal_KeyDown);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 200;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "UnknownFile.ico");
            this.imageList1.Images.SetKeyName(1, "Folder.ico");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.tbLocalPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(385, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocalPath.Enabled = false;
            this.tbLocalPath.Location = new System.Drawing.Point(81, 10);
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.Size = new System.Drawing.Size(298, 20);
            this.tbLocalPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Path:";
            // 
            // listViewRemote
            // 
            this.listViewRemote.AllowDrop = true;
            this.listViewRemote.AutoArrange = false;
            this.listViewRemote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader5});
            this.listViewRemote.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRemote.FullRowSelect = true;
            this.listViewRemote.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRemote.LabelEdit = true;
            this.listViewRemote.Location = new System.Drawing.Point(0, 41);
            this.listViewRemote.Name = "listViewRemote";
            this.listViewRemote.Size = new System.Drawing.Size(496, 491);
            this.listViewRemote.SmallImageList = this.imageList1;
            this.listViewRemote.TabIndex = 2;
            this.listViewRemote.UseCompatibleStateImageBehavior = false;
            this.listViewRemote.View = System.Windows.Forms.View.Details;
            this.listViewRemote.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewRemote_AfterLabelEdit);
            this.listViewRemote.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewRemote_ItemDrag);
            this.listViewRemote.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewRemote_DragDrop);
            this.listViewRemote.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewRemote_DragEnter);
            this.listViewRemote.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewRemote_DragOver);
            this.listViewRemote.DoubleClick += new System.EventHandler(this.listViewRemote_DoubleClick);
            this.listViewRemote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewRemote_KeyDown);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Size";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CDate";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MDate";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADate";
            this.columnHeader5.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPermissionsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // showPermissionsToolStripMenuItem
            // 
            this.showPermissionsToolStripMenuItem.Name = "showPermissionsToolStripMenuItem";
            this.showPermissionsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showPermissionsToolStripMenuItem.Text = "Show Permissions";
            this.showPermissionsToolStripMenuItem.Click += new System.EventHandler(this.showPermissionsToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewFolder);
            this.panel2.Controls.Add(this.lblRemoteDevices);
            this.panel2.Controls.Add(this.cboxRemoteDevices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 41);
            this.panel2.TabIndex = 0;
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(10, 10);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(71, 23);
            this.btnNewFolder.TabIndex = 2;
            this.btnNewFolder.Text = "New Folder";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 648);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.gbTargetConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(884, 686);
            this.Name = "MainForm";
            this.Text = "Windows NFS Client - NekoDrive Test Component - mirko.gatto@gmail.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbTargetConnection.ResumeLayout(false);
            this.gbTargetConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeOut)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRemoteDevices;
        private System.Windows.Forms.ComboBox cboxRemoteDevices;
        private IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbTargetConnection;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewLocal;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbLocalPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewRemote;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cboxVer;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.NumericUpDown nupTimeOut;
        private System.Windows.Forms.CheckBox chkUseUnicode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPermissionsToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkUseSecurePort;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timer1;
    }
}

