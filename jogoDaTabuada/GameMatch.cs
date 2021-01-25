using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaTabuada {
    public class GameMatch {
        private string difficulty;
        private int diffTimer;
        private int countdown;
        private byte minAnsw;
        private int factor1;
        private int factor2;
        private int rounds;

        public string getDifficulty() {
            return difficulty;
        }

        public void setDifficulty(string difficulty) {
            this.difficulty = difficulty;
        }

        public int getDiffTimer() {
            return diffTimer;
        }

        public void setDiffTimer(int diffTimer) {
            this.diffTimer = diffTimer;
        }

        public int getCountdown() {
            return countdown;
        }

        public void setCountdown(int countdown) {
            this.countdown = countdown;
        }

        public int getMinAnsw() {
            return minAnsw;
        }

        public void setMinAnsw(byte minAnsw) {
            this.minAnsw = minAnsw;
        }

        public int getFactor1() {
            return factor1;
        }

        public void setFactor1(int factor1) {
            this.factor1 = factor1;
        }

        public int getFactor2() {
            return factor2;
        }

        public void setFactor2(int factor2) {
            this.factor2 = factor2;
        }

        public int getRounds() {
            return rounds;
        }

        public void setRounds(int round) {
            this.rounds = round;
        }
    }
}