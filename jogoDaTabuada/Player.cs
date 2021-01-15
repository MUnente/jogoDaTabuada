using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaTabuada {
    public class Player {
        private int product;
        private int score;
        private int jump;
        private int jumpsControl;
        private static Player player;

        // Singleton Design Pattern
        private Player() {
        }

        public static Player getInstance() {
            if (player == null)
                player = new Player();
            return player;
        }

        public static Player finishInstance() {
            player = null;
            return player;
        }

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

        public int getJumpsControl() {
            return jumpsControl;
        }

        public void setJumpsControl(int jumpsControl) {
            this.jumpsControl = jumpsControl;
        }
    }
}