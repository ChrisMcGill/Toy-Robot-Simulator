using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{
    public class SimulatorTests
    {
        [Fact]
        public void RunValidSimulationA()
        {
            var mockWriter = new MockOutputWriter();
            var simulator = new Simulator(mockWriter);

            simulator.ExecuteCommand("PLACE 0,0,NORTH");
            simulator.ExecuteCommand("MOVE");
            simulator.ExecuteCommand("REPORT");

            Assert.Equal("0,1,NORTH", mockWriter.LastOutput);
        }

        [Fact]
        public void RunValidSimulationB()
        {
            var mockWriter = new MockOutputWriter();
            var simulator = new Simulator(mockWriter);

            simulator.ExecuteCommand("PLACE 1,2,EAST");
            simulator.ExecuteCommand("MOVE");
            simulator.ExecuteCommand("MOVE");
            simulator.ExecuteCommand("LEFT");
            simulator.ExecuteCommand("MOVE");
            simulator.ExecuteCommand("REPORT");

            Assert.Equal("3,3,NORTH", mockWriter.LastOutput);
        }

    }
}
