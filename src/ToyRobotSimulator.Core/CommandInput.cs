namespace ToyRobotSimulator.Core
{
    public class CommandInput
    {
        private readonly Simulation simulation;
        private readonly IOutputWriter writer;

        public CommandInput(Simulation simulation, IOutputWriter writer)
        {
            this.simulation = simulation;
            this.writer = writer;
        }

        public ICommands Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new InvalidCommand(writer, $"Error: Empty input. Expected: PLACE X,Y,F");
            }

            var parts = input.Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0) return new InvalidCommand(writer, $"Error: Empty input. Expected: PLACE X,Y,F");

            switch (parts[0].ToUpper())
            {
                case "PLACE":
                    if (parts.Length == 4 &&
                        int.TryParse(parts[1], out int x) &&
                        int.TryParse(parts[2], out int y) &&
                        Enum.TryParse<Direction>(parts[3], true, out var dir))
                    {
                        return new PlaceCommand(simulation, new Position(x, y), dir);
                    }
                    return new InvalidCommand(writer, $"Error: Invalid PLACE command format. Expected: PLACE X,Y,F");

                case "MOVE":
                    return (parts.Length == 1)
                        ? new MoveCommand(simulation)
                        : new InvalidCommand(writer, "Error: MOVE command is not possible in this state.");
                case "LEFT":
                    return (parts.Length == 1)
                        ? new LeftCommand(simulation)
                        : new InvalidCommand(writer, "Error: LEFT command is not possible in this state.");
                case "RIGHT":
                    return (parts.Length == 1)
                        ? new RightCommand(simulation)
                        : new InvalidCommand(writer, "Error: RIGHT command is not possible in this state.");
                case "REPORT":
                    return (parts.Length == 1)
                        ? new ReportCommand(simulation, writer)
                        : new InvalidCommand(writer, "Error: REPORT command is not possible in this state.");
                default:
                    return new InvalidCommand(writer, $"Error: Unknown command '{parts[0]}'");
            }
        }
    }
}
