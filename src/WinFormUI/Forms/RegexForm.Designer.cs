namespace SocanCode
{
    partial class RegexForm
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
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.labTestResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button19 = new System.Windows.Forms.Button();
            this.labRegexTester = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.lengthRegexUserControl1 = new SocanCode.UserControls.LengthRegexUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegex
            // 
            this.txtRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegex.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegex.Location = new System.Drawing.Point(53, 203);
            this.txtRegex.Multiline = true;
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegex.Size = new System.Drawing.Size(721, 82);
            this.txtRegex.TabIndex = 0;
            this.txtRegex.TextChanged += new System.EventHandler(this.txtRegex_TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Location = new System.Drawing.Point(780, 203);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(44, 82);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 30, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "正则";
            // 
            // txtTest
            // 
            this.txtTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTest.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtTest.Location = new System.Drawing.Point(53, 291);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTest.Size = new System.Drawing.Size(721, 82);
            this.txtTest.TabIndex = 0;
            this.txtTest.TextChanged += new System.EventHandler(this.txtRegex_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 30, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "测试";
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTest.Location = new System.Drawing.Point(780, 291);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(44, 82);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // labTestResult
            // 
            this.labTestResult.AutoSize = true;
            this.labTestResult.BackColor = System.Drawing.Color.Red;
            this.labTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTestResult.ForeColor = System.Drawing.Color.White;
            this.labTestResult.Location = new System.Drawing.Point(50, 376);
            this.labTestResult.Margin = new System.Windows.Forms.Padding(0);
            this.labTestResult.Name = "labTestResult";
            this.labTestResult.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.labTestResult.Size = new System.Drawing.Size(727, 31);
            this.labTestResult.TabIndex = 5;
            this.labTestResult.Text = "结果";
            this.labTestResult.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTest, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button19, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTest, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labRegexTester, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labTestResult, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 407);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Location = new System.Drawing.Point(780, 33);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(44, 164);
            this.button19.TabIndex = 13;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // labRegexTester
            // 
            this.labRegexTester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labRegexTester.AutoSize = true;
            this.labRegexTester.Location = new System.Drawing.Point(523, 11);
            this.labRegexTester.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.labRegexTester.Name = "labRegexTester";
            this.labRegexTester.Size = new System.Drawing.Size(251, 12);
            this.labRegexTester.TabIndex = 8;
            this.labRegexTester.TabStop = true;
            this.labRegexTester.Text = "点击这里下载强大的正则测试工具RegexTester";
            this.labRegexTester.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labRegexTester_LinkClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button14, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.button13, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.button15, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.button18, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button17, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button11, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button12, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button10, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button16, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lengthRegexUserControl1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button20, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.button21, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.button22, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button23, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button24, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(721, 164);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Location = new System.Drawing.Point(579, 67);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(139, 26);
            this.button14.TabIndex = 13;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(579, 35);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(139, 26);
            this.button13.TabIndex = 13;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(579, 99);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(139, 26);
            this.button15.TabIndex = 13;
            this.button15.Text = "?";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Location = new System.Drawing.Point(147, 99);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(138, 26);
            this.button18.TabIndex = 12;
            this.button18.Text = "$";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Location = new System.Drawing.Point(3, 99);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(138, 26);
            this.button17.TabIndex = 12;
            this.button17.Text = "^";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "(...)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ContainButton_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 26);
            this.button4.TabIndex = 12;
            this.button4.Text = "[...]";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ContainButton_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(3, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 26);
            this.button6.TabIndex = 12;
            this.button6.Text = "{...}";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ContainButton_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(147, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "( )";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(147, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 26);
            this.button3.TabIndex = 12;
            this.button3.Text = "[ ]";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(147, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 26);
            this.button5.TabIndex = 12;
            this.button5.Text = "{ }";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(291, 99);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(138, 26);
            this.button11.TabIndex = 13;
            this.button11.Text = "\\w";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(435, 99);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(138, 26);
            this.button12.TabIndex = 13;
            this.button12.Text = "\\W";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(435, 67);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(138, 26);
            this.button10.TabIndex = 13;
            this.button10.Text = "A-Z";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(291, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 26);
            this.button9.TabIndex = 13;
            this.button9.Text = "a-z";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(291, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 26);
            this.button7.TabIndex = 13;
            this.button7.Text = "0-9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(435, 35);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 26);
            this.button8.TabIndex = 13;
            this.button8.Text = "\\d";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(291, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(138, 26);
            this.button16.TabIndex = 13;
            this.button16.Text = "\\u4e00-\\u9fa5";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Location = new System.Drawing.Point(579, 131);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(139, 30);
            this.button20.TabIndex = 13;
            this.button20.Text = "_";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Location = new System.Drawing.Point(435, 131);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(138, 30);
            this.button21.TabIndex = 13;
            this.button21.Text = "\\s";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.Location = new System.Drawing.Point(291, 131);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(138, 30);
            this.button22.TabIndex = 13;
            this.button22.Text = "\\t";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.Location = new System.Drawing.Point(147, 131);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(138, 30);
            this.button23.TabIndex = 13;
            this.button23.Text = "\\n";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.Location = new System.Drawing.Point(3, 131);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(138, 30);
            this.button24.TabIndex = 13;
            this.button24.Text = "\\b";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // lengthRegexUserControl1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lengthRegexUserControl1, 2);
            this.lengthRegexUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengthRegexUserControl1.Location = new System.Drawing.Point(435, 3);
            this.lengthRegexUserControl1.Name = "lengthRegexUserControl1";
            this.lengthRegexUserControl1.Size = new System.Drawing.Size(283, 26);
            this.lengthRegexUserControl1.TabIndex = 14;
            this.lengthRegexUserControl1.ButtonClick += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // RegexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "RegexForm";
            this.Text = "简单正则生成工具";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Label labTestResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel labRegexTester;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button16;
        private UserControls.LengthRegexUserControl lengthRegexUserControl1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}