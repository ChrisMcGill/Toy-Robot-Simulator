using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class PlaceCommandTests
    {
        [Fact]
        public void CommandAndValidPosition()
        {
            var simulation = new Simulation();
            var command = new PlaceCommand(simulation, new Position(3, 4), Direction.NORTH);

            command.Execute();

            Assert.True(simulation.Rover.IsPlaced);
            Assert.Equal(new Position(3, 4), simulation.Rover.Position);
        }

        [Fact]
        public void CommandAndNotValidPosition()
        {
            var simulation = new Simulation();
            // test will only work if boundary is 5x5 grid or less
            var command = new PlaceCommand(simulation, new Position(5, 5), Direction.NORTH);

            command.Execute();

            Assert.False(simulation.Rover.IsPlaced);
        }
    }
}
