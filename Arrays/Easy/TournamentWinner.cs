using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Easy
{
    public static  class TournamentWinner
    {
        public static string GetWinner(List<List<string>> competitions, List<int> results)
        {
            Dictionary<string, int> teamsPointsTotal = new Dictionary<string, int>();
            int highestScore = 0;

            for(int i=0; i<competitions.Count;i++)
            {
                string winner = results[i] == 1 ? (competitions[i])[0] : (competitions[i])[1];

                if (!teamsPointsTotal.ContainsKey(winner))
                {
                    teamsPointsTotal.Add(winner, 3);
                }
                else
                {
                    teamsPointsTotal[winner] = Convert.ToInt32(teamsPointsTotal[winner]) + 3;
                }

                highestScore = teamsPointsTotal[winner] > highestScore ? teamsPointsTotal[winner] : highestScore;               
            }
            return teamsPointsTotal.Where(x => x.Value == highestScore).FirstOrDefault().Key;
        }
    }
}
