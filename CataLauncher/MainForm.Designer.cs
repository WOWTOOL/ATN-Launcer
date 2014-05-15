namespace CataLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchDeinstallierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woWOrdnerSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startDownloadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.downloadProgressLabel = new System.Windows.Forms.Label();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.checkServerStatusBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.playButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadBar1 = new CataLauncher.DownloadBar();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.hilfeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(13, 29);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(190, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem1.Text = "Datei";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patchDeinstallierenToolStripMenuItem,
            this.woWOrdnerSuchenToolStripMenuItem,
            this.cacheLöschenToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Einstellungen";
            // 
            // patchDeinstallierenToolStripMenuItem
            // 
            this.patchDeinstallierenToolStripMenuItem.Name = "patchDeinstallierenToolStripMenuItem";
            this.patchDeinstallierenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.patchDeinstallierenToolStripMenuItem.Text = "Patch Deinstallieren";
            this.patchDeinstallierenToolStripMenuItem.Click += new System.EventHandler(this.askDeletePatch);
            // 
            // woWOrdnerSuchenToolStripMenuItem
            // 
            this.woWOrdnerSuchenToolStripMenuItem.Name = "woWOrdnerSuchenToolStripMenuItem";
            this.woWOrdnerSuchenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.woWOrdnerSuchenToolStripMenuItem.Text = "WoW Ordner suchen";
            this.woWOrdnerSuchenToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // cacheLöschenToolStripMenuItem
            // 
            this.cacheLöschenToolStripMenuItem.Name = "cacheLöschenToolStripMenuItem";
            this.cacheLöschenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cacheLöschenToolStripMenuItem.Text = "Cache löschen";
            this.cacheLöschenToolStripMenuItem.Click += new System.EventHandler(this.deleteCache_click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Schließen";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem1});
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // creditsToolStripMenuItem1
            // 
            this.creditsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.creditsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.creditsToolStripMenuItem1.Name = "creditsToolStripMenuItem1";
            this.creditsToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem1.Text = "Credits";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.creditsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 27);
            this.panel1.TabIndex = 7;
            // 
            // startDownloadBackgroundWorker
            // 
            this.startDownloadBackgroundWorker.WorkerReportsProgress = true;
            this.startDownloadBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.startDownloadBackgroundWorker_DoWork);
            // 
            // downloadProgressLabel
            // 
            this.downloadProgressLabel.AutoSize = true;
            this.downloadProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.downloadProgressLabel.ForeColor = System.Drawing.Color.White;
            this.downloadProgressLabel.Location = new System.Drawing.Point(216, 442);
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            this.downloadProgressLabel.Size = new System.Drawing.Size(115, 16);
            this.downloadProgressLabel.TabIndex = 9;
            this.downloadProgressLabel.Text = "Download Status: ";
            this.downloadProgressLabel.Visible = false;
            this.downloadProgressLabel.Click += new System.EventHandler(this.downloadProgressLabel_Click);
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.serverStatusLabel.ForeColor = System.Drawing.Color.White;
            this.serverStatusLabel.Location = new System.Drawing.Point(14, 440);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(101, 18);
            this.serverStatusLabel.TabIndex = 10;
            this.serverStatusLabel.Text = "Server Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(121, 440);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 18);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Offline";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // checkServerStatusBackgroundWorker
            // 
            this.checkServerStatusBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkServerStatusBackgroundWorker_DoWork);
            // 
            // playButtonPictureBox
            // 
            this.playButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButtonPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playButtonPictureBox.Image = global::CataLauncher.Properties.Resources.play;
            this.playButtonPictureBox.Location = new System.Drawing.Point(509, 457);
            this.playButtonPictureBox.Name = "playButtonPictureBox";
            this.playButtonPictureBox.Size = new System.Drawing.Size(225, 71);
            this.playButtonPictureBox.TabIndex = 5;
            this.playButtonPictureBox.TabStop = false;
            this.playButtonPictureBox.Click += new System.EventHandler(this.playButtonPictureBox_Click);
            this.playButtonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButtonPictureBox_MouseDown);
            this.playButtonPictureBox.MouseEnter += new System.EventHandler(this.playButtonPictureBox_MouseEnter);
            this.playButtonPictureBox.MouseLeave += new System.EventHandler(this.playButtonPictureBox_MouseLeave);
            this.playButtonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButtonPictureBox_MouseUp);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePictureBox.Image = global::CataLauncher.Properties.Resources.mini_nohover;
            this.MinimizePictureBox.Location = new System.Drawing.Point(714, 4);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(19, 19);
            this.MinimizePictureBox.TabIndex = 2;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            this.MinimizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseDown);
            this.MinimizePictureBox.MouseEnter += new System.EventHandler(this.MinimizePictureBox_MouseEnter);
            this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.MinimizePictureBox_MouseLeave);
            this.MinimizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseUp);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPictureBox.Image = global::CataLauncher.Properties.Resources.close;
            this.exitPictureBox.Location = new System.Drawing.Point(739, 4);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(19, 19);
            this.exitPictureBox.TabIndex = 1;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseDown);
            this.exitPictureBox.MouseEnter += new System.EventHandler(this.exitPictureBox_MouseEnter);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CataLauncher.Properties.Resources.atnborder;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(766, 562);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseAction);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseAction);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CataLauncher.Properties.Resources.lower_bar_bg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 442);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(737, 104);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Location = new System.Drawing.Point(20, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(714, 367);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.Url = new System.Uri("http://atom-network.eu/launcheratn", System.UriKind.Absolute);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.hilfeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Über";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem2_Click);
            // 
            // downloadBar1
            // 
            this.downloadBar1.AutoSize = true;
            this.downloadBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downloadBar1.BackgroundImage")));
            this.downloadBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloadBar1.BarState = CataLauncher.DownloadBar.DownloadBarState.Setup;
            this.downloadBar1.CausesValidation = false;
            this.downloadBar1.Location = new System.Drawing.Point(20, 486);
            this.downloadBar1.Name = "downloadBar1";
            this.downloadBar1.Size = new System.Drawing.Size(485, 42);
            this.downloadBar1.TabIndex = 19;
            this.downloadBar1.Value = 0D;
            this.downloadBar1.Load += new System.EventHandler(this.downloadBar1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::CataLauncher.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(761, 561);
            this.Controls.Add(this.downloadBar1);
            this.Controls.Add(this.playButtonPictureBox);
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.downloadProgressLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.MinimizePictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseAction);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseAction);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox playButtonPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker startDownloadBackgroundWorker;
        private System.Windows.Forms.Label downloadProgressLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem1;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.ComponentModel.BackgroundWorker checkServerStatusBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private DownloadBar downloadBar1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ToolStripMenuItem patchDeinstallierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem woWOrdnerSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}

