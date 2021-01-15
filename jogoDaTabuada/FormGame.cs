using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaTabuada {
    public partial class FormGame : Form {
        private Player player_1 = new Player();
        private Player player_pc = new Player();
        private Game game = new Game();
        
        public FormGame(string diff) {
            InitializeComponent();
            txtProduct.MaxLength = 3;
            frmLoad(diff);
            pnlReadyFocus();
        }

        private void frmLoad(string d) {
            game.setDifficulty(d);
            game.setDiffTimer(changeTimer(d));
            game.setMinimalJumps(changeMinJumps(d));
        }

        private void pnlReadyFocus() {
            pnlScore.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = false;
            pnlReady.Visible = true;
        }

        private void pnlGameFocus() {
            generateRandom();
            game.setCountdown(game.getDiffTimer());
            lblTimer.Text = "Tempo: " + game.getDiffTimer().ToString() + " segundos";
            lblDifficulty.Text = "Dificuldade: " + game.getDifficulty();
            lblFactor1.Text = game.getFactor1().ToString();
            lblFactor2.Text = game.getFactor2().ToString();
            pnlReady.Visible = false;
            pnlScore.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = true;
            txtProduct.Text = "0";
            txtProduct.Focus();
        }

        private void pnlScoreFocus(char op) {
            if (op == 'v') {
                if (result() == true) {
                    lblMsg.Text = "Parabéns, você acertou!";
                    lblMultiResult.Text = "Resultado: " + (game.getFactor1() * game.getFactor2()).ToString();
                    try {
                        picResult.Image = JogoDaTabuada.Properties.Resources.partying_emoji;
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lblMsg.Location = new Point(110, 12);
                    picResult.Location = new Point(458, 23);
                    player_1.setScore(player_1.getScore() + 1);
                }
                else {
                    lblMsg.Text = "Poxa, você não acertou!";
                    lblMultiResult.Text = "Resultado: " + (game.getFactor1() * game.getFactor2()).ToString();
                    try {
                        picResult.Image = JogoDaTabuada.Properties.Resources.sad_emoji;
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lblMsg.Location = new Point(110, 12);
                    picResult.Location = new Point(458, 23);
                    player_pc.setScore(player_pc.getScore() + 1);
                }
            }
            else {
                lblMsg.Text = "Poxa, você deixou o tempo estourar!";
                lblMultiResult.Text = "Resultado: " + (game.getFactor1() * game.getFactor2()).ToString();
                try {
                    picResult.Image = JogoDaTabuada.Properties.Resources.sad_emoji;
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lblMsg.Location = new Point(24, 12);
                picResult.Location = new Point(542, 23);
                player_pc.setScore(player_pc.getScore() + 1);
            }
            lblScoreMachine.Text = player_pc.getScore().ToString();
            lblScorePlayer.Text = player_1.getScore().ToString();
            pnlReady.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = false;
            pnlScore.Visible = true;
        }

        private void pnlFinishFocus() {
            pnlReady.Visible = false;
            pnlScore.Visible = false;
            pnlGame.Visible = false;
            pnlFinish.Visible = true;
        }

        private int changeTimer(string d) {
            int timer;
            if (d == "Fácil")
                timer = 15;
            else if (d == "Moderado")
                timer = 10;
            else
                timer = 5;
            return timer;
        }

        private short changeMinJumps(string d) {
            short minJumps;
            if (d == "Fácil")
                minJumps = 2;
            else if (d == "Moderado")
                minJumps = 3;
            else
                minJumps = 4;
            return minJumps;
        }

        private bool result() {
            bool isCorrect = false;
            if (game.getFactor1() * game.getFactor2() == player_1.getProduct())
                isCorrect = true;
            return isCorrect;
        }

        private void generateRandom() {
            Random random = new Random();
            game.setFactor1(random.Next(1, 10));
            game.setFactor2(random.Next(1, 10));
        }

        private void timer1_Tick(object sender, EventArgs e) {
            game.setCountdown(game.getCountdown() - 1);
            if (game.getCountdown() == 0) {
                timer1.Stop();
                pnlScoreFocus('t');
            }
            lblTimer.Text = "Tempo: " + game.getCountdown() + " segundos";
        }

        private void round_Click(object sender, EventArgs e) {
            pnlGameFocus();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void verify_Click(object sender, EventArgs e) {
            player_1.setProduct(Convert.ToInt32(txtProduct.Text));
            timer1.Stop();
            pnlScoreFocus('v');
        }

        private void jump_Click(object sender, EventArgs e) {
            
        }

        private void finishMatch_Click(object sender, EventArgs e) {
            
        }

        private void backMenu_Click(object sender, EventArgs e) {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void lblAquaRed_MouseMove(object sender, MouseEventArgs e) {
            Label someLabel = sender as Label;
            //PictureBox somePic = sender as PictureBox;
            if (someLabel != null) {
                if (someLabel.Name == "lblFinish" || someLabel.Name == "lblBackMenu" || someLabel.Name == "lblBackMenu1" || someLabel.Name == "lblFinishMatch")
                    someLabel.ForeColor = System.Drawing.Color.Red;
                else
                    someLabel.ForeColor = System.Drawing.Color.Aqua;
            }
            //if (somePic != null)
            //    if (somePic.Name == "picJump")
            //        lblJump.ForeColor = System.Drawing.Color.Aqua;
        }

        private void lblWhite_MouseLeave(object sender, EventArgs e) {
            Label someLabel = sender as Label;
            //PictureBox somePic = sender as PictureBox;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.White;
            //if (somePic != null)
            //    if (somePic.Name == "picJump")
            //        lblJump.ForeColor = System.Drawing.Color.Aqua;
        }

        /*protected override void OnFormClosing(FormClosingEventArgs e) {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Deseja sair da partida?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.ToString() == "Yes") {
                MessageBox.Show("O ganhador foi: " + "\n Placar: ", "Ganhador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
                e.Cancel = true;
        }*/
    }
}