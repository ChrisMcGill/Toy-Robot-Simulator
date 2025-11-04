using ToyRobotSimulator.Core;
using Xunit;


namespace ToyRobotSimulator.Core.Tests
{
    public class CommandInputTests
    {
        private readonly CommandInput commandInput;
        private readonly Simulation simulation;
        private readonly MockOutputWriter mockWriter;

        public CommandInputTests() 
        {
            this.simulation = new Simulation();
            this.mockWriter = new MockOutputWriter();
            this.commandInput = new CommandInput(this.simulation, this.mockWriter);
        }

        [Fact]
        public void MoveInput()
        {
            var command = commandInput.Parse("MOVE");
            Assert.IsType<MoveCommand>(command);
        }

        [Fact]
        public void LeftInput()
        {
            var command = commandInput.Parse("LEFT");
            Assert.IsType<LeftCommand>(command);
        }

        [Fact]
        public void RightInput()
        {
            var command = commandInput.Parse("RIGHT");
            Assert.IsType<RightCommand>(command);
        }

        [Fact]
        public void InvalidInput()
        {
            var command = commandInput.Parse("INVALID");
            Assert.IsType<InvalidCommand>(command);
        }

        [Fact]
        public void ValidPlace()
        {
            var command = commandInput.Parse("PLACE 1,2,NORTH");
            Assert.IsType<PlaceCommand>(command);

            command.Execute();
            Assert.Equal(new Position(1, 2), simulation.Rover.Position);
            Assert.Equal(Direction.NORTH, simulation.Rover.Direction);
        }

        [Theory]
        [InlineData("PLACE 1,2")]
        [InlineData("PLACE 1")]
        [InlineData("PLACE X,Y,NORTH")]
        [InlineData("PLACE 1,1,INVALID")]
        [InlineData("MOVE 123")]
        [InlineData("LEFT RIGHT")]
        public void InvalidPlace(string tryPlace)
        {
            var command = commandInput.Parse(tryPlace);
            Assert.IsType<InvalidCommand>(command);
        }

    }
}
