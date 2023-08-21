using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6.Create a C# program that multiplies each element in an integer array by a specified factor using a loop
            int[] ar4 = { 1, 2, 3, 4, 5, 6, 6 };
            int mul = 1;
            for (int p = 0; p < ar4.Length; p++)
            {
                mul *= ar4[p];
            }
            Console.WriteLine(mul);
        }
    }
}
