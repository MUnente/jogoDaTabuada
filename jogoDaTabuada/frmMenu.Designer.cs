namespace jogoDaTabuada {
    partial class frmMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHTP = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.lblBack2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbEasy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlHTP.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlay.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(77, 145);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(172, 85);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "Jogar";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            this.lblPlay.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            this.lblPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouseMove);
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHowToPlay.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.ForeColor = System.Drawing.Color.White;
            this.lblHowToPlay.Location = new System.Drawing.Point(78, 320);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(172, 43);
            this.lblHowToPlay.TabIndex = 4;
            this.lblHowToPlay.Text = "Como jogar?";
            this.lblHowToPlay.Click += new System.EventHandler(this.lblHowToPlay_Click);
            this.lblHowToPlay.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            this.lblHowToPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouseMove);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblHowToPlay);
            this.pnlMenu.Controls.Add(this.lblPlay);
            this.pnlMenu.Location = new System.Drawing.Point(2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(318, 474);
            this.pnlMenu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo da Tabuada";
            // 
            // pnlHTP
            // 
            this.pnlHTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHTP.Controls.Add(this.textBox1);
            this.pnlHTP.Controls.Add(this.lblBack);
            this.pnlHTP.Location = new System.Drawing.Point(2, 2);
            this.pnlHTP.Name = "pnlHTP";
            this.pnlHTP.Size = new System.Drawing.Size(318, 474);
            this.pnlHTP.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(3, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(312, 390);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(107, 419);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(105, 47);
            this.lblBack.TabIndex = 3;
            this.lblBack.Text = "Voltar";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            this.lblBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouseMove);
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.Controls.Add(this.lblStartGame);
            this.pnlDifficulty.Controls.Add(this.lblBack2);
            this.pnlDifficulty.Controls.Add(this.label4);
            this.pnlDifficulty.Controls.Add(this.rdbHard);
            this.pnlDifficulty.Controls.Add(this.rdbMedium);
            this.pnlDifficulty.Controls.Add(this.rdbEasy);
            this.pnlDifficulty.Controls.Add(this.label3);
            this.pnlDifficulty.Location = new System.Drawing.Point(2, 2);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(318, 474);
            this.pnlDifficulty.TabIndex = 6;
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStartGame.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.ForeColor = System.Drawing.Color.White;
            this.lblStartGame.Location = new System.Drawing.Point(86, 349);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(149, 51);
            this.lblStartGame.TabIndex = 6;
            this.lblStartGame.Text = "Começar";
            this.lblStartGame.Click += new System.EventHandler(this.lblStartGame_Click);
            this.lblStartGame.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            this.lblStartGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouseMove);
            // 
            // lblBack2
            // 
            this.lblBack2.AutoSize = true;
            this.lblBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack2.ForeColor = System.Drawing.Color.White;
            this.lblBack2.Location = new System.Drawing.Point(125, 433);
            this.lblBack2.Name = "lblBack2";
            this.lblBack2.Size = new System.Drawing.Size(75, 33);
            this.lblBack2.TabIndex = 5;
            this.lblBack2.Text = "Voltar";
            this.lblBack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack2.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack2.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            this.lblBack2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouseMove);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 93);
            this.label4.TabIndex = 4;
            this.label4.Text = "Escolha um nível de dificuldade do game e click em \"Começar\":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHard.ForeColor = System.Drawing.Color.White;
            this.rdbHard.Location = new System.Drawing.Point(106, 283);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(88, 37);
            this.rdbHard.TabIndex = 3;
            this.rdbHard.TabStop = true;
            this.rdbHard.Text = "Difícil";
            this.rdbHard.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedium.ForeColor = System.Drawing.Color.White;
            this.rdbMedium.Location = new System.Drawing.Point(106, 240);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(130, 37);
            this.rdbMedium.TabIndex = 2;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Moderado";
            this.rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbEasy
            // 
            this.rdbEasy.AutoSize = true;
            this.rdbEasy.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEasy.ForeColor = System.Drawing.Color.White;
            this.rdbEasy.Location = new System.Drawing.Point(106, 197);
            this.rdbEasy.Name = "rdbEasy";
            this.rdbEasy.Size = new System.Drawing.Size(76, 37);
            this.rdbEasy.TabIndex = 1;
            this.rdbEasy.TabStop = true;
            this.rdbEasy.Text = "Fácil";
            this.rdbEasy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nível de dificuldade";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(322, 477);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHTP);
            this.Controls.Add(this.pnlDifficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Tabuada";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlHTP.ResumeLayout(false);
            this.pnlHTP.PerformLayout();
            this.pnlDifficulty.ResumeLayout(false);
            this.pnlDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbEasy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBack2;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.TextBox textBox1;
    }
}

