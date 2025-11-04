using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class DirectionTests
    {
        [Fact]
        public void TurnLeftRotatesProperly()
        {
            var start = Direction.NORTH;

            var oneTurn = start.TurnLeft();
            var twoTurn = start.TurnLeft().TurnLeft();
            var threeTurn = start.TurnLeft().TurnLeft().TurnLeft();
            var fourTurn = start.TurnLeft().TurnLeft().TurnLeft().TurnLeft();
            
            Assert.Equal(Direction.WEST, oneTurn);
            Assert.Equal(Direction.SOUTH, twoTurn);
            Assert.Equal(Direction.EAST, threeTurn);
            Assert.Equal(Direction.NORTH, fourTurn);
        }

        [Fact]
        public void TurnRightRotatesProperly()
        {
            var start = Direction.NORTH;

            var oneTurn = start.TurnRight();
            var twoTurn = start.TurnRight().TurnRight();
            var threeTurn = start.TurnRight().TurnRight().TurnRight();
            var fourTurn = start.TurnRight().TurnRight().TurnRight().TurnRight();

            Assert.Equal(Direction.EAST, oneTurn);
            Assert.Equal(Direction.SOUTH, twoTurn);
            Assert.Equal(Direction.WEST, threeTurn);
            Assert.Equal(Direction.NORTH, fourTurn);
        }
    }
}