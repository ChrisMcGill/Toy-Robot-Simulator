namespace ToyRobotSimulator.Core
{
    public class PlaceCommand: ICommands
    {
        private readonly Simulation simulation;
        private readonly Position position;
        private readonly Direction direction;

        public PlaceCommand(Simulation simulation, Position position, Direction direction)
        {
            this.simulation = simulation;
            this.position = position;
            this.direction = direction;
        }

        public void Execute()
        {
            if (simulation.Boundary.IsValidPosition(position))
            {
                simulation.Rover.Place(position,direction);
            }
        }
    }
}
