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
        }
    }
}
