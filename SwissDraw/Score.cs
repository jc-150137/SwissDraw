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

        public static Dictionary<int, Score> CalcWinClont(Match[] result)
        {
            throw new NotImplementedException();
        }

        public static Dictionary<int,Score> CalcScore(Match[] result)
        {
            throw new NotImplementedException();
        }
    }
}
