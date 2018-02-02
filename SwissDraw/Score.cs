using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissDraw
{
    public class Score
    {
        // くじの番号
        public int LotNumber { get; set; }
        public int winCount { get; set; }
        public int score { get; set; }

        public Score(int i, int j)
        {
            LotNumber = i;
            winCount = j;
            score = 0;
        }

        public static Dictionary<int, Score> CalcWinClont(Match[] result)
        {
            throw new NotImplementedException();
            Dictionary<int, Score> calcs = new Dictionary<int, Score>();
            foreach(var re in result)
            {
                int key = 999;
                if(re.Result == 1)
                {
                    key = re.Person1;
                }
                else if(re.Result == 2)
                {
                    key = re.Person2;
                }
                if (calcs.Count <= 0)
                {
                    calcs.Add(key, new Score(key, 1));
                }
                else
                {
                    //calcsの中から当てはまるkeyを探してwinCountに+1する。
                }
            }
        }

        public static Dictionary<int,Score> CalcScore(Match[] result)
        {
            throw new NotImplementedException();
        }
    }
}
