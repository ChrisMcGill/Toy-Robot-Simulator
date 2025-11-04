using System;
using ToyRobotSimulator.Core;

namespace ToyRobotSimulator.ConsoleApp
{
    public class ConsoleOutputWriter: IOutputWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
