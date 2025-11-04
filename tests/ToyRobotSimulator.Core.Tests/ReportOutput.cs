using ToyRobotSimulator.Core;
using Xunit;

namespace ToyRobotSimulator.Core.Tests
{ 
    public class MockOutputWriter : IOutputWriter
    {
        public string? LastOutput { get; private set; }

        public void WriteLine(string message)
        {
            LastOutput = message;
        }
    }
}
