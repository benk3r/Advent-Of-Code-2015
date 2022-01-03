using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code.DailyPuzzles
{
    internal class Puzzle1 : PuzzleBase
    {

        public Puzzle1()
        {
        }

        public int FindFloor(string input)
        {
            int floor = 0;
            int ups = 0;
            int downs = 0;
            int inputSize = input.Length;
            for (int i = floor; i < inputSize; i++)
            {
                if (input[i].Equals('('))
                {
                    ups++;
                }
                if (input[i].Equals(')'))
                {
                    downs++;
                }
            }
            floor = ups - downs;
            return floor;
        }

        public int BasementBreach(string input)
        {
            int floor = 0;
            int inputSize = input.Length;
            for (int i = floor; i < inputSize; i++)
            {
                if (input[i].Equals('('))
                {
                    floor++;
                }
                else if (input[i].Equals(')'))
                {
                    floor--;
                }

                if (floor == -1)
                {
                    // the position number of the index where the basement is finally breached
                    return i + 1;
                }
            }

            // should never happen, the basement is breached at some point
            return floor;
        }
    }
}
