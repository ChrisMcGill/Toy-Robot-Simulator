using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class RoverTests
    {
        [Fact]
        public void RoverNotPlaced()
        {
            var rover = new Rover();
            Assert.False(rover.IsPlaced);
        }

        [Fact]
        public void RoverPlaced()
        {
            var rover = new Rover();
            var position = new Position(0, 0);
            var direction = Direction.NORTH;

            rover.Place(position, direction);

            Assert.True(rover.IsPlaced);
            Assert.Equal(position, rover.Position);
            Assert.Equal(direction, rover.Direction);
        }

        [Fact]
        public void IgnoreIfNotPlaced()
        {
            var rover = new Rover();
            var initialDirection = Direction.NORTH;
            rover.TurnLeft();
            Assert.False(rover.IsPlaced);
            Assert.Equal(initialDirection, rover.Direction);
        }

        [Fact]
        public void AcceptsIfPlaced()
        {
            var rover = new Rover();
            rover.Place(new Position(0, 0), Direction.NORTH);
            rover.TurnLeft();
            Assert.Equal(Direction.WEST, rover.Direction);
        }

        [Fact]
        public void DeclarePosition()
        {
            var rover = new Rover();
            rover.Place(new Position(3, 4), Direction.WEST);
            Assert.Equal("3,4,WEST", rover.Report());
        }

        [Fact]
        public void EmptyDeclarationIfNotPlaced()
        {
            var rover = new Rover();
            Assert.Equal("Rover has not been placed", rover.Report());
        }

        [Fact]
        public void CheckNextPosition()
        {
            var rover = new Rover();
            rover.Place(new Position(0, 0), Direction.NORTH);

            var nextPosition = rover.GetNextPosition();
            Assert.Equal(new Position(0, 1), nextPosition);
        }
    }
}
