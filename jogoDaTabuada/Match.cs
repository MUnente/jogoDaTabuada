using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaTabuada {
    public class Match {
        private string difficulty; // regras da partida
        private int difficultyTimer; // regras da partida
        private int countdown;
        private short minimalJumps; // regras da partida
        private int factor1;
        private int factor2;
        private int rounds;

        public string getDifficulty() {
            return difficulty;
        }

        public void setDifficulty(string difficulty) {
            this.difficulty = difficulty;
        }

        public int getDifficultyTimer() {
            return difficultyTimer;
        }

        public void setDifficultyTimer(int diffTimer) {
            this.difficultyTimer = diffTimer;
        }

        public int getCountdown() {
            return countdown;
        }

        public void setCountdown(int countdown) {
            this.countdown = countdown;
        }

        public int getMinimalJumps() {
            return minimalJumps;
        }

        public void setMinimalJumps(short minimalJumps) {
            this.minimalJumps = minimalJumps;
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