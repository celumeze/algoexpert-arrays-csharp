using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class FirstDuplicate
    {
        public static int GetFirstDuplicateUsingOptimal(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                    int idxOfCurrentValue = Math.Abs(array[i]) - 1;
                    if (array[idxOfCurrentValue] > 0)
                    {
                        array[idxOfCurrentValue] = 0 - array[idxOfCurrentValue];
                    }
                    else
                    {
                        return Math.Abs(array[i]);
                    }
            }
            return -1;
        }

        public static int GetLastDuplicateUsingBruteForce(int[] array)
        {
            int lastDuplicateIdx = 0;
            int i = 0;

            while (i < array.Length && lastDuplicateIdx == 0)
            {
                int rightIdx = i + 1;

                while (rightIdx < array.Length)
                {
                    bool isDuplicate = array[rightIdx] == array[i];
                    if (isDuplicate && lastDuplicateIdx > 0)
                    {
                        lastDuplicateIdx = Math.Min(lastDuplicateIdx, rightIdx);
                        break;
                    }
                    else if (isDuplicate && lastDuplicateIdx == 0)
                    {
                        lastDuplicateIdx = rightIdx;
                    }
                    rightIdx++;
                }
                i++;
            }
            int firstDuplicateValue = lastDuplicateIdx == 0 ? -1 : array[lastDuplicateIdx];
            return firstDuplicateValue;
        }

    }
}
