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

        // Evento para exibir o painel de dificuldade
        private void lblPlay_Click(object sender, EventArgs e) {
            pnlMenu.Visible = false;
            pnlHTP.Visible = false;
            pnlDifficulty.Visible = true;
        }

        // Evento para exibir o painel de como jogar
        private void lblHowToPlay_Click(object sender, EventArgs e) {
            pnlMenu.Visible = false;
            pnlDifficulty.Visible = false;
            pnlHTP.Visible = true;
        }

        // Evento para voltar ao menu principal
        private void lblBack_Click(object sender, EventArgs e) {
            pnlHTP.Visible = false;
            pnlDifficulty.Visible = false;
            pnlMenu.Visible = true;
        }

        // Evento para inciar o form do jogo
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
                frmGame.Show();
                this.Hide();
            }
        }

        // Evento de mover o cursor dos Labels clicaveis para alterar a cor para Azul-Aqua
        private void lblMouseMove(object sender, MouseEventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.Aqua;
        }

        // Evento de tirar o cursor dos Labels clicaveis para alterar a cor para Branco
        private void lblMouseLeave(object sender, EventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.White;
        }

        // Método para sair do game quando clicar no X
        protected override void OnFormClosing(FormClosingEventArgs e) {
            DialogResult res = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.ToString() == "Yes")
                Application.Exit();
            else
                e.Cancel = true;
        }
    }
}