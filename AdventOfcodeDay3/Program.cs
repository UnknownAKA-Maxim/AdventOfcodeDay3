using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AdventOfcodeDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            string[] split = input.Split(new string[] { "mul(" }, StringSplitOptions.RemoveEmptyEntries);
            int answer = 0;

            foreach (string line in split)
            {
                string[] numbers = line.Split(',');
                if (int.TryParse(numbers[0], out int value1))
                {
                    if (int.TryParse(numbers[1].Split(')')[0], out int value2))
                    {
                        answer += value1 * value2;
                    }
                }
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
