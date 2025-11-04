# Toy Robot Simulator
This is a solution for a Toy Robot Simulator, implemented in C# and.NET.

Overview

The application simulates a toy robot moving on a 5x5 tabletop. The robot can be placed, moved, and rotated, whilst also prevented from falling off the table
The application accepts the following commands:
PLACE X,Y,F (e.g., PLACE 0,0,NORTH)
MOVE
LEFT
RIGHT
REPORT

Test-Driven Development (TDD): The entire core logic was built using a test-first approach. The solution has 100% unit test coverage for all business logic, boundary conditions, and command parsing.


## How to Build and Run

### Prerequisites
.NET SDK (This solution was built with.NET 8)

### 1. Build the Solution
From the root directory, run:
dotnet build

### 2. Run Tests
To run the full suite of unit and integration tests:
dotnet test

### 3. Run the Application (Interactive Mode)
This will launch the app and you can type commands manually.
dotnet run --project src/ToyRobotSimulator.ConsoleApp/ToyRobotSimulator.ConsoleApp.csproj
A typical input will look something like this:
Toy Robot Simulator
Enter commands (or 'EXIT' to quit):
> PLACE 0,0,NORTH
> MOVE
> REPORT
0,1,NORTH
> LEFT
> REPORT
0,0,WEST
> JUMP
Error: Unknown command 'JUMP'
> EXIT
*(Type `EXIT` to quit)*

### 4. Run the Application (File Mode)
This will run the provided `testdata.txt` file and print all the reports.
dotnet run --project src/ToyRobotSimulator.ConsoleApp/ToyRobotSimulator.ConsoleApp.csproj testdata.txt
The test data file can be modified and run to test as many test cases as you would like. 

Happy Roaming :)
⠀⠀⠀⠀⠀⢀⣤⣶⣶⣤⡀⠀⠀⢀⣤⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣷⣶⣶⣿⣿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢀⣼⣿⣿⣿⡿⠋⠉⠉⠙⢿⣷⡶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣠⣴⣶⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢸⣿⣿⣿⣿⣧⠀⠀⠀⢀⣤⣶⣾⣿⣿⣿⣿⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠘⢿⣿⣿⣿⡇⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠉⠉⠻⣿⣦⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣄⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢸⣿⠏⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⢹⣿⡆⠀⠀⠀
⠀⠀⠀⢀⣤⣾⣿⣤⣀⠀⠀⠀⣀⣤⣤⣤⣤⡀⠀⠀⠀⣠⣼⣿⣧⣄⡀⠀
⠀⠀⣰⣿⣿⣿⣿⣿⣿⣧⠀⣼⣿⣿⣿⣿⣿⣿⣆⠀⣾⣿⣿⣿⣿⣿⣿⡄
⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣶⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⡇
⠀⠀⠘⢿⣿⣿⣿⣿⣿⠟⠉⠹⣿⣿⣿⣿⣿⣿⠋⠉⢻⣿⣿⣿⣿⣿⡿⠁
⠀⠀⠀⠀⠉⠛⠛⠋⠀⠀⠀⠀⠀⠙⠛⠛⠉⠀⠀⠀⠀⠈⠙⠛⠛⠉⠀⠀

