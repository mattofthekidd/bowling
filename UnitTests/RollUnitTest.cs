using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bowling.Commands.Rolls;
using FizzWare.NBuilder;
using Xunit;

namespace bowling.UnitTests {
	public class RollTest {
		private readonly RollCommandHandler _sut;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sut"></param>
		public RollTest(RollCommandHandler sut) {
			_sut = sut;
		}

		[Fact]
		public void RollSpareTest() {
			TestSetup();
			var rollScores = new List<int> { 1, 9 };
			var nextFrameRolls = new List<int> { 4, 0 };

			var command = Builder<RollCommand>.CreateNew()
				.With(x => x.Id = 1)
				.With(x => x.RollScores = rollScores)
				.With(x => x.NextFrameRolls = nextFrameRolls)
				.Build();

			int result = _sut.Handler(command);

			Assert.Equal(14, result);
		}


		public void TestSetup() {
			//this is where db mocks would go
		}
	}
}