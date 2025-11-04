namespace ToyRobotSimulator.Core
{
    public class RightCommand : ICommands
    {
        private readonly Simulation simulation;

        public RightCommand(Simulation simulation)
        {
            this.simulation = simulation;
        }

        public void Execute()
        {
            simulation.Rover.TurnLeft();
        }
    }
}