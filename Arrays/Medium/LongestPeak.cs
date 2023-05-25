using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class LongestPeak
    {
        public static int GetLongestPeak(int[] array)
        {         
            int longestPeakLength = 0;
            int i = 1;
            while (i < array.Length - 1)
            {
                bool isPeak = array[i - 1] < array[i] && array[i] > array[i + 1];
                if (!isPeak)
                {
                    i++;
                    continue;
                }
                int leftIdx = i - 2;
                int rightIdx = i + 2;
                while (leftIdx >= 0 && array[leftIdx] < array[leftIdx + 1])
                {
                    leftIdx--;
                }
                while (rightIdx < array.Length && array[rightIdx] < array[rightIdx - 1])
                {
                    rightIdx++;
                }
                int currentLongestLength = (rightIdx - 1) - (leftIdx + 1) + 1; ;
                longestPeakLength = Math.Max(longestPeakLength, currentLongestLength);
                i++;

            }
            return longestPeakLength;
        }

    }
}
