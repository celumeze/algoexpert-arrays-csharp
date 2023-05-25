using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class OverlappingIntervals
    {
        public static int[][] MergeOverlappingIntervals(int[][] intervals)
        {
            if(intervals.Length == 0)
            {
                return new int[][] { };
            }
            Array.Sort(intervals, (x,y)=> x[0].CompareTo(y[0]));

            List<int[]> result = new List<int[]>();
            int[] prevInterval = intervals[0];
            result.Add(prevInterval);

            for(int i= 1;i<intervals.Length;i++)
            {
                int[] currentInterval = intervals[i];

                if (prevInterval[1] >= currentInterval[0])
                {
                    prevInterval[1] = Math.Max(prevInterval[1], currentInterval[1]);
                }
                else
                {
                    prevInterval = currentInterval;
                    result.Add(prevInterval);
                }
            }
            return result.ToArray();
        }
    }
}
