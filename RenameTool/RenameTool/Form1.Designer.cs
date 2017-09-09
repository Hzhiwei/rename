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
            this.label2 = new System.Windows.Forms.Label();
            this.keyAP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keyA = new System.Windows.Forms.TextBox();
            this.keyAA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.keyBP = new System.Windows.Forms.TextBox();
            this.keyB = new System.Windows.Forms.TextBox();
            this.keyBA = new System.Windows.Forms.TextBox();
            this.keyCP = new System.Windows.Forms.TextBox();
            this.keyC = new System.Windows.Forms.TextBox();
            this.keyCA = new System.Windows.Forms.TextBox();
            this.ShowResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathLabel.Location = new System.Drawing.Point(94, 12);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.ReadOnly = true;
            this.PathLabel.Size = new System.Drawing.Size(549, 21);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "...";
            // 
            // Path_Button
            // 
            this.Path_Button.Location = new System.Drawing.Point(13, 10);
            this.Path_Button.Name = "Path_Button";
            this.Path_Button.Size = new System.Drawing.Size(75, 23);
            this.Path_Button.TabIndex = 1;
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
            this.filter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "关键字正则表达式A：";
            // 
            // keyAP
            // 
            this.keyAP.Location = new System.Drawing.Point(12, 120);
            this.keyAP.Name = "keyAP";
            this.keyAP.Size = new System.Drawing.Size(100, 21);
            this.keyAP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(11, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "关键字正则表达式B：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(11, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "关键字正则表达式C：";
            // 
            // keyA
            // 
            this.keyA.Location = new System.Drawing.Point(116, 120);
            this.keyA.Name = "keyA";
            this.keyA.Size = new System.Drawing.Size(100, 21);
            this.keyA.TabIndex = 3;
            // 
            // keyAA
            // 
            this.keyAA.Location = new System.Drawing.Point(222, 120);
            this.keyAA.Name = "keyAA";
            this.keyAA.Size = new System.Drawing.Size(100, 21);
            this.keyAA.TabIndex = 3;
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
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 283);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(310, 21);
            this.textBox13.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "重命名";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // keyBP
            // 
            this.keyBP.Location = new System.Drawing.Point(12, 175);
            this.keyBP.Name = "keyBP";
            this.keyBP.Size = new System.Drawing.Size(100, 21);
            this.keyBP.TabIndex = 3;
            // 
            // keyB
            // 
            this.keyB.Location = new System.Drawing.Point(116, 175);
            this.keyB.Name = "keyB";
            this.keyB.Size = new System.Drawing.Size(100, 21);
            this.keyB.TabIndex = 3;
            // 
            // keyBA
            // 
            this.keyBA.Location = new System.Drawing.Point(222, 175);
            this.keyBA.Name = "keyBA";
            this.keyBA.Size = new System.Drawing.Size(100, 21);
            this.keyBA.TabIndex = 3;
            // 
            // keyCP
            // 
            this.keyCP.Location = new System.Drawing.Point(12, 230);
            this.keyCP.Name = "keyCP";
            this.keyCP.Size = new System.Drawing.Size(100, 21);
            this.keyCP.TabIndex = 3;
            // 
            // keyC
            // 
            this.keyC.Location = new System.Drawing.Point(116, 230);
            this.keyC.Name = "keyC";
            this.keyC.Size = new System.Drawing.Size(100, 21);
            this.keyC.TabIndex = 3;
            // 
            // keyCA
            // 
            this.keyCA.Location = new System.Drawing.Point(222, 230);
            this.keyCA.Name = "keyCA";
            this.keyCA.Size = new System.Drawing.Size(100, 21);
            this.keyCA.TabIndex = 3;
            // 
            // ShowResult
            // 
            this.ShowResult.Location = new System.Drawing.Point(328, 39);
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.ReadOnly = true;
            this.ShowResult.Size = new System.Drawing.Size(315, 310);
            this.ShowResult.TabIndex = 6;
            this.ShowResult.Text = "";
            // 
            // rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 361);
            this.Controls.Add(this.ShowResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyCA);
            this.Controls.Add(this.keyBA);
            this.Controls.Add(this.keyAA);
            this.Controls.Add(this.keyC);
            this.Controls.Add(this.keyB);
            this.Controls.Add(this.keyA);
            this.Controls.Add(this.keyCP);
            this.Controls.Add(this.keyBP);
            this.Controls.Add(this.keyAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_Button);
            this.Controls.Add(this.PathLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rename";
            this.Text = "rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathLabel;
        private System.Windows.Forms.Button Path_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyAP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyA;
        private System.Windows.Forms.TextBox keyAA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox keyBP;
        private System.Windows.Forms.TextBox keyB;
        private System.Windows.Forms.TextBox keyBA;
        private System.Windows.Forms.TextBox keyCP;
        private System.Windows.Forms.TextBox keyC;
        private System.Windows.Forms.TextBox keyCA;
        private System.Windows.Forms.RichTextBox ShowResult;
    }
}

