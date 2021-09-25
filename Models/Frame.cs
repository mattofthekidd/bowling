using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Models {
    public class Frame {
        public int FrameId { get; set; }
        public int FrameScore { get; set; }
        public IList<Roll> Rolls { get; set; } //

    }
}
