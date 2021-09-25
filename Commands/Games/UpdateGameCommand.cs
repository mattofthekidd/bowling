using bowling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Commands.Games {
    public class UpdateGameCommand {

        public UpdateGameCommand() { }

        public Game UpdateGameHandler(int id, List<Player> players) {




            return new Game();
        }

        public int TotalScore(List<Player> players) {
            for(var i = 0; i < players.Count; i++) {
                for(var j = 0; j < players[i].Frames.Count; j++) {
                    for(var k = 0; k < players[i].Frames[j].Rolls.Count; k++) {

                    }
                }
            }


            return 0;
        }

    }
}
