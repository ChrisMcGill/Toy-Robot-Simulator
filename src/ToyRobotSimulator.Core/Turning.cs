namespace ToyRobotSimulator.Core
{
    public static class Turning
    {
        public static Direction TurnLeft(this Direction cardinal)
        {
            return (Direction)((((int)cardinal - 1) + 4) % 4);
        }

        public static Direction TurnRight(this Direction cardinal)
        {
            return (Direction)(((int)cardinal + 1) % 4);
        }
    }
}
