﻿using System;

namespace MazeTests
{
    public class MazeStrings
    {
        public const string Maze1 = @"##########
#A...#...#
#.#.##.#.#
#.#.##.#.#
#.#....#B#
#.#.##.#.#
#....#...#
##########";

        public const string Maze1SolutionString = @"##########
#A@@.#...#
#.#@##.#.#
#.#@##.#.#
#.#@@@@#B#
#.#.##@#@#
#....#@@@#
##########";


        public const string Maze2 = @"###############B#############################################
##.....########.#......................................#...##
##.###.#........####################################.#.#.#.##
##.###.#.#########..........#########.......########.#.#.#.##
##.#####...........########.#.......#.#####.########.#.#.#.##
##.########################.#.#####.#.#...#.########.#.#.#.##
##............................#####.#.##.##.########.#.#.#.##
##.###.############################.#.##.##.########.#.#.#.##
##.###.##...#...#...#...#...#.......#.##.##.########.#.#.#.##
##.###....#...#...#...#...#...#######.##.##.########.#.#.#.##
##.##################################.##.##.########.#.#.#.##
##.......................................##.########.#.#.#.##
###########################################.########.#.#.#.##
###...............................#########..........#.#.#.##
########################.###########################.#.#.#.##
#........................#...........................#.#.#.##
#.######################.#############################.#.#.##
#.#..........#.........................................#.#.##
#.#.########.#.#########################################.#.##
#.#........#.#.#.........................................#.##
#.##########.#.#.#########################################.##
#............#.#.##........................................##
##############.#.#############################.#####.########
#..............................................#####........#
########################A####################################";

