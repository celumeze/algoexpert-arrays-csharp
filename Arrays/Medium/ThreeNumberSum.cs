using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class ThreeNumberSum
    {
        public static List<int[]> ReturnThreeNumberSum(int[] array, int targetSum)
        {
            List<int[]> targetArrayList = new List<int[]>();
            Array.Sort(array);
            

            for(int i=0;i<array.Length-2;i++)
            {
                int leftCounter = i + 1;
                int rightCounter = array.Length - 1;
                while (array[leftCounter] < array[rightCounter])
                {
                    int sum = array[i] + array[leftCounter] + array[rightCounter];
                    if(sum < targetSum)
                    {
                        leftCounter++;
                    }
                    else if (sum > targetSum)
                    {
                        rightCounter--;
                    }
                    else
                    {
                        int[] targetArray = new int[3];
                        targetArray[0] = array[i]; 
                        targetArray[1] = array[leftCounter];
                        targetArray[2] = array[rightCounter];
                        targetArrayList.Add(targetArray);
                        leftCounter++;
                        rightCounter--;
                    }
                }
            }

           
            return targetArrayList;
        }
    }
}
