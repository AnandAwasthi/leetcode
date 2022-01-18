using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /*
    
    Problem statement: 1041. Robot Bounded In Circle
    Link: https://leetcode.com/problems/robot-bounded-in-circle/

    Approach: Calculate vector to find if robot reach same point.

*/
    public class Solution
    {
        public bool IsRobotBounded(string instructions)
        {
            // since robot facing north, dirX = 0 and dirY = 1 as initial direction.
            int dirX = 0;
            int dirY = 1;
            //initial coordinate of robot
            int x = 0;
            int y = 0;

            foreach (var instruction in instructions)
            {
                switch (instruction.ToString())
                {
                    case "G":
                        // take one step in same direction
                        x = x + dirX;
                        y = y + dirY;
                        break;
                    case "L":
                        // turn left, idea is swap dirX and dirY and multiple -1 with dirY.
                        // (dirX, dirY) => turn left(90 degree) => (-dirY, dirX)
                        var t1 = dirX;
                        dirX = dirY;
                        dirY = -1 * t1;
                        break;
                    default:
                        // turn right, opposite of left logic.
                        var t2 = dirY;
                        dirY = dirX;
                        dirX = -1 * t2;
                        break;
                }
            }
            // return true if robot has same coordiates but different direction.
            return (x == 0 && y == 0) || (dirX != 0 || dirY != 1);

        }
    }
}
