namespace ToyRobotSimulator.Core
{
    public class LeftCommand : ICommands 
    { 
        private readonly Simulation simulation;

        public LeftCommand(Simulation simulation)
        {
            this.simulation = simulation;
        }

        public void Execute()
        {
            simulation.Rover.TurnLeft();
        }
    }
}