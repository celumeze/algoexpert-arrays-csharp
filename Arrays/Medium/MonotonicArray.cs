using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class MonotonicArray
    {
        public static bool IsMonotonic(int[] array)
        {
            int IsIncreasingCheckCounter = 0;
            int IsDecresingCheckCounter = 0;
            int IsEqualCheckCounter = 0;
            

            if (array.Length <= 1)
            {
                return true;
            }            
            for(int i=0; i<array.Length - 1; i++)
            {
               if (array[i] < array[i + 1])
               {

                   IsDecresingCheckCounter++;
               }
               else if (array[i] > array[i + 1])
               {
                   IsIncreasingCheckCounter++;
               }
               else
               {
                  IsEqualCheckCounter++;
               }
            }
            return (IsIncreasingCheckCounter == 0 && IsDecresingCheckCounter > IsEqualCheckCounter) || 
                   (IsDecresingCheckCounter == 0 && IsIncreasingCheckCounter > IsEqualCheckCounter) || 
                   (IsDecresingCheckCounter == 0 && IsIncreasingCheckCounter == 0);
        }
    }
}
