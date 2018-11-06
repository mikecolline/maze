# Solve a Maze

This application will take a maze string and display the most efficient path to the destination

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites

What things you need to install the software and how to install them

Visual Studio 2017

Advanced Rest Client, POSTMAN or similar API testing application for REST API services

### Instructions

To run this solution, clone this repository to your local desktop and open the .sln file in Visual Studio 2017.

Press F5 to run and debug the solution.

Start Advanced Rest Client application

Set the Method to POST

Set Request URL to http://localhost:55660/MazeApi/solveMaze

Set Body Content type to application/json

Copy contents of Maze1.txt and paste in Raw Body field surrounding the contents by quotes (").

Press the Send button

Expected JSON Results are "{
"steps": 14,
"solution": "########## #A@@@#...# #.#@##.#.# #.#@##@#.# #.#@@@@#B# #.#.##@#@# #....#@@@# ##########"
}
"

Repeat by copying contents of Maze2.txt and pasting it in the Raw Body field surrounding the contents by quotes (")

Repeat by replacing Raw Body contents with Maze2.txt (surrounded by quotes) and pressing Send button

Repeat by replacing Raw Body contents with Maze3.txt (surrounded by quotes) and pressing Send button

