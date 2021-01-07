namespace jogoDaTabuada {
    partial class frmGame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.lblScoreMachine = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.pnlScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Location = new System.Drawing.Point(1, 1);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(768, 494);
            this.pnlGame.TabIndex = 1;
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScore.Controls.Add(this.lblScoreMachine);
            this.pnlScore.Controls.Add(this.lblScorePlayer);
            this.pnlScore.Controls.Add(this.lblFinish);
            this.pnlScore.Controls.Add(this.lblContinue);
            this.pnlScore.Controls.Add(this.label1);
            this.pnlScore.Controls.Add(this.lblPlay);
            this.pnlScore.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlScore.Location = new System.Drawing.Point(133, 49);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(505, 373);
            this.pnlScore.TabIndex = 1;
            // 
            // lblScoreMachine
            // 
            this.lblScoreMachine.AutoSize = true;
            this.lblScoreMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScoreMachine.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreMachine.ForeColor = System.Drawing.Color.White;
            this.lblScoreMachine.Location = new System.Drawing.Point(331, 26);
            this.lblScoreMachine.Name = "lblScoreMachine";
            this.lblScoreMachine.Size = new System.Drawing.Size(72, 85);
            this.lblScoreMachine.TabIndex = 9;
            this.lblScoreMachine.Text = "2";
            this.lblScoreMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScorePlayer.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer.ForeColor = System.Drawing.Color.White;
            this.lblScorePlayer.Location = new System.Drawing.Point(102, 26);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(72, 85);
            this.lblScorePlayer.TabIndex = 8;
            this.lblScorePlayer.Text = "5";
            this.lblScorePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFinish.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(150, 323);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(219, 37);
            this.lblFinish.TabIndex = 7;
            this.lblFinish.Text = "Encerrar a partida";
            this.lblFinish.Click += new System.EventHandler(this.lblFinish_Click);
            this.lblFinish.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            this.lblFinish.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouseMove);
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContinue.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.ForeColor = System.Drawing.Color.White;
            this.lblContinue.Location = new System.Drawing.Point(148, 241);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(215, 65);
            this.lblContinue.TabIndex = 6;
            this.lblContinue.Text = "Continuar";
            this.lblContinue.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            this.lblContinue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouseMove);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Computador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlay
            // 
            this.lblPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlay.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(27, 111);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(210, 51);
            this.lblPlay.TabIndex = 4;
            this.lblPlay.Text = "Jogador";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(770, 496);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlScore);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Tabuada";
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblScoreMachine;
        private System.Windows.Forms.Label lblScorePlayer;
    }
}