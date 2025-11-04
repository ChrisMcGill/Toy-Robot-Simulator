using System.ComponentModel.DataAnnotations.Schema;
using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class BoundaryTests
    {
        [Fact]
        public void IsAValidPosition()
        {
            var boundary = new Boundary();
            var position = new Position();
            Assert.True(boundary.IsValidPosition(position));
        }

        private readonly Boundary _boundary = new Boundary();
        //Positions are like indexes, so (5,5) means x/y = 6 = out of bounds
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, -1)]
        [InlineData(5, 0)]
        [InlineData(0, 5)]
        [InlineData(5, 5)]
        public void IsNotAValidPosition(int x, int y)
        {
            var position = new Position { X = x, Y = y };
            Assert.False(_boundary.IsValidPosition(position));
        }
    }
}
