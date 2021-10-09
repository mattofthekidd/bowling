//using bowling.Models;
//using FizzWare.NBuilder;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Xunit;

//namespace bowling.Commands.Games {
//    public class UpdateGameUnitTest {
//        private readonly UpdateGameCommand _sut;

//        public UpdateGameUnitTest() {
//            _sut = new UpdateGameCommand();
//        }

//        public void Init() {
//            var rolls = Builder<Roll>.CreateListOfSize(2).All()
//                .With(x => x.RollScores = new List<(int, int, int)>() { (0, 1, 2), (3, 5, 7) })
//                .With(x => x.ScoresPerFrame)
//                .With(x => x.TotalScores)
//                .Build().ToList();


//            var frames = Builder<Frame>.CreateListOfSize(2).All()
//                .With(x => x.Rolls)
//                .Build().ToList();

//            var players = Builder<Player>.CreateListOfSize(2).All()
//                .With(x => x.Frames = frames)
//                .Build().ToList();
//        }

//        [Fact]
//        public void TotalScoreTest() {
//            var result = _sut.TotalScore();

//            Assert.Equal(0, result);

//        }

//    }
//}
