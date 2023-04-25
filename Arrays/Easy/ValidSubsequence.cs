using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Easy
{
    public static class ValidSubsequence
    {
        public static bool IsValidSubsequence<T>(T[] array, T[] sequence) where T : IComparable<T>
        {
            int arrayCounter = 0;
            int sequenceCounter = 0;

            while (arrayCounter < array.Length && sequenceCounter < sequence.Length)
            {
                if (array[arrayCounter].CompareTo(sequence[sequenceCounter]) == 0)
                {
                    sequenceCounter++;
                }
                arrayCounter++;
            }

            return sequenceCounter == sequence.Length;
        }
    }
}
