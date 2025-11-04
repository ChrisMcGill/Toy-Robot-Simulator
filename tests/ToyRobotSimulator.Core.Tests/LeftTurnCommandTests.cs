using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class LeftTurnCommandTests
    {
        [Fact]
        public void PlacedRoverTurns()
        {
            var simulation = new Simulation();
            new PlaceCommand(simulation,new Position(0,0), Direction.NORTH).Execute();

            var leftCommand = new LeftCommand(simulation);

            leftCommand.Execute();

            Assert.Equal(Direction.WEST, simulation.Rover.Direction);
        }

        [Fact]
        public void UnplacedRoverDoesntTurn()
        {
            var simulation = new Simulation();

            var leftCommand = new LeftCommand(simulation);

            leftCommand.Execute();

            Assert.False(simulation.Rover.IsPlaced);
        }
    }
}
