using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class ZeroSumSubArray
    {
        public static bool IsZeroSumSubArray(int[] nums)
        {
            HashSet<int> sums = new HashSet<int>() { 0 };
            int currentSum = 0;

            for(int i=0; i<nums.Length; i++)
            {
                currentSum += nums[i];                
                if (sums.Contains(currentSum))
                {
                    return true;
                }   
                sums.Add(currentSum);
            }            
            return false;
        }
    }
}
