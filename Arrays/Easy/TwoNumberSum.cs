using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Easy
{
    public static class TwoNumberSum
    {
        public static int[] ReturnTwoNumberSum(int[] array, int targetSum)
        {
            HashSet<int> visited = new HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int y = targetSum - array[i];
                if (!visited.Contains(y))
                {
                    visited.Add(y);
                }
                else
                {
                    return new int[] { array[i], y };
                }
            }
            return new int[0];
        }
    }
}
