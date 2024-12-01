using LeetCode_Problems.Array;

namespace LeetCode_Problems
{
    public abstract class LCProblem
    {
        public abstract void RunProgram();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the problem number of the program you want to run (type non-number for quitting!)");
                int problemNumber = int.TryParse(Console.ReadLine() ?? "-1", out int number) ? number : -1;

                if (problemNumber <= 0)
                {
                    return;
                }

                LCProblem program;

                try
                {
                    program = GetProgramClass(problemNumber);
                    program.RunProgram();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); return;
                }
            }
        }

        private static LCProblem GetProgramClass(int problemNumber)
        {
            return problemNumber switch
            {
                1480 => new P1480RunningSum1DArray(),
                //1 => new Day1(),
                //2 => new Day2(),
                //3 => new Day3(),
                //4 => new Day4(),
                //5 => new Day5(),
                //6 => new Day6(),
                //7 => new Day7(),
                //8 => new Day8(),
                //9 => new Day9(),
                //10 => new Day10(),
                //11 => new Day11(),
                //12 => new Day12(),
                //13 => new Day13(),
                //14 => new Day14(),
                //15 => new Day15(),
                //16 => new Day16(),
                //17 => new Day17(),
                //18 => new Day18(),
                //19 => new Day19(),
                //20 => new Day20(),
                //21 => new Day21(),
                //22 => new Day22(),
                _ => throw new InvalidDataException("This problem solution doesn't exist in this code")
            };
        }
    }
}
