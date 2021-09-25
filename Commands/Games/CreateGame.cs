using bowling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Commands.Games {
    public class CreateGame {
        //private readonly ...
        public CreateGame() {

        }

        public Game CreateGameHandler() {



            return new Game() {
                Id = 0,
                TotalScore = 0,
                Players = new List<Player>(),
            };
        }
    }
}
