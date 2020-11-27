namespace _02_DegreeTransfer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CeltoFah = new System.Windows.Forms.RadioButton();
            this.FahtoCel = new System.Windows.Forms.RadioButton();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.transfer = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.resultlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CeltoFah
            // 
            this.CeltoFah.AutoSize = true;
            this.CeltoFah.Location = new System.Drawing.Point(31, 33);
            this.CeltoFah.Name = "CeltoFah";
            this.CeltoFah.Size = new System.Drawing.Size(133, 19);
            this.CeltoFah.TabIndex = 0;
            this.CeltoFah.TabStop = true;
            this.CeltoFah.Text = "攝氏轉換為華氏";
            this.CeltoFah.UseVisualStyleBackColor = true;
            // 
            // FahtoCel
            // 
            this.FahtoCel.AutoSize = true;
            this.FahtoCel.Location = new System.Drawing.Point(31, 77);
            this.FahtoCel.Name = "FahtoCel";
            this.FahtoCel.Size = new System.Drawing.Size(133, 19);
            this.FahtoCel.TabIndex = 1;
            this.FahtoCel.TabStop = true;
            this.FahtoCel.Text = "華氏轉換為攝氏";
            this.FahtoCel.UseVisualStyleBackColor = true;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(235, 66);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(59, 53);
            this.num1.TabIndex = 2;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.num1_MouseClick);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(315, 66);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(58, 53);
            this.num2.TabIndex = 3;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(390, 66);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(58, 53);
            this.num3.TabIndex = 4;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(236, 143);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(58, 53);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(315, 143);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(58, 53);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(390, 143);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(58, 53);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(236, 216);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(58, 53);
            this.num7.TabIndex = 8;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(315, 216);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(58, 53);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(390, 216);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(58, 53);
            this.num9.TabIndex = 10;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(235, 292);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(58, 53);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(315, 292);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(58, 53);
            this.dot.TabIndex = 12;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("新細明體", 14F);
            this.input.Location = new System.Drawing.Point(529, 83);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(246, 35);
            this.input.TabIndex = 13;
            // 
            // transfer
            // 
            this.transfer.Location = new System.Drawing.Point(529, 160);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(111, 53);
            this.transfer.TabIndex = 14;
            this.transfer.Text = "轉換";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(664, 160);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 53);
            this.clear.TabIndex = 15;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Font = new System.Drawing.Font("新細明體", 13F);
            this.resultlabel.Location = new System.Drawing.Point(529, 259);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(60, 22);
            this.resultlabel.TabIndex = 16;
            this.resultlabel.Text = "結果:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CeltoFah);
            this.groupBox1.Controls.Add(this.FahtoCel);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 402);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.input);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CeltoFah;
        private System.Windows.Forms.RadioButton FahtoCel;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

