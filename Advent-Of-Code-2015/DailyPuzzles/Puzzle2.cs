using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2015.DailyPuzzles
{
    internal class Puzzle2
    {
        // Properties
        public string PuzzleInput { get; set; }
        public List<string> DistinguishedInputs { get; set; }
        public List<int> IndividualAreas { get; set; }
        public int SumOfAllAreas { get; set; }

        // Constructors
        public Puzzle2()
        {
            ReceiveInput();
            DistinguishTheInputs(PuzzleInput);
            ParseIndividualAreas(DistinguishedInputs);
            SumOfAllAreas = IndividualAreas.Sum();
            Console.WriteLine($"The sum of all the areas is: {SumOfAllAreas}");
        }

        // Methods
        public void ReceiveInput()
        {
            Console.WriteLine("Provide input, please.");
            PuzzleInput = Console.ReadKey() ?? "1x1x1";
        }
        public void DistinguishTheInputs(string input)
        {
            DistinguishedInputs = input.Split('\n').ToList();
        }
        public void ParseIndividualAreas(List<string> distinguishedInputs)
        {
            foreach(string input in distinguishedInputs)
            {
                string[] unparsedDimensions = new string[3];
                int[] parsedDimensions = new int[3];
                unparsedDimensions = input.Split('x');
                for(int i = 0; i < unparsedDimensions.Length; i++)
                {
                    parsedDimensions[i] = Convert.ToInt32(unparsedDimensions[i]);
                }
                IndividualAreas.Add(parsedDimensions[0] * parsedDimensions[1] * parsedDimensions[2]);
            }
        }
    }
}
