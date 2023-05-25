using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class SpiralTraverse
    {
        public static List<int> ReturnSpiralResult(int[,] array)
        {
            int cols = array.GetLength(1);
            int rows = array.GetLength(0);
            int startingRow = 0;
            int endingRow = rows - 1;
            int startingCol = 0;
            int endingCol = cols - 1;
            List<int> result = new List<int>();

            while (startingRow <= endingRow && startingCol <= endingCol)
            {
                for (int i = startingCol; i < endingCol + 1; i++)
                {
                    result.Add(array[startingRow, i]);
                }

                for (int i = startingRow + 1; i < endingRow + 1; i++)
                {
                    result.Add(array[i, endingCol]);
                }

                for (int i = endingCol - 1; i > startingCol && endingRow > startingRow; i--)
                {
                    result.Add(array[endingRow, i]);
                }

                for (int i = endingRow; i > startingRow && endingCol > startingCol; i--)
                {
                    result.Add(array[i, startingCol]);
                }
                startingCol = startingCol + 1;
                endingCol = endingCol - 1;
                startingRow = startingRow + 1;
                endingRow = endingRow - 1;
            }

            return result;

        }
    }
}
