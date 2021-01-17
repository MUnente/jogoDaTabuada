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
        // Instanciando os objetos Player, Computador e Match
        private Player player_1 = new Player();
        private Player player_pc = new Player();
        private Match gameMatch = new Match();
        
        // Iniciando o form
        public FormGame(string diff) {
            InitializeComponent();
            gameMatchRules(diff);
            pnlReadyFocus();
        }

        // Procedimento para definir regras da partida
        private void gameMatchRules(string d) {
            gameMatch.setDifficulty(d);
            gameMatch.setDifficultyTimer(changeTimer(d));
            gameMatch.setMinimalJumps(changeMinJumps(d));
        }

        // Método de exibição do pnlReady
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

        // Método de exibição do pnlGame
        private void pnlGameFocus() {
            generateRandom();
            gameMatch.setCountdown(gameMatch.getDifficultyTimer());
            lblTimer.Text = "Tempo: " + gameMatch.getDifficultyTimer().ToString() + " segundos";
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

        // Método de exibição do pnlScore
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

        // Método de exibição do pnlFinish
        private void pnlFinishFocus() {
            if (player_1.getScore() > player_pc.getScore())
                lblWinner.Text = "E o ganhador foi: Jogador";
            else if (player_1.getScore() < player_pc.getScore())
                lblWinner.Text = "E o ganhador foi: Computador";
            else if (player_1.getScore() == player_pc.getScore())
                lblWinner.Text = "Houve um empate técnico";
            lblWinner.Location = new Point((pnlFinish.Width - lblWinner.Width)/2,12);
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

        // Procedimento de limpar os campos dos Objetos gameMatch, player_1 e player_pc
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

        // Função de alterar o tempo de acordo com a dificuldade
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
        
        // Função de alterar o mínimo de pulos de acordo com a dificuldade
        private byte changeMinJumps(string d) {
            byte minJumps;
            if (d == "Fácil")
                minJumps = 2;
            else if (d == "Moderado")
                minJumps = 3;
            else
                minJumps = 4;
            return minJumps;
        }

        // Procedimento para gerar aleatoriamente os dois fatores da multiplicação
        private void generateRandom() {
            Random random = new Random();
            gameMatch.setFactor1(random.Next(1, 10));
            gameMatch.setFactor2(random.Next(1, 10));
        }

        // Procedimento que controla o número de respostas certas para adicionar um pulo
        private void rightAnswController(bool op) {
            if (op == true) {
                player_1.setRightAnsw(player_1.getRightAnsw() + 1);
                if (player_1.getRightAnsw() == gameMatch.getMinimalJumps()) {
                    player_1.setJump(player_1.getJump() + 1);
                    player_1.setRightAnsw(0);
                }
            }
            else
                player_1.setRightAnsw(0);
        }

        // Função que controla os pulos
        private bool jumpController() {
            bool hasJump = false;
            if (player_1.getJump() >= 1) {
                hasJump = true;
                player_1.setJump(player_1.getJump() - 1);
            }
            return hasJump;
        }

        // Função para verificar o resultado que o jogador digitou
        private bool verifyResult() {
            bool isCorrect = false;
            if (gameMatch.getFactor1() * gameMatch.getFactor2() == player_1.getProduct())
                isCorrect = true;
            return isCorrect;
        }

        // Procedimento que chama o método de exibição do painel de pontuação
        private void showScore() {
            if (txtProduct.Text == "")
                MessageBox.Show("Digíte o resultado da multiplicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                player_1.setProduct(Convert.ToInt32(txtProduct.Text));
                timer1.Stop();
                pnlScoreFocus('v');
            }
        }

        // Método do temporizador regressivo
        private void timer1_Tick(object sender, EventArgs e) {
            gameMatch.setCountdown(gameMatch.getCountdown() - 1);
            if (gameMatch.getCountdown() == 0) {
                timer1.Stop();
                pnlScoreFocus('t');
            }
            lblTimer.Text = "Tempo: " + gameMatch.getCountdown() + " segundos";
        }

        // Evento de clicar no lblStartRound e lblContinue
        private void round_Click(object sender, EventArgs e) {
            pnlGameFocus();
            timer1.Enabled = true;
            timer1.Start();
        }

        // Evento de clicar no lblVerify
        private void lblVerify_Click(object sender, EventArgs e) {
            showScore();
        }

        // Evento de clicar no lblJump
        private void lblJump_Click(object sender, EventArgs e) {
            if (jumpController())
                pnlGameFocus();
            else
                MessageBox.Show("Você não possui pulos suficientes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Evento de clicar no lblFinishMatch
        private void lblFinishMatch_Click(object sender, EventArgs e) {
            DialogResult d = MessageBox.Show("Você tem certeza desta ação?", "Encerrar a partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.ToString() == "Yes")
                pnlFinishFocus();
        }

        // Evento de clicar no lblNewMatch
        private void lblNewMatch_Click(object sender, EventArgs e) {
            pnlReadyFocus();
        }

        // Evento de clicar no lblBackMenu e lblBackMenu1
        private void backMenu_Click(object sender, EventArgs e) {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        // Evento de pressionar tecla Enter e bloquear caracteres diferentes de dígitos no txtProduct
        private void verifyWithEnter(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 13)
                showScore();
        }

        // Evento de mover o cursor dos Labels clicaveis para alterar a cor para Azul-Aqua/Vermelho
        private void lblAquaRed_MouseMove(object sender, MouseEventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null) {
                if (someLabel.Name == "lblFinish" || someLabel.Name == "lblBackMenu" || someLabel.Name == "lblBackMenu1" || someLabel.Name == "lblFinishMatch")
                    someLabel.ForeColor = System.Drawing.Color.Red;
                else
                    someLabel.ForeColor = System.Drawing.Color.Aqua;
            }
        }

        // Evento de tirar o cursor dos Labels clicaveis para alterar a cor para Branco
        private void lblWhite_MouseLeave(object sender, EventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.White;
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