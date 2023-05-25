using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class SmallestDifference
    {
        public static int[] ReturnSmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            int arrayOneCounter = 0;
            int arrayTwoCounter = 0;
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            int prevDiff = int.MaxValue;
            int[] arrayResult = new int[2];            

            while(arrayOneCounter < arrayOne.Length && arrayTwoCounter < arrayTwo.Length && prevDiff != 0) 
            { 
                int absDiff = Math.Abs(arrayOne[arrayOneCounter] - arrayTwo[arrayTwoCounter]);
                if(absDiff < prevDiff)
                {
                    arrayResult[0] = arrayOne[arrayOneCounter];
                    arrayResult[1] = arrayTwo[arrayTwoCounter];
                    prevDiff = absDiff;                   
                }
                
                if (arrayOne[arrayOneCounter] < arrayTwo[arrayTwoCounter])
                {

                    arrayOneCounter++;
                }
                else
                {
                    arrayTwoCounter++;
                }


            }
            return arrayResult;
        }
    }
}
