using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePoint
{

    public class Solution
    {
        public int BalancePoint(int[] input)
        {
            // Your code goes here

            if (input == null) return -1;
            if (input.Count() < 3) return -1;

            //int i = 0;
            int totalSum = 0;
            int leftsum = 0;
            
            totalSum = input.Sum();

            for (int i = 0; i < input.Count(); i++)
            {
                totalSum -= input[i];

                if (totalSum == leftsum) return i;
                if (i == input.Count() - 1) return -1;

                leftsum += input[i];
            }

            return -1;

        }

    }
}
