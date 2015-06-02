namespace DbConnections
{
    partial class SqlConn
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cobDatabase = new System.Windows.Forms.ComboBox();
            this.cobValidation = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radString = new System.Windows.Forms.RadioButton();
            this.radTable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cobVersion = new System.Windows.Forms.ComboBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pnlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // cobDatabase
            // 
            this.cobDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cobDatabase.FormattingEnabled = true;
            this.cobDatabase.Location = new System.Drawing.Point(95, 114);
            this.cobDatabase.Name = "cobDatabase";
            this.cobDatabase.Size = new System.Drawing.Size(214, 20);
            this.cobDatabase.TabIndex = 4;
            this.cobDatabase.DropDown += new System.EventHandler(this.cobDatabase_DropDown);
            // 
            // cobValidation
            // 
            this.cobValidation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cobValidation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobValidation.FormattingEnabled = true;
            this.cobValidation.Items.AddRange(new object[] {
            "Windows身份验证",
            "Sql身份验证"});
            this.cobValidation.Location = new System.Drawing.Point(95, 37);
            this.cobValidation.Name = "cobValidation";
            this.cobValidation.Size = new System.Drawing.Size(215, 20);
            this.cobValidation.TabIndex = 1;
            this.cobValidation.SelectedIndexChanged += new System.EventHandler(this.cobValidation_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(95, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(215, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(95, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(215, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "sa";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(95, 11);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(215, 21);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "127.0.0.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "数据库";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "用户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "身份验证";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "服务器(,端口)";
            // 
            // radString
            // 
            this.radString.AutoSize = true;
            this.radString.Location = new System.Drawing.Point(5, 221);
            this.radString.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.radString.Name = "radString";
            this.radString.Size = new System.Drawing.Size(131, 16);
            this.radString.TabIndex = 3;
            this.radString.Text = "直接填写数据库连接";
            this.radString.UseVisualStyleBackColor = true;
            this.radString.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radTable
            // 
            this.radTable.AutoSize = true;
            this.radTable.Checked = true;
            this.radTable.Location = new System.Drawing.Point(4, 39);
            this.radTable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.radTable.Name = "radTable";
            this.radTable.Size = new System.Drawing.Size(107, 16);
            this.radTable.TabIndex = 1;
            this.radTable.TabStop = true;
            this.radTable.Text = "填写数据库信息";
            this.radTable.UseVisualStyleBackColor = true;
            this.radTable.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库版本";
            // 
            // cobVersion
            // 
            this.cobVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cobVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobVersion.FormattingEnabled = true;
            this.cobVersion.Items.AddRange(new object[] {
            "Sql2000",
            "Sql2005或更高版本"});
            this.cobVersion.Location = new System.Drawing.Point(113, 10);
            this.cobVersion.Name = "cobVersion";
            this.cobVersion.Size = new System.Drawing.Size(214, 20);
            this.cobVersion.TabIndex = 1;
            // 
            // txtString
            // 
            this.txtString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtString.Enabled = false;
            this.txtString.Location = new System.Drawing.Point(37, 247);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(290, 56);
            this.txtString.TabIndex = 4;
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.Controls.Add(this.label7);
            this.pnlTable.Controls.Add(this.txtServer);
            this.pnlTable.Controls.Add(this.label4);
            this.pnlTable.Controls.Add(this.txtUserName);
            this.pnlTable.Controls.Add(this.label8);
            this.pnlTable.Controls.Add(this.label5);
            this.pnlTable.Controls.Add(this.label6);
            this.pnlTable.Controls.Add(this.cobValidation);
            this.pnlTable.Controls.Add(this.cobDatabase);
            this.pnlTable.Controls.Add(this.txtPassword);
            this.pnlTable.Location = new System.Drawing.Point(18, 64);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(343, 144);
            this.pnlTable.TabIndex = 2;
            // 
            // SqlConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.radString);
            this.Controls.Add(this.cobVersion);
            this.Controls.Add(this.radTable);
            this.Controls.Add(this.label1);
            this.Name = "SqlConn";
            this.Size = new System.Drawing.Size(364, 317);
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobValidation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radString;
        private System.Windows.Forms.RadioButton radTable;
        private System.Windows.Forms.ComboBox cobVersion;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Panel pnlTable;
    }
}
