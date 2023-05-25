using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class BestSeat
    {

        public static int GetBestSeatIndex(int[] seats)
        {
            int bestSeatIndex = -1;
            int maxSpace = 0;

            int leftPtr = 0;

            while(leftPtr < seats.Length)
            {
                int rightPtr = leftPtr + 1;
                while(rightPtr < seats.Length && seats[rightPtr] == 0)
                {
                    rightPtr++;
                }

                int availableSpace = rightPtr - leftPtr - 1;
                if(availableSpace > maxSpace)
                {
                    bestSeatIndex = (rightPtr + leftPtr) / 2;
                    maxSpace = availableSpace;
                }
                leftPtr = rightPtr;
            }
            return bestSeatIndex;
        }
    }
}
