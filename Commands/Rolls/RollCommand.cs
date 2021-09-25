using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Commands.Rolls {
    public class RollCommand {
        public int Id { get; set; }
        public List<int> RollScores { get; set; }
        public List<int> NextFrameRolls { get; set; }
    }

    public class RollCommandHandler {

        public int Handler(RollCommand command) {
            var totalForBothRolls = command.RollScores.Aggregate(0, (total, next) => total += next);

            if (command.RollScores[0] == 10) {
                return CalculateStrikeScore(totalForBothRolls, command.NextFrameRolls[0], command.NextFrameRolls[1]);
            }
            else if (totalForBothRolls == 10) {
                return CalculateSpareScore(totalForBothRolls, command.NextFrameRolls[0]);
            }
            //if it does not include rolls from the next frame
            return totalForBothRolls;
        }

        public int CalculateStrikeScore(int a, int b, int c) {
            return a + b + c;
        }

        public int CalculateSpareScore(int a, int b) {
            return a + b;
        }

    }

    
}
