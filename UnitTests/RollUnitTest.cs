using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bowling.UnitTests
{
    public class RollTest
    {
    [RollTestMethod]
    public void RollTestMethod()
    {
        var roll = new Roll();

        int result = Roll.RollScores.Roll1(4) + Roll.RollScores.Roll2(5);

        Assert.AreEqual(9, result);
    }
}
}