using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoDaTabuada {
    public partial class FormGame : Form {
        public FormGame(string diff) {
            InitializeComponent();
            frmLoad(diff);
        }

        private void frmLoad(string d) {
            pnlReadyFocus();
            Game game = Game.getInstance();
            game.setDifficulty(d);
            game.setTime(changeTimer(d));
            game.setMinimalJumps(changeMinJumps(d));
        }

        private int changeTimer(string d) {
            int timer;
            if (d == "easy")
                timer = 15;
            else if (d == "medium")
                timer = 10;
            else
                timer = 5;
            return timer;
        }

        private short changeMinJumps(string d) {
            short minJumps;
            if (d == "easy")
                minJumps = 2;
            else if (d == "medium")
                minJumps = 3;
            else
                minJumps = 4;
            return minJumps;
        }

        private void pnlReadyFocus() {
            pnlScore.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = false;
            pnlReady.Visible = true;
        }

        private void pnlGameFocus() {
            pnlReady.Visible = false;
            pnlScore.Visible = false;
            pnlFinish.Visible = false;
            pnlGame.Visible = true;
        }

        private void pnlScoreFocus() {
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

        private void startMatch_Click(object sender, EventArgs e) {
            pnlGameFocus();
            
        }

        private void continueGame_Click(object sender, EventArgs e) {
            pnlGameFocus();
        }

        private void verify_Click(object sender, EventArgs e) {
            // Finalizar round e verificar se o usuário acertou (pnlScore)
        }

        private void jump_Click(object sender, EventArgs e) {
            // Pular questão
        }

        private void finishMatch_Click(object sender, EventArgs e) {
            // Voltar para o pnlStartFinish
        }

        private void backMenu_Click(object sender, EventArgs e) {
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void lblAquaRed_MouseMove(object sender, MouseEventArgs e) {
            Label someLabel = sender as Label;
            //PictureBox somePic = sender as PictureBox;
            if (someLabel != null) {
                if (someLabel.Name == "lblFinish" || someLabel.Name == "lblBackMenu" || someLabel.Name == "lblBackMenu1")
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