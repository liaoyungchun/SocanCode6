namespace SocanCode
{
    partial class ConnectionForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tcDatabase = new System.Windows.Forms.TabControl();
            this.tpAccess = new System.Windows.Forms.TabPage();
            this.accessConn1 = new DbConnections.AccessConn();
            this.tpSqlServer = new System.Windows.Forms.TabPage();
            this.sqlConn1 = new DbConnections.SqlConn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mySqlConn1 = new DbConnections.MySqlConn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.oracleConn1 = new DbConnections.OracleConn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sqLiteConn1 = new DbConnections.SQLiteConn();
            this.tcDatabase.SuspendLayout();
            this.tpAccess.SuspendLayout();
            this.tpSqlServer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(329, 372);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(407, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tcDatabase
            // 
            this.tcDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcDatabase.Controls.Add(this.tpAccess);
            this.tcDatabase.Controls.Add(this.tpSqlServer);
            this.tcDatabase.Controls.Add(this.tabPage1);
            this.tcDatabase.Controls.Add(this.tabPage2);
            this.tcDatabase.Controls.Add(this.tabPage3);
            this.tcDatabase.Location = new System.Drawing.Point(12, 12);
            this.tcDatabase.Name = "tcDatabase";
            this.tcDatabase.SelectedIndex = 0;
            this.tcDatabase.Size = new System.Drawing.Size(470, 347);
            this.tcDatabase.TabIndex = 0;
            // 
            // tpAccess
            // 
            this.tpAccess.Controls.Add(this.accessConn1);
            this.tpAccess.Location = new System.Drawing.Point(4, 22);
            this.tpAccess.Name = "tpAccess";
            this.tpAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccess.Size = new System.Drawing.Size(462, 321);
            this.tpAccess.TabIndex = 0;
            this.tpAccess.Text = "Access";
            this.tpAccess.UseVisualStyleBackColor = true;
            // 
            // accessConn1
            // 
            this.accessConn1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=;Persist Security Info=True;";
            this.accessConn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accessConn1.Location = new System.Drawing.Point(3, 3);
            this.accessConn1.Name = "accessConn1";
            this.accessConn1.Size = new System.Drawing.Size(456, 315);
            this.accessConn1.TabIndex = 0;
            // 
            // tpSqlServer
            // 
            this.tpSqlServer.Controls.Add(this.sqlConn1);
            this.tpSqlServer.Location = new System.Drawing.Point(4, 22);
            this.tpSqlServer.Name = "tpSqlServer";
            this.tpSqlServer.Padding = new System.Windows.Forms.Padding(3);
            this.tpSqlServer.Size = new System.Drawing.Size(462, 321);
            this.tpSqlServer.TabIndex = 1;
            this.tpSqlServer.Text = "SqlServer";
            this.tpSqlServer.UseVisualStyleBackColor = true;
            // 
            // sqlConn1
            // 
            this.sqlConn1.ConnectionString = "Data Source=.;User ID=sa;Password=;Initial Catalog=;";
            this.sqlConn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlConn1.IsSql2005 = false;
            this.sqlConn1.Location = new System.Drawing.Point(3, 3);
            this.sqlConn1.Name = "sqlConn1";
            this.sqlConn1.Size = new System.Drawing.Size(456, 316);
            this.sqlConn1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mySqlConn1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 321);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "MySql";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mySqlConn1
            // 
            this.mySqlConn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mySqlConn1.ConnectionString = "Data Source=127.0.0.1;Port=3306;User Id=root;Password=;Database=;";
            this.mySqlConn1.Location = new System.Drawing.Point(10, 13);
            this.mySqlConn1.Name = "mySqlConn1";
            this.mySqlConn1.Size = new System.Drawing.Size(442, 293);
            this.mySqlConn1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.oracleConn1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 321);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Oracle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // oracleConn1
            // 
            this.oracleConn1.ConnectionString = "Data Source=ORCL;Persist Security Info=True;User ID=SYSTEM;Password=;Unicode=True" +
    "";
            this.oracleConn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oracleConn1.Location = new System.Drawing.Point(3, 3);
            this.oracleConn1.Name = "oracleConn1";
            this.oracleConn1.Size = new System.Drawing.Size(456, 315);
            this.oracleConn1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::SocanCode.Properties.Resources.indicator_kit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sqLiteConn1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(462, 321);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "SQLite";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sqLiteConn1
            // 
            this.sqLiteConn1.ConnectionString = "Data Source=;";
            this.sqLiteConn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqLiteConn1.Location = new System.Drawing.Point(3, 3);
            this.sqLiteConn1.Name = "sqLiteConn1";
            this.sqLiteConn1.Size = new System.Drawing.Size(456, 315);
            this.sqLiteConn1.TabIndex = 0;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tcDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置连接";
            this.tcDatabase.ResumeLayout(false);
            this.tpAccess.ResumeLayout(false);
            this.tpSqlServer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tcDatabase;
        private System.Windows.Forms.TabPage tpAccess;
        private System.Windows.Forms.TabPage tpSqlServer;
        private DbConnections.AccessConn accessConn1;
        private DbConnections.SqlConn sqlConn1;
        private System.Windows.Forms.TabPage tabPage1;
        private DbConnections.MySqlConn mySqlConn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private DbConnections.OracleConn oracleConn1;
        private System.Windows.Forms.TabPage tabPage3;
        private DbConnections.SQLiteConn sqLiteConn1;
    }
}