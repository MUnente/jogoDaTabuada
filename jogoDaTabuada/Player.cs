using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaTabuada {
    public class Player {
        private int score;
        private int jump;
        private int jumpsControl;

        public int getScore() {
            return score;
        }

        public void setScore(int score) {
            this.score = score;
        }

        public int getJump() {
            return jump;
        }

        public void setJump(int jump) {
            this.jump = jump;
        }

        public int getJumpsControl() {
            return jumpsControl;
        }

        public void setJumpsControl(int jumpsControl) {
            this.jumpsControl = jumpsControl;
        }
    }
}