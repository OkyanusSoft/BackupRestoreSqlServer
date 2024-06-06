namespace BackupRestoreSqlServer
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.cmbBackupMode = new System.Windows.Forms.ComboBox();
            this.btnBackupDb = new System.Windows.Forms.Button();
            this.btnFileToBack = new System.Windows.Forms.Button();
            this.txtFileToBack = new System.Windows.Forms.TextBox();
            this.cmbBackupDb = new System.Windows.Forms.ComboBox();
            this.lblBackupMode = new System.Windows.Forms.Label();
            this.lblFileToBack = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.txtBackupSql = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.chckReplace = new System.Windows.Forms.CheckBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnFileToRestore = new System.Windows.Forms.Button();
            this.cmbRestoreDb = new System.Windows.Forms.ComboBox();
            this.txtFileToRestore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openBakFile = new System.Windows.Forms.OpenFileDialog();
            this.saveBakFile = new System.Windows.Forms.SaveFileDialog();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpBackup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.pictureBox1);
            this.grpBackup.Controls.Add(this.cmbBackupMode);
            this.grpBackup.Controls.Add(this.btnBackupDb);
            this.grpBackup.Controls.Add(this.btnFileToBack);
            this.grpBackup.Controls.Add(this.txtFileToBack);
            this.grpBackup.Controls.Add(this.cmbBackupDb);
            this.grpBackup.Controls.Add(this.lblBackupMode);
            this.grpBackup.Controls.Add(this.lblFileToBack);
            this.grpBackup.Controls.Add(this.lblDb);
            this.grpBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBackup.Location = new System.Drawing.Point(3, 3);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(419, 164);
            this.grpBackup.TabIndex = 0;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Backup";
            // 
            // cmbBackupMode
            // 
            this.cmbBackupMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupMode.Enabled = false;
            this.cmbBackupMode.FormattingEnabled = true;
            this.cmbBackupMode.Items.AddRange(new object[] {
            "Overwrite",
            "Append"});
            this.cmbBackupMode.Location = new System.Drawing.Point(156, 74);
            this.cmbBackupMode.Name = "cmbBackupMode";
            this.cmbBackupMode.Size = new System.Drawing.Size(125, 21);
            this.cmbBackupMode.TabIndex = 5;
            // 
            // btnBackupDb
            // 
            this.btnBackupDb.Location = new System.Drawing.Point(156, 101);
            this.btnBackupDb.Name = "btnBackupDb";
            this.btnBackupDb.Size = new System.Drawing.Size(67, 23);
            this.btnBackupDb.TabIndex = 3;
            this.btnBackupDb.Text = "Backup";
            this.btnBackupDb.UseVisualStyleBackColor = true;
            this.btnBackupDb.Click += new System.EventHandler(this.btnBackupDb_Click);
            // 
            // btnFileToBack
            // 
            this.btnFileToBack.Location = new System.Drawing.Point(346, 45);
            this.btnFileToBack.Name = "btnFileToBack";
            this.btnFileToBack.Size = new System.Drawing.Size(67, 23);
            this.btnFileToBack.TabIndex = 3;
            this.btnFileToBack.Text = "Browse...";
            this.btnFileToBack.UseVisualStyleBackColor = true;
            this.btnFileToBack.Click += new System.EventHandler(this.btnFileToBack_Click);
            // 
            // txtFileToBack
            // 
            this.txtFileToBack.Location = new System.Drawing.Point(156, 47);
            this.txtFileToBack.Name = "txtFileToBack";
            this.txtFileToBack.ReadOnly = true;
            this.txtFileToBack.Size = new System.Drawing.Size(184, 21);
            this.txtFileToBack.TabIndex = 2;
            // 
            // cmbBackupDb
            // 
            this.cmbBackupDb.DisplayMember = "Name";
            this.cmbBackupDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupDb.FormattingEnabled = true;
            this.cmbBackupDb.Location = new System.Drawing.Point(156, 20);
            this.cmbBackupDb.Name = "cmbBackupDb";
            this.cmbBackupDb.Size = new System.Drawing.Size(184, 21);
            this.cmbBackupDb.TabIndex = 1;
            this.cmbBackupDb.ValueMember = "ID";
            // 
            // lblBackupMode
            // 
            this.lblBackupMode.AutoSize = true;
            this.lblBackupMode.Location = new System.Drawing.Point(76, 77);
            this.lblBackupMode.Name = "lblBackupMode";
            this.lblBackupMode.Size = new System.Drawing.Size(74, 13);
            this.lblBackupMode.TabIndex = 0;
            this.lblBackupMode.Text = "Backup mode:";
            // 
            // lblFileToBack
            // 
            this.lblFileToBack.AutoSize = true;
            this.lblFileToBack.Location = new System.Drawing.Point(61, 50);
            this.lblFileToBack.Name = "lblFileToBack";
            this.lblFileToBack.Size = new System.Drawing.Size(89, 13);
            this.lblFileToBack.TabIndex = 0;
            this.lblFileToBack.Text = "Path to save file:";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(95, 23);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(55, 13);
            this.lblDb.TabIndex = 0;
            this.lblDb.Text = "Select db:";
            // 
            // txtBackupSql
            // 
            this.txtBackupSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackupSql.Location = new System.Drawing.Point(3, 17);
            this.txtBackupSql.Multiline = true;
            this.txtBackupSql.Name = "txtBackupSql";
            this.txtBackupSql.ReadOnly = true;
            this.txtBackupSql.Size = new System.Drawing.Size(844, 106);
            this.txtBackupSql.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grpBackup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpRestore, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 170);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.pictureBox2);
            this.grpRestore.Controls.Add(this.chckReplace);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.btnFileToRestore);
            this.grpRestore.Controls.Add(this.cmbRestoreDb);
            this.grpRestore.Controls.Add(this.txtFileToRestore);
            this.grpRestore.Controls.Add(this.label1);
            this.grpRestore.Controls.Add(this.label2);
            this.grpRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRestore.Location = new System.Drawing.Point(428, 3);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(419, 164);
            this.grpRestore.TabIndex = 1;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Restore";
            // 
            // chckReplace
            // 
            this.chckReplace.AutoSize = true;
            this.chckReplace.Checked = true;
            this.chckReplace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckReplace.Enabled = false;
            this.chckReplace.Location = new System.Drawing.Point(173, 74);
            this.chckReplace.Name = "chckReplace";
            this.chckReplace.Size = new System.Drawing.Size(64, 17);
            this.chckReplace.TabIndex = 5;
            this.chckReplace.Text = "Replace";
            this.chckReplace.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(170, 97);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(67, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnFileToRestore
            // 
            this.btnFileToRestore.Location = new System.Drawing.Point(346, 45);
            this.btnFileToRestore.Name = "btnFileToRestore";
            this.btnFileToRestore.Size = new System.Drawing.Size(67, 23);
            this.btnFileToRestore.TabIndex = 3;
            this.btnFileToRestore.Text = "Browse...";
            this.btnFileToRestore.UseVisualStyleBackColor = true;
            this.btnFileToRestore.Click += new System.EventHandler(this.btnFileToRestore_Click);
            // 
            // cmbRestoreDb
            // 
            this.cmbRestoreDb.DisplayMember = "Name";
            this.cmbRestoreDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestoreDb.FormattingEnabled = true;
            this.cmbRestoreDb.Location = new System.Drawing.Point(173, 20);
            this.cmbRestoreDb.Name = "cmbRestoreDb";
            this.cmbRestoreDb.Size = new System.Drawing.Size(167, 21);
            this.cmbRestoreDb.TabIndex = 1;
            this.cmbRestoreDb.ValueMember = "ID";
            // 
            // txtFileToRestore
            // 
            this.txtFileToRestore.Location = new System.Drawing.Point(173, 47);
            this.txtFileToRestore.Name = "txtFileToRestore";
            this.txtFileToRestore.ReadOnly = true;
            this.txtFileToRestore.Size = new System.Drawing.Size(167, 21);
            this.txtFileToRestore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select db:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select backup file:";
            // 
            // openBakFile
            // 
            this.openBakFile.Filter = "Backup Files (*.bak, *.trn)|*.bak;*.trn|All files (*)|*.*";
            this.openBakFile.Title = "Select Backup File";
            this.openBakFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openBakFile_FileOk);
            // 
            // saveBakFile
            // 
            this.saveBakFile.Filter = "Backup Files (*.bak, *.trn)|*.bak;*.trn|All files (*)|*.*";
            this.saveBakFile.Title = "Select file for saving backup";
            this.saveBakFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveBakFile_FileOk);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.txtBackupSql);
            this.grpStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStatus.Location = new System.Drawing.Point(0, 170);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(850, 126);
            this.grpStatus.TabIndex = 2;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Sql script";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.progBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progBar
            // 
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(250, 16);
            this.progBar.Visible = false;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(49, 20);
            this.toolStripSplitButton1.Text = "Menu";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BackupRestoreSqlServer.Properties.Resources.database_down;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BackupRestoreSqlServer.Properties.Resources.database_up;
            this.pictureBox2.Location = new System.Drawing.Point(6, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 323);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "SqlServer Backup/Restore Utility";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.ComboBox cmbBackupDb;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.OpenFileDialog openBakFile;
        private System.Windows.Forms.TextBox txtFileToBack;
        private System.Windows.Forms.Label lblFileToBack;
        private System.Windows.Forms.Button btnFileToBack;
        private System.Windows.Forms.SaveFileDialog saveBakFile;
        private System.Windows.Forms.Button btnFileToRestore;
        private System.Windows.Forms.ComboBox cmbRestoreDb;
        private System.Windows.Forms.TextBox txtFileToRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackupDb;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ComboBox cmbBackupMode;
        private System.Windows.Forms.TextBox txtBackupSql;
        private System.Windows.Forms.Label lblBackupMode;
        private System.Windows.Forms.CheckBox chckReplace;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}