using bowling.Commands.Rolls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Commands.Frames {
    public class FrameCommand {
        public int Id { get; set; }
        public List<int> Rolls { get; set; }
    }

    public class FrameCommandHandler {
        private readonly RollCommandHandler rollHandler;
        public FrameCommandHandler() {
            rollHandler = new RollCommandHandler();

        }

        public int Handler(FrameCommand command) {

            for (var i = 0; i <= command.Rolls.Count - 2; i += 2) {
                if (i == 18) {
                    rollHandler(command.Rolls[i]
                }
            }

            return 0;
        }


    }


}

