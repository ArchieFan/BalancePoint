using System;
using System.Drawing;
using System.Globalization;
using System.Linq.Expressions;

namespace BalancePoint
{

    internal class Program
    {

        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.BalancePoint(new int[] { 2, 7, 4, 5, -3, 8, 9, -1 }));
            Console.WriteLine(solution.BalancePoint(new int[] {2, 7, 4, 5, -3, 8, 9, -1 }));
            Console.WriteLine(solution.BalancePoint(new int[] { 1, 1, 2 }));


        }
    }
}