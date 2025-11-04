namespace ToyRobotSimulator.Core
{
    public class Simulator
    {
        private readonly Simulation simulation;
        private readonly CommandInput commandInput;

        public Simulator(IOutputWriter writer)
        {
            simulation = new Simulation();
            commandInput = new CommandInput(simulation, writer);
        }

        public void ExecuteCommand(string tryCommand)
        {
            var command = commandInput.Parse(tryCommand);
            command.Execute();
        }

    }
}
