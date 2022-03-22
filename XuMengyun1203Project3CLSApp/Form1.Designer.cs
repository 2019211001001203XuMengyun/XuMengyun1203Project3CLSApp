namespace XuMengyun1203Project3CLSApp
{
    partial class FrmCreative
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreative));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.opsGenerateLog = new System.Windows.Forms.CheckBox();
            this.txtProcessedFile = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDest = new System.Windows.Forms.TabPage();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupEventLog = new System.Windows.Forms.GroupBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.watchDir = new System.IO.FileSystemWatcher();
            this.mnuNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configureApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabDest.SuspendLayout();
            this.groupEventLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDir)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Controls.Add(this.tabDest);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(106, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.opsGenerateLog);
            this.tabSource.Controls.Add(this.txtProcessedFile);
            this.tabSource.Controls.Add(this.txtSource);
            this.tabSource.Controls.Add(this.label3);
            this.tabSource.Controls.Add(this.label2);
            this.tabSource.Controls.Add(this.label1);
            this.tabSource.ImageIndex = 0;
            this.tabSource.Location = new System.Drawing.Point(4, 25);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(545, 269);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source options";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // opsGenerateLog
            // 
            this.opsGenerateLog.AutoSize = true;
            this.opsGenerateLog.Location = new System.Drawing.Point(68, 203);
            this.opsGenerateLog.Name = "opsGenerateLog";
            this.opsGenerateLog.Size = new System.Drawing.Size(333, 19);
            this.opsGenerateLog.TabIndex = 5;
            this.opsGenerateLog.Text = "Generate Event Log for Bad File Format";
            this.opsGenerateLog.UseVisualStyleBackColor = true;
            // 
            // txtProcessedFile
            // 
            this.txtProcessedFile.Location = new System.Drawing.Point(127, 114);
            this.txtProcessedFile.Name = "txtProcessedFile";
            this.txtProcessedFile.Size = new System.Drawing.Size(364, 25);
            this.txtProcessedFile.TabIndex = 4;
            this.txtProcessedFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProcessedFile_KeyUp);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(219, 23);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(272, 25);
            this.txtSource.TabIndex = 3;
            this.txtSource.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSource_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "After Processing.Move Source file to";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabDest
            // 
            this.tabDest.Controls.Add(this.btnViewSummary);
            this.tabDest.Controls.Add(this.btnRefresh);
            this.tabDest.Controls.Add(this.groupEventLog);
            this.tabDest.Controls.Add(this.txtDest);
            this.tabDest.Controls.Add(this.label4);
            this.tabDest.ImageIndex = 1;
            this.tabDest.Location = new System.Drawing.Point(4, 25);
            this.tabDest.Name = "tabDest";
            this.tabDest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDest.Size = new System.Drawing.Size(545, 269);
            this.tabDest.TabIndex = 1;
            this.tabDest.Text = "Destination Options";
            this.tabDest.UseVisualStyleBackColor = true;
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(288, 240);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(124, 23);
            this.btnViewSummary.TabIndex = 4;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(112, 240);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Log";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupEventLog
            // 
            this.groupEventLog.Controls.Add(this.lstEvents);
            this.groupEventLog.Location = new System.Drawing.Point(112, 81);
            this.groupEventLog.Name = "groupEventLog";
            this.groupEventLog.Size = new System.Drawing.Size(292, 143);
            this.groupEventLog.TabIndex = 3;
            this.groupEventLog.TabStop = false;
            this.groupEventLog.Text = "Event Log";
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 15;
            this.lstEvents.Location = new System.Drawing.Point(32, 34);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(198, 94);
            this.lstEvents.TabIndex = 2;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(329, 40);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(184, 25);
            this.txtDest.TabIndex = 1;
            this.txtDest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDest_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Destination Directory";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "QQ图片20220317114952.jpg");
            this.imageList1.Images.SetKeyName(1, "QQ图片20220317115009.jpg");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(191, 388);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(422, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // watchDir
            // 
            this.watchDir.EnableRaisingEvents = true;
            this.watchDir.Filter = "*.doc";
            this.watchDir.SynchronizingObject = this;
            // 
            // mnuNotify
            // 
            this.mnuNotify.Text = "notifyIcon1";
            this.mnuNotify.Visible = true;
            this.mnuNotify.DoubleClick += new System.EventHandler(this.mnuNotify_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureApplicationToolStripMenuItem,
            this.mnuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 52);
            // 
            // configureApplicationToolStripMenuItem
            // 
            this.configureApplicationToolStripMenuItem.Name = "configureApplicationToolStripMenuItem";
            this.configureApplicationToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.configureApplicationToolStripMenuItem.Text = "Configure Application";
            this.configureApplicationToolStripMenuItem.Click += new System.EventHandler(this.configureApplicationToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(238, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FrmCreative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCreative";
            this.Text = "Creative Learning System";
            this.Load += new System.EventHandler(this.FrmCreative_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabDest.ResumeLayout(false);
            this.tabDest.PerformLayout();
            this.groupEventLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDir)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabDest;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox opsGenerateLog;
        private System.Windows.Forms.TextBox txtProcessedFile;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupEventLog;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.IO.FileSystemWatcher watchDir;
        private System.Windows.Forms.NotifyIcon mnuNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configureApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}

