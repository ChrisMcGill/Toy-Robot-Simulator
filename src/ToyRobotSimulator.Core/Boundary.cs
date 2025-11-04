namespace ToyRobotSimulator.Core
{
    public class Boundary
    {
        private readonly int width = 5;
        private readonly int height = 5;

        public bool IsValidPosition(Position position)
        {
            return (position.X >= 0) && (position.Y >= 0) && (position.X < width) && (position.Y < height);
        }
    }
}
