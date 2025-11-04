using System.Security.Cryptography;

namespace ToyRobotSimulator.Core
{
    public class Rover
    {
        public bool IsPlaced { get; private set; } = false;
        public Position Position { get; private set; }
        public Direction Direction { get; private set; }

        public void Place(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
            this.IsPlaced = true;
        }

        public void TurnLeft()
        {
            if (IsPlaced)
            {
                this.Direction = this.Direction.TurnLeft();
            }
        }

        public void TurnRight()
        {
            if (IsPlaced)
            {
                this.Direction = this.Direction.TurnRight();
            }
        }

        public Position GetNextPosition()
        {
            if (!IsPlaced) return default;

            return Direction switch
            {
                Direction.NORTH => Position with { Y = Position.Y + 1 },
                Direction.EAST => Position with { X = Position.X + 1 },
                Direction.SOUTH => Position with { Y = Position.Y - 1 },
                Direction.WEST => Position with { X = Position.X - 1 },
                _ => throw new NotImplementedException(),
            };
        }

        public string Report()
        {
            if (!IsPlaced) return "Rover has not been placed";

            return $"{Position.X},{Position.Y},{Direction}";
        }
    }
}
