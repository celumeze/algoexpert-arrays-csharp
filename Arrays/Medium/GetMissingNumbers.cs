using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class GetMissingNumbers
    {
        public static int[] ReturnMissingNumbersNonOptimalSolution(int[] nums)
        {
           List<int> includedNums = nums.ToList(); //(O(n) space)

           List<int> missingNums = new List<int>();

           for(int i=1;i<=nums.Length+3;i++)
           {
                if (!includedNums.Contains(i) && missingNums.Count < 2)
                {
                    missingNums.Add(i);
                }
           }

           return missingNums.ToArray();
        }
    }
}
