using System.Xml;

namespace ToyRobotSimulator.Core
{
    public class ReportCommand: ICommands
    {
        private readonly Simulation simulation;
        private readonly IOutputWriter writer;

        public ReportCommand(Simulation simulation, IOutputWriter writer)
        {
            this.simulation = simulation;
            this.writer = writer;
        }

        public void Execute()
        {
            if (simulation.Rover.IsPlaced) 
            {
                writer.WriteLine(simulation.Rover.Report());
            }
        }
    }
}
