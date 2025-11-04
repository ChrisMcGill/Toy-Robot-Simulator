using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class ReportCommandTests
    {
        [Fact]
        public void ReportOnValidPosition()
        {
            var simulation = new Simulation();
            var mockWriter = new MockOutputWriter();

            new PlaceCommand(simulation, new Position(0, 0), Direction.NORTH).Execute();
            var command = new ReportCommand(simulation, mockWriter);

            command.Execute();

            Assert.Equal("0,0,NORTH", mockWriter.LastOutput);

        }

        [Fact]
        public void ReportOnNotValidPosition()
        {
            var simulation = new Simulation();
            var mockWriter = new MockOutputWriter();
            var command = new ReportCommand(simulation, mockWriter);

            command.Execute();

            Assert.Null(mockWriter.LastOutput);
        }
    }
}
