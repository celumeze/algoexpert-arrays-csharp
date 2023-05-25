using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Medium
{
    public static class MoveElementToEnd
    {
        public static List<int> DoMoveElementToEnd(List<int> array, int toMove) 
        {
            int endCounter = array.Count-1;
            int beginCounter = 0;

            while(beginCounter < endCounter) 
            {
                if (array[endCounter] == toMove && array[beginCounter] == toMove) 
                {
                    endCounter--;
                }
                else if (array[endCounter] != toMove && array[beginCounter] == toMove)
                {
                    int temp = array[endCounter];
                    array[endCounter] = array[beginCounter];
                    array[beginCounter] = temp;
                    beginCounter++;
                    endCounter--;
                }
                else
                {
                    beginCounter++;
                }
            }

            return array;
        }
    }
}
