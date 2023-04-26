using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Easy
{
    public static class NonConstructibleChange
    {
        public static int GetMinimumUnavailableChange(int[] coins)
        {
                if(coins.Length == 0) return 1;            
                int changeAvailable = 0;
                Array.Sort(coins);

                for(int i=0;i< coins.Length;i++)
                {
                        changeAvailable++;
                        if (coins[i] <= changeAvailable) 
                        {
                           changeAvailable--;
                           changeAvailable += coins[i];    
                        }
                        else
                        {
                            return changeAvailable;
                        }                    
                }
                return ++changeAvailable;
        }
    }
}
