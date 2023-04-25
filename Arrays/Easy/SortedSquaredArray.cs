using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Easy
{
    public static class SortedSquaredArray
    {
        public static int[] ReturnSortedSquaredArray(int[] array)
        {
            int[] newList = new int[array.Length];
            int leftRightCounter = array.Length - 1;
            int rightLeftCounter = 0;
            int currentIndex = array.Length - 1;
            int squaredValue = 0;

            while (currentIndex >= 0)
            {
                

                if (Math.Abs(array[leftRightCounter]) > Math.Abs(array[rightLeftCounter]))
                {
                    squaredValue = Math.Abs(array[leftRightCounter]) * Math.Abs(array[leftRightCounter]);
                    leftRightCounter--;
                }
                else
                {
                    squaredValue = Math.Abs(array[rightLeftCounter]) * Math.Abs(array[rightLeftCounter]);
                    rightLeftCounter++;
                }

                newList[currentIndex] = squaredValue;
                currentIndex--;
            }


            return newList;
        }
    }
}
