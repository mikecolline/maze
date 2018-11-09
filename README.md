# Solve a Maze

This application will take a maze string and display the most efficient path to the destination

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites

What things you need to install the software

Visual Studio 2017

.NetCore 1.1 Installtion instructions can be found here: https://www.microsoft.com/net/download/dotnet-core/1.1

Advanced REST Client, POSTMAN or similar API testing application for REST API services

### Instructions

To run this solution, clone this repository (https://github.com/mikecolline/maze) to your local desktop and open the .sln file in Visual Studio 2017.

Build the solution by right clicking on the MazeApi Solution in Solution Explorer and selecting Build

#### Run Unit Tests

Select Menu Item Test then Windows then Test Explorer

In Test Explorer window click Run All

#### Run Application 

Press F5 to run and debug the solution.

Start Advanced REST Client application

Set the Method to POST

Set Request URL to http://localhost:55660/MazeApi/solveMaze

Set Header Content type to application/json

Set Body Content type to application/json

Copy contents of Maze1.txt and paste in Raw Body field surrounding the contents by quotes (").

Press the Send button

Expected JSON Results are "{
"steps": 14,
"solution": "########## #A@@@#...# #.#@##.#.# #.#@##@#.# #.#@@@@#B# #.#.##@#@# #....#@@@# ##########"
}
"

Repeat by replacing Raw Body contents with Maze2.txt (surrounded by quotes) and pressing Send button

Repeat by replacing Raw Body contents with Maze3.txt (surrounded by quotes) and pressing Send button

