using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Models {
    public class Game {
        public int Id { get; set; }
        public int TotalScore { get; set; }
        public IList<Player> Players { get; set; }
    }
}
