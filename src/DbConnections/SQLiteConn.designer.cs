namespace DbConnections
{
    partial class SQLiteConn
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNullPassword = new System.Windows.Forms.CheckBox();
            this.txtPasswrod = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radString = new System.Windows.Forms.RadioButton();
            this.radTable = new System.Windows.Forms.RadioButton();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pnlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtString.Enabled = false;
            this.txtString.Location = new System.Drawing.Point(32, 165);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(435, 131);
            this.txtString.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(89, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(338, 21);
            this.txtPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库路径";
            // 
            // chkNullPassword
            // 
            this.chkNullPassword.AutoSize = true;
            this.chkNullPassword.Checked = true;
            this.chkNullPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNullPassword.Location = new System.Drawing.Point(222, 48);
            this.chkNullPassword.Name = "chkNullPassword";
            this.chkNullPassword.Size = new System.Drawing.Size(60, 16);
            this.chkNullPassword.TabIndex = 4;
            this.chkNullPassword.Text = "空密码";
            this.chkNullPassword.UseVisualStyleBackColor = true;
            this.chkNullPassword.CheckedChanged += new System.EventHandler(this.chkNullPassword_CheckedChanged);
            // 
            // txtPasswrod
            // 
            this.txtPasswrod.Enabled = false;
            this.txtPasswrod.Location = new System.Drawing.Point(89, 46);
            this.txtPasswrod.Name = "txtPasswrod";
            this.txtPasswrod.PasswordChar = '●';
            this.txtPasswrod.Size = new System.Drawing.Size(112, 21);
            this.txtPasswrod.TabIndex = 3;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPath.Location = new System.Drawing.Point(426, 12);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(26, 23);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码";
            // 
            // radString
            // 
            this.radString.AutoSize = true;
            this.radString.Location = new System.Drawing.Point(15, 136);
            this.radString.Name = "radString";
            this.radString.Size = new System.Drawing.Size(131, 16);
            this.radString.TabIndex = 1;
            this.radString.Text = "直接填写数据库连接";
            this.radString.UseVisualStyleBackColor = true;
            this.radString.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radTable
            // 
            this.radTable.AutoSize = true;
            this.radTable.Checked = true;
            this.radTable.Location = new System.Drawing.Point(15, 12);
            this.radTable.Name = "radTable";
            this.radTable.Size = new System.Drawing.Size(107, 16);
            this.radTable.TabIndex = 0;
            this.radTable.TabStop = true;
            this.radTable.Text = "填写数据库信息";
            this.radTable.UseVisualStyleBackColor = true;
            this.radTable.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.Controls.Add(this.txtPath);
            this.pnlTable.Controls.Add(this.label3);
            this.pnlTable.Controls.Add(this.label1);
            this.pnlTable.Controls.Add(this.chkNullPassword);
            this.pnlTable.Controls.Add(this.btnSelectPath);
            this.pnlTable.Controls.Add(this.txtPasswrod);
            this.pnlTable.Location = new System.Drawing.Point(15, 38);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(475, 83);
            this.pnlTable.TabIndex = 12;
            // 
            // SQLiteConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.radString);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.radTable);
            this.Name = "SQLiteConn";
            this.Size = new System.Drawing.Size(510, 316);
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNullPassword;
        private System.Windows.Forms.TextBox txtPasswrod;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radString;
        private System.Windows.Forms.RadioButton radTable;
        private System.Windows.Forms.Panel pnlTable;
    }
}
