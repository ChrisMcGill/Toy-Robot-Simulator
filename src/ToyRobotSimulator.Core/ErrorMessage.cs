namespace ToyRobotSimulator.Core
{
    public class InvalidCommand : ICommands
    {
        private readonly IOutputWriter _writer;
        private readonly string _errorMessage;

        public InvalidCommand(IOutputWriter writer, string errorMessage)
        {
            _writer = writer;
            _errorMessage = errorMessage;
        }

        public void Execute()
        {
            _writer.WriteLine(_errorMessage);
        }
    }
}