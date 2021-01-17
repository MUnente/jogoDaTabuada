using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaTabuada {
    public class Player {
        private int product;
        private int score;
        private int jump;
        private int rightAnsw;

        public int getProduct() {
            return product;
        }

        public void setProduct(int product) {
            this.product = product;
        }

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

        public int getRightAnsw() {
            return rightAnsw;
        }

        public void setRightAnsw(int rightAnsw) {
            this.rightAnsw = rightAnsw;
        }
    }
}