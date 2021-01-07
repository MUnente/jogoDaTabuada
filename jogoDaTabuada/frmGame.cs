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
    public partial class frmGame : Form {
        public frmGame() {
            InitializeComponent();
        }

        private void lblMouseMove(object sender, MouseEventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null) {
                if (someLabel.Name == "lblFinish")
                    someLabel.ForeColor = System.Drawing.Color.Red;
                else
                    someLabel.ForeColor = System.Drawing.Color.Aqua;
            }
        }

        private void lblMouseLeave(object sender, EventArgs e) {
            Label someLabel = sender as Label;
            if (someLabel != null)
                someLabel.ForeColor = System.Drawing.Color.White;
        }

        private void lblFinish_Click(object sender, EventArgs e) {
            this.Close();
            frmMenu menu = new frmMenu();
            menu.Show();
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
