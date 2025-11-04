using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class MoveCommandTests
    {
        [Fact]
        public void ValidMove()
        {
            var simulation = new Simulation();
            new PlaceCommand(simulation, new Position(0, 0), Direction.NORTH).Execute();

            var moveCommand = new MoveCommand(simulation);
            moveCommand.Execute();

            Assert.Equal(new Position(0, 1), simulation.Rover.Position);
        }

        [Fact]
        public void OutOfBoundsMove()
        {
            var simulation = new Simulation();
            new PlaceCommand(simulation, new Position(0,0),Direction.SOUTH).Execute();

            var moveCommand = new MoveCommand(simulation);
            moveCommand.Execute();

            Assert.Equal(new Position(0, 0), simulation.Rover.Position);
        }
    }
}
