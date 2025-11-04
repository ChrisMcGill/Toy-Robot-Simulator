using System;
using System.IO;
using ToyRobotSimulator.Core;

namespace ToyRobotSimulator.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var writer = new ConsoleOutputWriter();

            var simulator = new Simulator(writer);

            // Able to interact with either a file input or interaction
            if (args.Length > 0)
            {
                var filePath = args[0];
                if (File.Exists(filePath))
                {
                    var commands = File.ReadAllLines(filePath);
                    foreach (var command in commands)
                    {
                        simulator.ExecuteCommand(command);
                    }
                }
                else
                {
                    Console.WriteLine($"Error: File not found at {filePath}");
                }
            }
            else
            {
                Console.WriteLine("Toy Robot Simulator");
                Console.WriteLine("Enter commands (or 'EXIT' to quit):");

                string? input;
                while ((input = Console.ReadLine()) != null &&
                        input.ToUpper() != "EXIT")
                {
                    simulator.ExecuteCommand(input);
                }
            }
        }
    }
}
