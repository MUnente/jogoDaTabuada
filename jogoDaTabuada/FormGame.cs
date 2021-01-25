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
        private GameMatch gameMatch = new GameMatch();
        
        public FormGame(string diff) {
            InitializeComponent();
            gameMatchRules(diff);
            pnlReadyFocus();
        }

        private void gameMatchRules(string d) {
            gameMatch.setDifficulty(d);
            gameMatch.setDiffTimer(changeTimer(d));
            gameMatch.setMinAnsw(changeMinJumps(d));
        }

        private void pnlReadyFocus() {
            startGameData();
            pnlScore.Enabled = false;
            pnlFinish.Enabled = false;
            pnlGame.Enabled = false;
            pnlReady.Enabled = true;
            pnlScore.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = false;
            pnlReady.Visible = true;
        }

        private void pnlGameFocus() {
            generateRandom();
            gameMatch.setCountdown(gameMatch.getDiffTimer());
            lblTimer.Text = "Tempo: " + gameMatch.getDiffTimer().ToString() + " segundos";
            lblDifficulty.Text = "Dificuldade: " + gameMatch.getDifficulty();
            lblFactor1.Text = gameMatch.getFactor1().ToString();
            lblFactor2.Text = gameMatch.getFactor2().ToString();
            pnlReady.Enabled = false;
            pnlScore.Enabled = false;
            pnlFinish.Enabled = false;
            pnlGame.Enabled = true;
            pnlReady.Visible = false;
            pnlScore.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = true;
            txtProduct.MaxLength = 3;
            txtProduct.Text = "0";
            txtProduct.SelectAll();
            txtProduct.Focus();
        }

        private void pnlScoreFocus(char op) {
            if (op == 'v') {
                if (verifyResult() == true) {
                    lblMsg.Text = "Parabéns, você acertou!";
                    lblMultiResult.Text = "Resultado: " + (gameMatch.getFactor1() * gameMatch.getFactor2()).ToString();
                    try {
                        picResult.Image = JogoDaTabuada.Properties.Resources.partying_emoji;
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lblMsg.Location = new Point(110, 12);
                    picResult.Location = new Point(458, 23);
                    player_1.setScore(player_1.getScore() + 1);
                    rightAnswController(true);
                }
                else {
                    lblMsg.Text = "Poxa, você não acertou!";
                    lblMultiResult.Text = "Resultado: " + (gameMatch.getFactor1() * gameMatch.getFactor2()).ToString();
                    try {
                        picResult.Image = JogoDaTabuada.Properties.Resources.sad_emoji;
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lblMsg.Location = new Point(110, 12);
                    picResult.Location = new Point(458, 23);
                    player_pc.setScore(player_pc.getScore() + 1);
                    rightAnswController(false);
                }
            }
            else {
                lblMsg.Text = "Poxa, você deixou o tempo estourar!";
                lblMultiResult.Text = "Resultado: " + (gameMatch.getFactor1() * gameMatch.getFactor2()).ToString();
                try {
                    picResult.Image = JogoDaTabuada.Properties.Resources.sad_emoji;
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lblMsg.Location = new Point(24, 12);
                picResult.Location = new Point(542, 23);
                player_pc.setScore(player_pc.getScore() + 1);
                rightAnswController(false);
            }
            lblScoreMachine.Text = player_pc.getScore().ToString();
            lblScorePlayer.Text = player_1.getScore().ToString();
            gameMatch.setRounds(gameMatch.getRounds() + 1);
            pnlReady.Enabled = false;
            pnlFinish.Enabled = false;
            pnlGame.Enabled = false;
            pnlScore.Enabled = true;
            pnlReady.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = false;
            pnlScore.Visible = true;
        }

        private void pnlFinishFocus() {
            if (player_1.getScore() > player_pc.getScore())
                lblWinner.Text = "E o ganhador foi: Jogador";
            else if (player_1.getScore() < player_pc.getScore())
                lblWinner.Text = "E o ganhador foi: Computador";
            else if (player_1.getScore() == player_pc.getScore())
                lblWinner.Text = "Houve um empate técnico";
            lblWinner.Location = new Point((pnlFinish.Width - lblWinner.Width)/2, 12);
            lblScorePlayer1.Text = player_1.getScore().ToString();
            lblScoreMachine1.Text = player_pc.getScore().ToString();
            lblTotalRounds.Text = "Total de rounds: " + gameMatch.getRounds();
            pnlReady.Enabled = false;
            pnlScore.Enabled = false;
            pnlGame.Enabled = false;
            pnlFinish.Enabled = true;
            pnlReady.Visible = false;
            pnlScore.Visible = false;
            pnlGame.Visible = false;
            pnlFinish.Visible = true;
        }

        private void startGameData() {
            gameMatch.setCountdown(0);
            gameMatch.setFactor1(0);
            gameMatch.setFactor2(0);
            gameMatch.setRounds(0);
            player_1.setProduct(0);
            player_1.setScore(0);
            player_1.setJump(0);
            player_1.setRightAnsw(0);
            player_pc.setScore(0);
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
        
        private byte changeMinJumps(string d) {
            byte minJumps;
            if (d == "Fácil")
                minJumps = 3;
            else if (d == "Moderado")
                minJumps = 4;
            else
                minJumps = 5;
            return minJumps;
        }

        private void generateRandom() {
            Random random = new Random();
            gameMatch.setFactor1(random.Next(1, 10));
            gameMatch.setFactor2(random.Next(1, 10));
        }

        private void rightAnswController(bool op) {
            if (op == true) {
                player_1.setRightAnsw(player_1.getRightAnsw() + 1);
                if (player_1.getRightAnsw() == gameMatch.getMinAnsw()) {
                    player_1.setJump(player_1.getJump() + 1);
                    player_1.setRightAnsw(0);
                }
            }
            else
                player_1.setRightAnsw(0);
        }

        private bool jumpController() {
            bool hasJump = false;
            if (player_1.getJump() >= 1) {
                hasJump = true;
                player_1.setJump(player_1.getJump() - 1);
            }
            return hasJump;
        }

        private bool verifyResult() {
            bool isCorrect = false;
            if (gameMatch.getFactor1() * gameMatch.getFactor2() == player_1.getProduct())
                isCorrect = true;
            return isCorrect;
        }

        private void showScore() {
            if (txtProduct.Text == "")
                MessageBox.Show("Digíte o resultado da multiplicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                player_1.setProduct(Convert.ToInt32(txtProduct.Text));
                timer1.Stop();
                pnlScoreFocus('v');
            }
        }

        private void backMenu() {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            gameMatch.setCountdown(gameMatch.getCountdown() - 1);
            if (gameMatch.getCountdown() == 0) {
                timer1.Enabled = false;
                pnlScoreFocus('t');
            }
            lblTimer.Text = "Tempo: " + gameMatch.getCountdown() + " segundos";
        }

        private void round_Click(object sender, EventArgs e) {
            pnlGameFocus();
            timer1.Enabled = true;
        }

        private void lblVerify_Click(object sender, EventArgs e) {
            showScore();
        }

        private void lblJump_Click(object sender, EventArgs e) {
            if (jumpController())
                pnlGameFocus();
            else
                MessageBox.Show("Você não possui pulos suficientes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lblFinishMatch_Click(object sender, EventArgs e) {
            DialogResult d = MessageBox.Show("Você tem certeza desta ação?", "Encerrar a partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.ToString() == "Yes")
                pnlFinishFocus();
        }

        private void lblNewMatch_Click(object sender, EventArgs e) {
            pnlReadyFocus();
        }

        private void back_Click(object sender, EventArgs e) {
            backMenu();
        }

        private void verifyWithEnter(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 13)
                showScore();
        }

        private void lblAquaRed_MouseMove(object sender, MouseEventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null) {
                if (someLabel.Name == "lblFinish" || someLabel.Name == "lblBack" || someLabel.Name == "lblBack1" || someLabel.Name == "lblFinishMatch")
                    someLabel.ForeColor = System.Drawing.Color.Red;
                else
                    someLabel.ForeColor = System.Drawing.Color.Aqua;
            }
        }

        private void lblWhite_MouseLeave(object sender, EventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.White;
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Deseja sair da partida?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.ToString() == "Yes") {
                e.Cancel = false;
                FormMenu menu = new FormMenu();
                menu.Show();
            }
            else
                e.Cancel = true;
        }
    }
}