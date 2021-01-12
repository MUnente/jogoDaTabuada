using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaTabuada {
    public class Game {
        private string difficulty;
        private int time;
        private short minimalJumps;
        private static Game game;

        // Singleton Design Pattern
        private Game() {
        }

        public static Game getInstance() {
            if (game == null)
                game = new Game();
            return game;
        }

        public string getDifficulty() {
            return difficulty;
        }

        public void setDifficulty(string difficulty) {
            this.difficulty = difficulty;
        }

        public int getTime() {
            return time;
        }

        public void setTime(int time) {
            this.time = time;
        }

        public int getMinimalJumps() {
            return minimalJumps;
        }

        public void setMinimalJumps(short minimalJumps) {
            this.minimalJumps = minimalJumps;
        }
    }
}