using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class ArrayOfProducts
    {
        public static int[] GetArrayOfProducts(int[] array)
        {
            int i = 0;
            int[] result = new int[array.Length];
            int? product = null;

            while(i < array.Length)
            {
                int leftIdx = i - 1;
                int rightIdx = i + 1;   

                while(leftIdx >= 0)
                {
                    product = product == null ? array[leftIdx] : product * array[leftIdx];
                    leftIdx--;
                }
                while(rightIdx < array.Length)
                {
                    product = product == null ? array[rightIdx] : product * array[rightIdx];
                    rightIdx++;
                }
                result[i] = product != null ? product.Value : 0;
                product= null;
                i++;
            }
            return result;
        }
    }
}
