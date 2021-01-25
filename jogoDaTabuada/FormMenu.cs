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
    public partial class FormMenu : Form {
        public FormMenu() {
            InitializeComponent();
        }

        private void lblPlay_Click(object sender, EventArgs e) {
            pnlMenu.Visible = false;
            pnlHTP.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void lblHowToPlay_Click(object sender, EventArgs e) {
            pnlMenu.Visible = false;
            pnlDifficulty.Visible = false;
            pnlHTP.Visible = true;
            txtRules.Enabled = true;
            txtRules.SelectionLength = 0;
        }

        private void lblBack_Click(object sender, EventArgs e) {
            pnlHTP.Visible = false;
            pnlDifficulty.Visible = false;
            pnlMenu.Visible = true;
        }

        private void lblStartGame_Click(object sender, EventArgs e) {
            if (rdbEasy.Checked == false && rdbMedium.Checked == false && rdbHard.Checked == false)
                MessageBox.Show("Por favor, amigão, selecione um dos níveis de dificuldade para começar a partida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                string difficulty;
                if (rdbEasy.Checked)
                    difficulty = "Fácil";
                else if (rdbMedium.Checked)
                    difficulty = "Moderado";
                else
                    difficulty = "Difícil";
                FormGame frmGame = new FormGame(difficulty);
                this.Hide();
                frmGame.Show();
            }
        }

        private void lblMouseMove(object sender, MouseEventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.Aqua;
        }

        private void lblMouseLeave(object sender, EventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.White;
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                DialogResult res = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res.ToString() == "Yes")
                    Environment.Exit(0);
                else
                    e.Cancel = true;
            }
            else {
                e.Cancel = true;
            }
        }
    }
}