        public const string Maze3 = @"#######################################################################################################################################################################################
#A......#.....#.....#.#.....#.#...#.#.......#.....#.#...#.......#...........#...#.............#.....#.......#.........#.....#.....#...........#.#...................#.....#...........#
#.#######.#.#.#.###.#.#####.#.#.#.#.#####.#.#.###.#.#######.#.###.#.#.#.#.#####.#.#########.#.###.#.#.#.#.#.#.#.#.###.#.#####.#.#.#.#.#.#.#.#.#.#.#.###.#####.#.#.#.#.#.#.#.#.#.#.#.#.#
#.....#.#.....#.#...#.......#.......#...#...#.#.......#.....#.....#.........#...#...#.....#.........#.#...#.#.#.#.#...#.#...#.....#...#...#...#.#...#.#.#.#...........#.#.......#.#...#
#.#####.#.#.#.#.#.###.###.#.###.#.#.#.###.#.#.#.#.#.#.###.#.#.#######.#.#.#.###.#.#.#.#.#######.#.###.###.#.#.###.#####.#.#.#.#####.###.#.#.#########.#.#.#.###.#####.#.#.#####.#.#.###
#...#...#.#.#.....#...#.............#.#.......#.......#.#...#.#.........#.......#.#.....#.......#.......................#.#...#.#.#...#...#.#.#...#...#.......#.........#...#.#.....#.#
#.#.###.#.#.#.#.#.#.#.#.#.###.#.#.#.#.#.###.###.###.#.#.#.#.###.###.###.#.#.#####.#.#.#.#.#.#.#.#.###.#.###########.#.#.#.#.#.#.#.###.###.#.#.#.#.#.#.#.#.#.#.#####.###.#.###.#.#####.#
#...#...#...#...#.#.#.#...#...#...#...#.....#...................#...#.#.....#...........#.....#.#.#...#.#...#.........#.#.......#...........#...#.....#...#.#...............#.#.......#
#.#.#.#.###.#.#.###.#######.#.#.#.#.#.#.###.#.###.#.#.#.###.#.#.#.#.#.#.#####.#.#.###.#.#.###.#.#.#.#.#.###.###.#.#.#.#####.#.###########.#.#.#.#########.#.#.###.###.###.#.#.###.#.#.#
#.#.........#...#.....#.....#.#...#...#.....#...............#...#.......#.#.#.......#.#...#.....#.#.#.........#.#.........#...#...#.........#.#...#.#.#...........#.....#.......#.....#
#.#.#.#.#.###.#.#.#.#.#.#.###.#########.#.#.###.#.#.#####.#####.#.#####.#.#.###.#.#.#.#.#.#.#.#.#.#.#.#.#.###.###.###.#.#.###.###.#.#.#.#.#.###.#.#.#.#.#.#####.###.#.#.#######.#.###.#
#...#.........#...#.#...#.#.#...........#.#.#...........#.......#.#.#.....#...#.#.#.#...#.......#.........#...#.....#...#.....#.#.....#.#...#.....#.#...#.....#.#.#.#.............#...#
#.#.###########.###.#.###.#.#####.#.#.#.###.#.###.#.#.#.#########.#.#.#####.#.#.#.#.#.#.#####.#.#.#.###.#.#.#.#.###############.#.###.#.#.#.#.#.###.###.#.#.#.#.#.#.#####.#.#.###.#.###
#.....#.#...........#.#.............#.#...........#.....#.#.....#...#.#.#.#...........#.#.....#...#.....#...#.....#...........#.#.#...#.........#.#.....#...#.......#.....#...#.......#
#####.#.#.#.#.#.#####.#.#####.#.#.#.#.###.#.#.###.#######.#.#.#####.#.#.#.#.#.#####.###.#.###.#.#.#.#####.#.#.###.#.###.#.###.#.#.###.#.###.###.#.#.#.#.###.#.#####.#.#.#.#####.#.###.#
#.....#.#.....#.#.......#.......#.....#...#...#...............#.....#...........#.........#.....#.#.#.............#.#...#.#.....#.#...#...#...#.........#.....#...#...#...........#...#
#.#.#.###.#.###.#.#.#.###.#.###.#.#.#.###.###.#.###.#.#.#.#####.#.#.#.###.#####.#####.#.#.#.###.#.###.###.#####.#.#.#.#.#.###.###.#.###.#.#.#.#.#.#####.#####.#.#.#.###.#.#.#.#####.###
#...#.....#.#.......#.....#.#.....#...#...#.#.#.....#...#.#...#.#.....................#.....#.....#.....#.......#.........#...#...#...#.#.#.#...#.#.#...#...#.....#.#.......#...#.....#
#####.###.###.#.#.#.#.#.#.###.#.#.#.#####.#.#.#.#.#.#######.#.#.#.#.#.#######.###.#.###.#.#.###.#.#.#.#.#.#####.#.#.#.###.#.###.###.#.###.#.###.#.#.#.#.###.#.###.###.#####.###.#.#####
#.....#.....#...#.....#.#...#...#.........#...................#.....#...#.........#.....#...........#...#.#.......#.#...#...#...............#.......#...#.........#.............#.....#
#.#.#.#.#######.#.#.#########.#######.###.#####.###.#.###.#.#######.#.###.#.###.###.###.#####.#####.###.#.#.#.#.#.#.#.###.#.#.#######.#.#.#.#.#.#.#.#.#####.#.#.#.#.#.#.###.#.#.###.#.#
#.#.#.......#...#.#...#.......#.................#.....#...#.......#.#.....#.....#.#...#.#.....#...#.#.......#...#.....#.....#.....#.......#.....#...#.#...#.....#...#.#.#...#...#.....#
###.#.#####.#.###.###.#.#.###.#.###.#####.#.#.#######.#.#########.#####.#.#.#.###.#.#.#.###.#######.#.#########.#.#.#.#.#.#.#####.###.###.###.#.#.#.#.#.#.#.###.#.#.#.#.#####.#.#.###.#
#.#...#.....#.....#.#.....#...#...#.#...#...#.#.#.#.....#.....#.#.#.#.....#.................#.#.#...#...#...#.#.#.#.#.#...#...#.#.............#.#...#...#.#.#.......#.........#.#.....#
#.###.#.###.#.#.#.#.###.#.#.###.#####.#.###.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.#.#####.###.#.###.#.#.###.#.#.#.#.#.#.#.#.#.###.#.#.###.#.#.#.#######.#.###.#.#.#.###.#.#.#.###.###.#.#.#.#
#.#...#.....#.....#.#...#...#.......#...#.....#.#.#.....#.#...#...#...#.#.........#.....#...#.#...#...#...#.#.#.......#...#.#...#...#.#...#.....#.......#.......#.#.....#.#...#.#.....#
#.#.#.#.#.#.#.###.#.###.#.#.#.###.###.#.#.###.###.#.#.#.#.###.#.#.#.#.#.#.#########.#.#.#.#.#.#######.#.###.#.#.#.#.#.#.###.#.###.#######.#.#.#.#.###.#.#.#.#.#.#.#.#####.###.#.#.###.#
#.....#.....#.#...#.#.#...#.....#.....#.#...#.....#.....#.....#.#.#...#...#.#.....#.#.#...#...#.......#.....#...........#...#.#...#.......#.......#.#.#...#.#...#.#.#...........#.....#
#.#####.#####.#####.#.###.#########.#.#.#.#.###.#.#.#.#.#.#.#.#####.###.#.#.#.###.#.###.#.#####.###.#####.#####.#.###.###.#.#.#.#.#.###.#.#.#####.#.#.###.###.###.#.#.#.#.#.###.###.#.#
#.....#...#...#.#...#.........#.................#.#.....#.#.....#.........#...#.....#...#.#.....#.......#.......#.....#.#.#.......#.#...#.#...#.#.........#.........#...#.....#.....#.#
#.###.#####.#.#.#.#.#.#######.#.#####.#########.#.#.###.#.#####.#.#####.###.#.#.#.#.###.#.#.#.#.###.#.#####.#.###.###.#.#.#.###.#.#.#.#.#.#.#.#.#.#####.#.#.###.#.#.#.#.#.#.#.###.###.#
#.#...#.#.....#...#.#.#.......#.#.................#...#.....#...............#.........#...#.#.#...#.#...#...#.........#.....#...........#.#...........#.....#.#.#.#...#...#...#.#.#...#
#.#.#.#.#.###.#######.#.#.#.###.#.#.#.###.#.#.###.###.#.###.#.#####.#.#.#.#.#.###.#########.#.#.#.#.#.#.#######.###.#.#.###.#.#.###.#.###.#.#.###.#.#.#.#.#.#.#.#.#.###.#####.#.###.#.#
#.#.....#.....#.#.......#...#...#...#.#...#.....#.......#...#...#...#.#.#...#...#.....#.#...#...........#.........#...#.#...#...#...#...#...........#.#.#...#...........#.....#.#.....#
###.#.###.#####.#.#.#.#.#.###.#.#.#####.#.#.#.#.#.#.#.###.###.#.#.###.#.###.###.#####.#.#.###.#.#.###.#.#.#.###.#####.###.#####.#.#.###.#.#####.#.#.#.#####.###.###.###.#.#.#.#.#.#.###
#.........#.....#.....#...#...............#.#...#.#.#.....#.#...#...#.#...............#.......#.......#.#...#.#...........#.#.#...............#...#.........#...............#...#...#.#
#.#.#.###.#.#####.#.#.#.#.#.#.###.###.###.#####.#.#####.###.#.#.###.#.###.###.#####.#####.#####.#########.###.#.#.#.#.#.#.#.#.#.#.#.#.###.#.#.###.#####.###.#####.###.#.###.###.#.#.#.#
#.....#.#.............#...#.......#.#.............#.#...#.#...#...#.#.....#.#.#...#.#.....#...#...........#.....#.#.#...#...................#.....#.....#...............#.....#.#.....#
#.#####.#.###.#.#######.###.###.#.#.#.###.###.#.###.#.#.#.###.#.#.#.#####.#.###.###.#########.#.#####.#.#.#.#.#.#.#.#####.#########.#.#.#.#.###.###.#.#####.#.#.###.#####.#.#.###.###.#
#...#.....#.#.#.#...............#.........#.....#.......#.........#...........#...#.......#.#...#.......#.....#...#.#...#.#...#.#.....#...........#.................#...#.#.#.#...#.#.#
#.#.#.#####.#.###.###.#.#.#####.#.#####.###.#.###.#.#######.#.#.###.###.###.#.#.#.#.#.#.#.#.#.#.#.#.#######.#######.#.#.###.###.#.###.#.###.#.#.#.#.#.#######.#.#.###.#.###.#####.#.#.#
#.....#.#.....#...#...#.#.......#...#.............#...#.....#...#.#.......#.....#...#...#.#.....#.#...........#.......#.#...#...#.#...#.#.#.....#...............#...#.#.#...#...#.....#
#####.#.#.#.###.#.###.#.#####.#######.#############.#.#.#.#.#.###.#.#.###.#.#####.#.#.#.#####.#.#.###.###.#.#.#.###.#.#.###.#.#.#.#.#.#.#.#.#.###.###.#.#######.###.#.#####.#######.###
#.....#...........#.....#.....#.......#...#...#.......#.....#.#...#.#.#...#.#...#.....#.......#...#...#...#.#.#.#.....#.....#...#.#...#.......#...#...#.....#...#...#.........#.#....B#
#######################################################################################################################################################################################";

    }
}
