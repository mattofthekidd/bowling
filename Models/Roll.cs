using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.Models {
    //track individual rolls for a frame
    //and also track the total for all roles
    public class Roll {
        public int Id { get; set; }
        public int FinalFrameScore { get; set; }



        // normal case 0...2, edge case 0...3
        //roll 3 will be 0 for all but the tenth frame in our edge case
        public IEnumerable<(int Roll1, int Roll2, int Roll3)> RollScores { get; set; }

        //10 total frames, each frame contains the value rolled for that frame
        //the actual score per frame is handled by back-end code
        public IEnumerable<int> ScoresPerFrame { get; set; }


        //Total scores per frame, calculated values
        //public IEnumerable<int> TotalScores { get; set; }
    }
}
