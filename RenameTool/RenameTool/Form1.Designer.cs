namespace RenameTool
{
    partial class rename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rename));
            this.PathLabel = new System.Windows.Forms.TextBox();
            this.Path_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.TextBox();
            this.keyAP = new System.Windows.Forms.TextBox();
            this.keyA = new System.Windows.Forms.TextBox();
            this.keyAA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewNameRule = new System.Windows.Forms.TextBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.keyBP = new System.Windows.Forms.TextBox();
            this.keyB = new System.Windows.Forms.TextBox();
            this.keyBA = new System.Windows.Forms.TextBox();
            this.keyCP = new System.Windows.Forms.TextBox();
            this.keyC = new System.Windows.Forms.TextBox();
            this.keyCA = new System.Windows.Forms.TextBox();
            this.ShowResult = new System.Windows.Forms.RichTextBox();
            this.KeyFilterA = new System.Windows.Forms.CheckBox();
            this.KeyFilterB = new System.Windows.Forms.CheckBox();
            this.KeyFilterC = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountMode = new System.Windows.Forms.CheckBox();
            this.IndexStart = new System.Windows.Forms.NumericUpDown();
            this.InfoOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexStart)).BeginInit();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathLabel.Location = new System.Drawing.Point(94, 12);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.ReadOnly = true;
            this.PathLabel.Size = new System.Drawing.Size(584, 21);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "...";
            // 
            // Path_Button
            // 
            this.Path_Button.Location = new System.Drawing.Point(13, 10);
            this.Path_Button.Name = "Path_Button";
            this.Path_Button.Size = new System.Drawing.Size(75, 23);
            this.Path_Button.TabIndex = 0;
            this.Path_Button.Text = "Path";
            this.Path_Button.UseVisualStyleBackColor = true;
            this.Path_Button.Click += new System.EventHandler(this.Path_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "筛选正则表达式：";
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(12, 65);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(310, 21);
            this.filter.TabIndex = 1;
            this.filter.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyAP
            // 
            this.keyAP.Location = new System.Drawing.Point(12, 120);
            this.keyAP.Name = "keyAP";
            this.keyAP.Size = new System.Drawing.Size(100, 21);
            this.keyAP.TabIndex = 2;
            this.keyAP.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyA
            // 
            this.keyA.Location = new System.Drawing.Point(116, 120);
            this.keyA.Name = "keyA";
            this.keyA.Size = new System.Drawing.Size(100, 21);
            this.keyA.TabIndex = 3;
            this.keyA.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyAA
            // 
            this.keyAA.Location = new System.Drawing.Point(222, 120);
            this.keyAA.Name = "keyAA";
            this.keyAA.Size = new System.Drawing.Size(100, 21);
            this.keyAA.TabIndex = 4;
            this.keyAA.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "重命名：";
            // 
            // NewNameRule
            // 
            this.NewNameRule.Location = new System.Drawing.Point(12, 283);
            this.NewNameRule.Name = "NewNameRule";
            this.NewNameRule.Size = new System.Drawing.Size(310, 21);
            this.NewNameRule.TabIndex = 11;
            this.NewNameRule.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // RenameButton
            // 
            this.RenameButton.Enabled = false;
            this.RenameButton.Location = new System.Drawing.Point(222, 326);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(75, 23);
            this.RenameButton.TabIndex = 5;
            this.RenameButton.Text = "重命名";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // keyBP
            // 
            this.keyBP.Enabled = false;
            this.keyBP.Location = new System.Drawing.Point(12, 175);
            this.keyBP.Name = "keyBP";
            this.keyBP.Size = new System.Drawing.Size(100, 21);
            this.keyBP.TabIndex = 5;
            this.keyBP.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyB
            // 
            this.keyB.Enabled = false;
            this.keyB.Location = new System.Drawing.Point(116, 175);
            this.keyB.Name = "keyB";
            this.keyB.Size = new System.Drawing.Size(100, 21);
            this.keyB.TabIndex = 6;
            this.keyB.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyBA
            // 
            this.keyBA.Enabled = false;
            this.keyBA.Location = new System.Drawing.Point(222, 175);
            this.keyBA.Name = "keyBA";
            this.keyBA.Size = new System.Drawing.Size(100, 21);
            this.keyBA.TabIndex = 7;
            this.keyBA.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyCP
            // 
            this.keyCP.Enabled = false;
            this.keyCP.Location = new System.Drawing.Point(12, 230);
            this.keyCP.Name = "keyCP";
            this.keyCP.Size = new System.Drawing.Size(100, 21);
            this.keyCP.TabIndex = 8;
            this.keyCP.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyC
            // 
            this.keyC.Enabled = false;
            this.keyC.Location = new System.Drawing.Point(116, 230);
            this.keyC.Name = "keyC";
            this.keyC.Size = new System.Drawing.Size(100, 21);
            this.keyC.TabIndex = 9;
            this.keyC.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // keyCA
            // 
            this.keyCA.Enabled = false;
            this.keyCA.Location = new System.Drawing.Point(222, 230);
            this.keyCA.Name = "keyCA";
            this.keyCA.Size = new System.Drawing.Size(100, 21);
            this.keyCA.TabIndex = 10;
            this.keyCA.TextChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // ShowResult
            // 
            this.ShowResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowResult.Location = new System.Drawing.Point(328, 39);
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.ReadOnly = true;
            this.ShowResult.Size = new System.Drawing.Size(350, 336);
            this.ShowResult.TabIndex = 6;
            this.ShowResult.Text = "";
            // 
            // KeyFilterA
            // 
            this.KeyFilterA.AutoSize = true;
            this.KeyFilterA.Checked = true;
            this.KeyFilterA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeyFilterA.ForeColor = System.Drawing.Color.Red;
            this.KeyFilterA.Location = new System.Drawing.Point(13, 98);
            this.KeyFilterA.Name = "KeyFilterA";
            this.KeyFilterA.Size = new System.Drawing.Size(138, 16);
            this.KeyFilterA.TabIndex = 7;
            this.KeyFilterA.Text = "关键字正则表达式A：";
            this.KeyFilterA.UseVisualStyleBackColor = true;
            this.KeyFilterA.CheckedChanged += new System.EventHandler(this.KeyFilterA_CheckedChanged);
            // 
            // KeyFilterB
            // 
            this.KeyFilterB.AutoSize = true;
            this.KeyFilterB.ForeColor = System.Drawing.Color.Green;
            this.KeyFilterB.Location = new System.Drawing.Point(12, 153);
            this.KeyFilterB.Name = "KeyFilterB";
            this.KeyFilterB.Size = new System.Drawing.Size(138, 16);
            this.KeyFilterB.TabIndex = 7;
            this.KeyFilterB.Text = "关键字正则表达式B：";
            this.KeyFilterB.UseVisualStyleBackColor = true;
            this.KeyFilterB.CheckedChanged += new System.EventHandler(this.KeyFilterB_CheckedChanged);
            // 
            // KeyFilterC
            // 
            this.KeyFilterC.AutoSize = true;
            this.KeyFilterC.ForeColor = System.Drawing.Color.Blue;
            this.KeyFilterC.Location = new System.Drawing.Point(12, 208);
            this.KeyFilterC.Name = "KeyFilterC";
            this.KeyFilterC.Size = new System.Drawing.Size(138, 16);
            this.KeyFilterC.TabIndex = 7;
            this.KeyFilterC.Text = "关键字正则表达式C：";
            this.KeyFilterC.UseVisualStyleBackColor = true;
            this.KeyFilterC.CheckedChanged += new System.EventHandler(this.KeyFilterC_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CountMode
            // 
            this.CountMode.AutoSize = true;
            this.CountMode.Location = new System.Drawing.Point(84, 311);
            this.CountMode.Name = "CountMode";
            this.CountMode.Size = new System.Drawing.Size(72, 16);
            this.CountMode.TabIndex = 13;
            this.CountMode.Text = "计数模式";
            this.CountMode.UseVisualStyleBackColor = true;
            this.CountMode.CheckedChanged += new System.EventHandler(this.CountMode_CheckedChanged);
            // 
            // IndexStart
            // 
            this.IndexStart.Enabled = false;
            this.IndexStart.Location = new System.Drawing.Point(84, 333);
            this.IndexStart.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.IndexStart.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.IndexStart.Name = "IndexStart";
            this.IndexStart.Size = new System.Drawing.Size(72, 21);
            this.IndexStart.TabIndex = 14;
            this.IndexStart.ValueChanged += new System.EventHandler(this.RefreshResultTextBox);
            // 
            // InfoOutput
            // 
            this.InfoOutput.AutoSize = true;
            this.InfoOutput.ForeColor = System.Drawing.Color.Teal;
            this.InfoOutput.Location = new System.Drawing.Point(15, 366);
            this.InfoOutput.Name = "InfoOutput";
            this.InfoOutput.Size = new System.Drawing.Size(47, 12);
            this.InfoOutput.TabIndex = 15;
            this.InfoOutput.Text = "F1 帮助";
            // 
            // rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 387);
            this.Controls.Add(this.InfoOutput);
            this.Controls.Add(this.IndexStart);
            this.Controls.Add(this.CountMode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KeyFilterC);
            this.Controls.Add(this.KeyFilterB);
            this.Controls.Add(this.KeyFilterA);
            this.Controls.Add(this.ShowResult);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyCA);
            this.Controls.Add(this.keyBA);
            this.Controls.Add(this.keyAA);
            this.Controls.Add(this.keyC);
            this.Controls.Add(this.keyB);
            this.Controls.Add(this.keyA);
            this.Controls.Add(this.keyCP);
            this.Controls.Add(this.keyBP);
            this.Controls.Add(this.keyAP);
            this.Controls.Add(this.NewNameRule);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_Button);
            this.Controls.Add(this.PathLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rename";
            this.Text = "rename";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathLabel;
        private System.Windows.Forms.Button Path_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filter;
        private System.Windows.Forms.TextBox keyAP;
        private System.Windows.Forms.TextBox keyA;
        private System.Windows.Forms.TextBox keyAA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewNameRule;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.TextBox keyBP;
        private System.Windows.Forms.TextBox keyB;
        private System.Windows.Forms.TextBox keyBA;
        private System.Windows.Forms.TextBox keyCP;
        private System.Windows.Forms.TextBox keyC;
        private System.Windows.Forms.TextBox keyCA;
        private System.Windows.Forms.RichTextBox ShowResult;
        private System.Windows.Forms.CheckBox KeyFilterA;
        private System.Windows.Forms.CheckBox KeyFilterB;
        private System.Windows.Forms.CheckBox KeyFilterC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CountMode;
        private System.Windows.Forms.NumericUpDown IndexStart;
        private System.Windows.Forms.Label InfoOutput;
    }
}

