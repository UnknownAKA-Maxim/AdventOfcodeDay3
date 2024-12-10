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
            string[] doThis = input.Split(new string[] { "do()" }, StringSplitOptions.RemoveEmptyEntries);
            string[] dontThis = new string[doThis.Length];
            for (int i = 0; i < doThis.Length; i++)
            {
                dontThis[i] = doThis[i].Split(new string[] { "don't()" }, StringSplitOptions.RemoveEmptyEntries)[0];
            }

            int answer = 0;

            for (int i = 0; i < dontThis.Length; i++)
            {
                answer += Part1(dontThis[i]);
            }
            Console.WriteLine(answer);
            Console.ReadLine();
            //1194822
        }

        private static int Part1(string input)
        {
            string[] split = input.Split(new string[] { "mul(" }, StringSplitOptions.RemoveEmptyEntries);
            int answer = 0;

            foreach (string line in split)
            {
                string[] numbers = line.Split(',');

                answer += Multiply(numbers, line);
            }

            return answer;
        }

        private static int Multiply(string[] numbers, string line)
        {
            if (int.TryParse(numbers[0], out int value1))
            {
                if (int.TryParse(numbers[1].Split(')')[0], out int value2))
                {
                    return value1 * value2;
                }
            }
            return 0;
        }
    }
}
