namespace RAMCorruptor
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
            if (disposing && (components != null)) {
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
            this.selectBtn = new System.Windows.Forms.Button();
            this.procName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rangeSizeRadix = new System.Windows.Forms.LinkLabel();
            this.rangeSize = new System.Windows.Forms.NumericUpDown();
            this.shiftAmount = new RAMCorruptor.UserControls.HexTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.byteCount = new System.Windows.Forms.NumericUpDown();
            this.shiftRight = new System.Windows.Forms.Button();
            this.shiftLeft = new System.Windows.Forms.Button();
            this.useRangeSize = new System.Windows.Forms.CheckBox();
            this.refine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeMax = new RAMCorruptor.UserControls.HexTextBox();
            this.rangeMin = new RAMCorruptor.UserControls.HexTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seedBox = new System.Windows.Forms.NumericUpDown();
            this.useSeed = new System.Windows.Forms.CheckBox();
            this.corruptBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bctOr = new System.Windows.Forms.RadioButton();
            this.bctAnd = new System.Windows.Forms.RadioButton();
            this.bctXor = new System.Windows.Forms.RadioButton();
            this.bctAdd = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bctArithmeticParam = new System.Windows.Forms.NumericUpDown();
            this.bctRandomMax = new System.Windows.Forms.NumericUpDown();
            this.bctRandomMin = new System.Windows.Forms.NumericUpDown();
            this.bctRandom = new System.Windows.Forms.RadioButton();
            this.copySeedBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byteCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bctArithmeticParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bctRandomMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bctRandomMin)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(12, 12);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(103, 23);
            this.selectBtn.TabIndex = 0;
            this.selectBtn.Text = "&Select Process...";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // procName
            // 
            this.procName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.procName.ForeColor = System.Drawing.Color.Red;
            this.procName.Location = new System.Drawing.Point(121, 13);
            this.procName.Name = "procName";
            this.procName.Size = new System.Drawing.Size(260, 21);
            this.procName.TabIndex = 1;
            this.procName.Text = "No process selected!";
            this.procName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rangeSizeRadix);
            this.groupBox1.Controls.Add(this.rangeSize);
            this.groupBox1.Controls.Add(this.shiftAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.interval);
            this.groupBox1.Controls.Add(this.byteCount);
            this.groupBox1.Controls.Add(this.shiftRight);
            this.groupBox1.Controls.Add(this.shiftLeft);
            this.groupBox1.Controls.Add(this.useRangeSize);
            this.groupBox1.Controls.Add(this.refine);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rangeMax);
            this.groupBox1.Controls.Add(this.rangeMin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Byte selection parameters";
            // 
            // rangeSizeRadix
            // 
            this.rangeSizeRadix.AutoSize = true;
            this.rangeSizeRadix.Location = new System.Drawing.Point(100, 47);
            this.rangeSizeRadix.Name = "rangeSizeRadix";
            this.rangeSizeRadix.Size = new System.Drawing.Size(18, 13);
            this.rangeSizeRadix.TabIndex = 17;
            this.rangeSizeRadix.TabStop = true;
            this.rangeSizeRadix.Text = "0x";
            this.rangeSizeRadix.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rangeSizeRadix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rangeSizeRadix_LinkClicked);
            // 
            // rangeSize
            // 
            this.rangeSize.Enabled = false;
            this.rangeSize.Hexadecimal = true;
            this.rangeSize.Location = new System.Drawing.Point(119, 45);
            this.rangeSize.Name = "rangeSize";
            this.rangeSize.Size = new System.Drawing.Size(66, 20);
            this.rangeSize.TabIndex = 16;
            this.rangeSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rangeSize.ValueChanged += new System.EventHandler(this.rangeSize_ValueChanged);
            // 
            // shiftAmount
            // 
            this.shiftAmount.BackColor = System.Drawing.SystemColors.Window;
            this.shiftAmount.FallbackValue = ((long)(4096));
            this.shiftAmount.Location = new System.Drawing.Point(299, 45);
            this.shiftAmount.Name = "shiftAmount";
            this.shiftAmount.Size = new System.Drawing.Size(58, 20);
            this.shiftAmount.TabIndex = 10;
            this.shiftAmount.Text = "1000";
            this.shiftAmount.Value = ((long)(4096));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "<- Shift by:";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(178, 72);
            this.interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(50, 20);
            this.interval.TabIndex = 14;
            this.interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // byteCount
            // 
            this.byteCount.Location = new System.Drawing.Point(53, 72);
            this.byteCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.byteCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.byteCount.Name = "byteCount";
            this.byteCount.Size = new System.Drawing.Size(50, 20);
            this.byteCount.TabIndex = 12;
            this.byteCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // shiftRight
            // 
            this.shiftRight.Location = new System.Drawing.Point(211, 43);
            this.shiftRight.Name = "shiftRight";
            this.shiftRight.Size = new System.Drawing.Size(20, 23);
            this.shiftRight.TabIndex = 8;
            this.shiftRight.Text = ">";
            this.shiftRight.UseVisualStyleBackColor = true;
            this.shiftRight.Click += new System.EventHandler(this.shiftRight_Click);
            // 
            // shiftLeft
            // 
            this.shiftLeft.Location = new System.Drawing.Point(191, 43);
            this.shiftLeft.Name = "shiftLeft";
            this.shiftLeft.Size = new System.Drawing.Size(20, 23);
            this.shiftLeft.TabIndex = 7;
            this.shiftLeft.Text = "<";
            this.shiftLeft.UseVisualStyleBackColor = true;
            this.shiftLeft.Click += new System.EventHandler(this.shiftLeft_Click);
            // 
            // useRangeSize
            // 
            this.useRangeSize.AutoSize = true;
            this.useRangeSize.Location = new System.Drawing.Point(9, 47);
            this.useRangeSize.Name = "useRangeSize";
            this.useRangeSize.Size = new System.Drawing.Size(94, 17);
            this.useRangeSize.TabIndex = 5;
            this.useRangeSize.Text = "Use &fixed size:";
            this.useRangeSize.UseVisualStyleBackColor = true;
            this.useRangeSize.CheckedChanged += new System.EventHandler(this.useRangeSize_CheckedChanged);
            // 
            // refine
            // 
            this.refine.Enabled = false;
            this.refine.Location = new System.Drawing.Point(266, 17);
            this.refine.Name = "refine";
            this.refine.Size = new System.Drawing.Size(92, 23);
            this.refine.TabIndex = 4;
            this.refine.Text = "Auto-&refine";
            this.refine.UseVisualStyleBackColor = true;
            this.refine.Click += new System.EventHandler(this.refine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "byte(s) every";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Corrupt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // rangeMax
            // 
            this.rangeMax.BackColor = System.Drawing.SystemColors.Window;
            this.rangeMax.Location = new System.Drawing.Point(191, 19);
            this.rangeMax.Name = "rangeMax";
            this.rangeMax.Size = new System.Drawing.Size(69, 20);
            this.rangeMax.TabIndex = 3;
            this.rangeMax.TextChanged += new System.EventHandler(this.rangeMax_TextChanged);
            // 
            // rangeMin
            // 
            this.rangeMin.BackColor = System.Drawing.SystemColors.Window;
            this.rangeMin.Location = new System.Drawing.Point(100, 19);
            this.rangeMin.Name = "rangeMin";
            this.rangeMin.Size = new System.Drawing.Size(69, 20);
            this.rangeMin.TabIndex = 1;
            this.rangeMin.TextChanged += new System.EventHandler(this.rangeMin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corruption range:";
            // 
            // seedBox
            // 
            this.seedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.seedBox.Enabled = false;
            this.seedBox.Location = new System.Drawing.Point(135, 229);
            this.seedBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seedBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(96, 20);
            this.seedBox.TabIndex = 5;
            // 
            // useSeed
            // 
            this.useSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.useSeed.AutoSize = true;
            this.useSeed.Location = new System.Drawing.Point(12, 230);
            this.useSeed.Name = "useSeed";
            this.useSeed.Size = new System.Drawing.Size(117, 17);
            this.useSeed.TabIndex = 4;
            this.useSeed.Text = "Custom RNG see&d:";
            this.useSeed.UseVisualStyleBackColor = true;
            this.useSeed.CheckedChanged += new System.EventHandler(this.useSeed_CheckedChanged);
            // 
            // corruptBtn
            // 
            this.corruptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.corruptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.corruptBtn.Enabled = false;
            this.corruptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corruptBtn.Location = new System.Drawing.Point(12, 253);
            this.corruptBtn.Name = "corruptBtn";
            this.corruptBtn.Size = new System.Drawing.Size(369, 40);
            this.corruptBtn.TabIndex = 7;
            this.corruptBtn.Text = "Select a process (top-left corner)";
            this.corruptBtn.UseVisualStyleBackColor = false;
            this.corruptBtn.Click += new System.EventHandler(this.corruptBtn_Click);
            this.corruptBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.corruptBtn_MouseDown);
            this.corruptBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.corruptBtn_MouseUp);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bctOr);
            this.groupBox2.Controls.Add(this.bctAnd);
            this.groupBox2.Controls.Add(this.bctXor);
            this.groupBox2.Controls.Add(this.bctAdd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bctArithmeticParam);
            this.groupBox2.Controls.Add(this.bctRandomMax);
            this.groupBox2.Controls.Add(this.bctRandomMin);
            this.groupBox2.Controls.Add(this.bctRandom);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Byte corruption type";
            // 
            // bctOr
            // 
            this.bctOr.AutoSize = true;
            this.bctOr.Location = new System.Drawing.Point(153, 45);
            this.bctOr.Name = "bctOr";
            this.bctOr.Size = new System.Drawing.Size(58, 17);
            this.bctOr.TabIndex = 7;
            this.bctOr.TabStop = true;
            this.bctOr.Text = "&Or with";
            this.bctOr.UseVisualStyleBackColor = true;
            this.bctOr.CheckedChanged += new System.EventHandler(this.bctRadioButtons_CheckedChanged);
            // 
            // bctAnd
            // 
            this.bctAnd.AutoSize = true;
            this.bctAnd.Location = new System.Drawing.Point(103, 45);
            this.bctAnd.Name = "bctAnd";
            this.bctAnd.Size = new System.Drawing.Size(44, 17);
            this.bctAnd.TabIndex = 6;
            this.bctAnd.TabStop = true;
            this.bctAnd.Text = "A&nd";
            this.bctAnd.UseVisualStyleBackColor = true;
            this.bctAnd.CheckedChanged += new System.EventHandler(this.bctRadioButtons_CheckedChanged);
            // 
            // bctXor
            // 
            this.bctXor.AutoSize = true;
            this.bctXor.Location = new System.Drawing.Point(56, 45);
            this.bctXor.Name = "bctXor";
            this.bctXor.Size = new System.Drawing.Size(41, 17);
            this.bctXor.TabIndex = 5;
            this.bctXor.TabStop = true;
            this.bctXor.Text = "&Xor";
            this.bctXor.UseVisualStyleBackColor = true;
            this.bctXor.CheckedChanged += new System.EventHandler(this.bctRadioButtons_CheckedChanged);
            // 
            // bctAdd
            // 
            this.bctAdd.AutoSize = true;
            this.bctAdd.Location = new System.Drawing.Point(6, 45);
            this.bctAdd.Name = "bctAdd";
            this.bctAdd.Size = new System.Drawing.Size(44, 17);
            this.bctAdd.TabIndex = 4;
            this.bctAdd.TabStop = true;
            this.bctAdd.Text = "&Add";
            this.bctAdd.UseVisualStyleBackColor = true;
            this.bctAdd.CheckedChanged += new System.EventHandler(this.bctRadioButtons_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "and";
            // 
            // bctArithmeticParam
            // 
            this.bctArithmeticParam.Enabled = false;
            this.bctArithmeticParam.Hexadecimal = true;
            this.bctArithmeticParam.Location = new System.Drawing.Point(211, 45);
            this.bctArithmeticParam.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bctArithmeticParam.Name = "bctArithmeticParam";
            this.bctArithmeticParam.Size = new System.Drawing.Size(35, 20);
            this.bctArithmeticParam.TabIndex = 8;
            this.bctArithmeticParam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bctRandomMax
            // 
            this.bctRandomMax.Hexadecimal = true;
            this.bctRandomMax.Location = new System.Drawing.Point(195, 19);
            this.bctRandomMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bctRandomMax.Name = "bctRandomMax";
            this.bctRandomMax.Size = new System.Drawing.Size(35, 20);
            this.bctRandomMax.TabIndex = 3;
            this.bctRandomMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // bctRandomMin
            // 
            this.bctRandomMin.Hexadecimal = true;
            this.bctRandomMin.Location = new System.Drawing.Point(123, 19);
            this.bctRandomMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bctRandomMin.Name = "bctRandomMin";
            this.bctRandomMin.Size = new System.Drawing.Size(35, 20);
            this.bctRandomMin.TabIndex = 1;
            // 
            // bctRandom
            // 
            this.bctRandom.AutoSize = true;
            this.bctRandom.Checked = true;
            this.bctRandom.Location = new System.Drawing.Point(6, 19);
            this.bctRandom.Name = "bctRandom";
            this.bctRandom.Size = new System.Drawing.Size(112, 17);
            this.bctRandom.TabIndex = 0;
            this.bctRandom.TabStop = true;
            this.bctRandom.Text = "&Random, between";
            this.bctRandom.UseVisualStyleBackColor = true;
            this.bctRandom.CheckedChanged += new System.EventHandler(this.bctRadioButtons_CheckedChanged);
            // 
            // copySeedBtn
            // 
            this.copySeedBtn.Location = new System.Drawing.Point(237, 227);
            this.copySeedBtn.Name = "copySeedBtn";
            this.copySeedBtn.Size = new System.Drawing.Size(69, 23);
            this.copySeedBtn.TabIndex = 6;
            this.copySeedBtn.Text = "&Copy Seed";
            this.copySeedBtn.UseVisualStyleBackColor = true;
            this.copySeedBtn.Click += new System.EventHandler(this.copySeedBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(312, 227);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(69, 23);
            this.aboutBtn.TabIndex = 8;
            this.aboutBtn.Text = "A&bout...";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 305);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.copySeedBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.seedBox);
            this.Controls.Add(this.useSeed);
            this.Controls.Add(this.corruptBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.procName);
            this.Controls.Add(this.selectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RAM Corruptor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byteCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bctArithmeticParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bctRandomMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bctRandomMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label procName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button corruptBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private RAMCorruptor.UserControls.HexTextBox rangeMax;
        private RAMCorruptor.UserControls.HexTextBox rangeMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refine;
        private System.Windows.Forms.CheckBox useRangeSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.NumericUpDown byteCount;
        private System.Windows.Forms.Button shiftRight;
        private System.Windows.Forms.Button shiftLeft;
        private UserControls.HexTextBox shiftAmount;
        private System.Windows.Forms.NumericUpDown seedBox;
        private System.Windows.Forms.CheckBox useSeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown bctRandomMax;
        private System.Windows.Forms.NumericUpDown bctRandomMin;
        private System.Windows.Forms.RadioButton bctRandom;
        private System.Windows.Forms.RadioButton bctOr;
        private System.Windows.Forms.RadioButton bctAnd;
        private System.Windows.Forms.RadioButton bctXor;
        private System.Windows.Forms.RadioButton bctAdd;
        private System.Windows.Forms.NumericUpDown bctArithmeticParam;
        private System.Windows.Forms.Button copySeedBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.NumericUpDown rangeSize;
        private System.Windows.Forms.LinkLabel rangeSizeRadix;
    }
}

