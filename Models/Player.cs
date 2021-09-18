using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Models {
    public class Player : Person {
        public int PlayerId { get; set; }
        public IEnumerable<Frame> Frames { get; set; }
      
    }
}
