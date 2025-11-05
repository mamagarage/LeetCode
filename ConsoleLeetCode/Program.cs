using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeetCode.Solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            //LeetCode.Solution.MaxSubArray(new int[] { 1 });
            //LeetCode.Solution.MaxSubArray(new int[] { 5, 4, -1, 7, 8 });
            LeetCode.Solution.MaxSubArray(new int[] { -1 });
            Console.ReadLine();
        }
    }
}
