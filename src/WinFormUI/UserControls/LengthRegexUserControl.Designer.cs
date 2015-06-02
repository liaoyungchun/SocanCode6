namespace SocanCode.UserControls
{
    partial class LengthRegexUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenLength = new System.Windows.Forms.Button();
            this.txtMaxLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Controls.Add(this.btnGenLength, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaxLength, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMinLength, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnGenLength
            // 
            this.btnGenLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenLength.Location = new System.Drawing.Point(231, 3);
            this.btnGenLength.Name = "btnGenLength";
            this.btnGenLength.Size = new System.Drawing.Size(75, 24);
            this.btnGenLength.TabIndex = 9;
            this.btnGenLength.Text = "{1,15}";
            this.btnGenLength.UseVisualStyleBackColor = true;
            this.btnGenLength.Click += new System.EventHandler(this.btnGenLength_Click);
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaxLength.Location = new System.Drawing.Point(152, 3);
            this.txtMaxLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtMaxLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(73, 21);
            this.txtMaxLength.TabIndex = 14;
            this.txtMaxLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtMaxLength.ValueChanged += new System.EventHandler(this.txtMinLength_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "长度";
            // 
            // txtMinLength
            // 
            this.txtMinLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinLength.Location = new System.Drawing.Point(53, 3);
            this.txtMinLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.txtMinLength.Name = "txtMinLength";
            this.txtMinLength.Size = new System.Drawing.Size(73, 21);
            this.txtMinLength.TabIndex = 14;
            this.txtMinLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinLength.ValueChanged += new System.EventHandler(this.txtMinLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "~";
            // 
            // LengthRegexUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LengthRegexUserControl";
            this.Size = new System.Drawing.Size(309, 32);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGenLength;
        private System.Windows.Forms.NumericUpDown txtMaxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtMinLength;
        private System.Windows.Forms.Label label2;
    }
}
