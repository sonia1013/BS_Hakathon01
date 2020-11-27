namespace _04_NumberGuess
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
            this.StartGame = new System.Windows.Forms.Button();
            this.LookUpAns = new System.Windows.Forms.Button();
            this.player_input = new System.Windows.Forms.TextBox();
            this.CheckAns = new System.Windows.Forms.Button();
            this.GiveUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(82, 75);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(130, 63);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "開始遊戲";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // LookUpAns
            // 
            this.LookUpAns.Location = new System.Drawing.Point(82, 182);
            this.LookUpAns.Name = "LookUpAns";
            this.LookUpAns.Size = new System.Drawing.Size(130, 65);
            this.LookUpAns.TabIndex = 1;
            this.LookUpAns.Text = "看答案";
            this.LookUpAns.UseVisualStyleBackColor = true;
            this.LookUpAns.Click += new System.EventHandler(this.LookUpAns_Click);
            // 
            // player_input
            // 
            this.player_input.Location = new System.Drawing.Point(82, 358);
            this.player_input.Name = "player_input";
            this.player_input.Size = new System.Drawing.Size(175, 25);
            this.player_input.TabIndex = 2;
            // 
            // CheckAns
            // 
            this.CheckAns.Location = new System.Drawing.Point(82, 421);
            this.CheckAns.Name = "CheckAns";
            this.CheckAns.Size = new System.Drawing.Size(78, 55);
            this.CheckAns.TabIndex = 3;
            this.CheckAns.Text = "檢查答案";
            this.CheckAns.UseVisualStyleBackColor = true;
            this.CheckAns.Click += new System.EventHandler(this.CheckAns_Click);
            // 
            // GiveUp
            // 
            this.GiveUp.Location = new System.Drawing.Point(181, 421);
            this.GiveUp.Name = "GiveUp";
            this.GiveUp.Size = new System.Drawing.Size(76, 55);
            this.GiveUp.TabIndex = 4;
            this.GiveUp.Text = "放棄重來";
            this.GiveUp.UseVisualStyleBackColor = true;
            this.GiveUp.Click += new System.EventHandler(this.GiveUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "輸入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "遊戲歷程";
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.ItemHeight = 15;
            this.History.Location = new System.Drawing.Point(465, 75);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(318, 409);
            this.History.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 598);
            this.Controls.Add(this.History);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GiveUp);
            this.Controls.Add(this.CheckAns);
            this.Controls.Add(this.player_input);
            this.Controls.Add(this.LookUpAns);
            this.Controls.Add(this.StartGame);
            this.Name = "Form1";
            this.Text = "GuessNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button LookUpAns;
        private System.Windows.Forms.TextBox player_input;
        private System.Windows.Forms.Button CheckAns;
        private System.Windows.Forms.Button GiveUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox History;
    }
}

