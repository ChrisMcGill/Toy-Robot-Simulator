namespace ToyRobotSimulator.Core
{
    public class MoveCommand: ICommands
    {
        private readonly Simulation simulation;

        public MoveCommand(Simulation simulation)
        {
            this.simulation = simulation;
        }

        public void Execute() 
        {
            if (!simulation.Rover.IsPlaced) return;

            var nextPosition = simulation.Rover.GetNextPosition();
            if (simulation.Boundary.IsValidPosition(nextPosition))
            {
                simulation.Rover.Place(nextPosition, simulation.Rover.Direction);
            } 
        }
    }
}
