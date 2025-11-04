using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class RightTurnCommandTests
    {
        [Fact]
        public void PlacedRoverTurns()
        {
            var simulation = new Simulation();
            new PlaceCommand(simulation, new Position(0, 0), Direction.NORTH).Execute();

            var rightCommand = new RightCommand(simulation);

            rightCommand.Execute();

            Assert.Equal(Direction.WEST, simulation.Rover.Direction);
        }

        [Fact]
        public void UnplacedRoverDoesntTurn()
        {
            var simulation = new Simulation();

            var rightCommand = new RightCommand(simulation);

            rightCommand.Execute();

            Assert.False(simulation.Rover.IsPlaced);
        }
    }
}
