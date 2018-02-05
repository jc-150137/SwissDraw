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
            //throw new NotImplementedException();
            Dictionary<int, Score> calcs = new Dictionary<int, Score>();
            foreach(Match re in result)
            {
                int[] keys = GetKeyArray(calcs);
                // どっちが勝ったか調べる
                int winkey, losekey;
                checkwins(out winkey, out losekey, re);
                if(winkey == 1000 || losekey == 1000)
                {
                    break;
                }

                // 勝った人の勝ち数を+1する。
                if (calcs.Count <= 0)
                {
                    calcs.Add(winkey, new Score(winkey, 1));
                    calcs.Add(losekey, new Score(losekey, 0));
                }
                else
                {
                    if(containsKey(keys, winkey))   // すでに対戦していた場合
                    {
                        calcs[winkey].winCount++;
                    }
                    else                            // まだ対戦していない場合
                    {
                        calcs.Add(winkey, new Score(winkey, 1));
                        calcs.Add(losekey, new Score(losekey, 0));
                    }
                }
            }
            return calcs;
        }

        // どっちが勝ったか求め、勝った人と負けた人のNumberを返す
        public static void checkwins(out int win, out int lose, Match re)
        {
            if (re.Result == 1)
            {
                win = re.Person1;
                lose = re.Person2;
            }
            else if(re.Result == 2)
            {
                win = re.Person2;
                lose = re.Person1;
            }
            else
            {
                win = 1000;
                lose = 1000;
            }
        }

        // calcsのkeyを取り出して配列にする
        public static int[] GetKeyArray(Dictionary<int, Score> calcs)
        {
            return calcs.Keys.ToArray();
        }

        //配列内に引数の値がすでに存在するか調べる
        public static bool containsKey(int[] keys, int key)
        {
            foreach (int k in keys)
            {
                if (k == key)
                {
                    return true;
                }
            }
            return false;
        }

        public static Dictionary<int,Score> CalcScore(Match[] result)
        {
            //throw new NotImplementedException();
            Dictionary<int, Score> calcs = CalcWinClont(result);
            int[] keys = GetKeyArray(calcs);
            foreach(int key in keys)
            {
                foreach(Match re in result)
                {
                    int wins = 0;
                    if (re.Person1 == key && re.Result == 1)    // Person1で勝った場合
                    {
                        wins = calcs[re.Person2].winCount;
                    }
                    if (re.Person2 == key && re.Result == 2)    // Person2で勝った場合
                    {
                        wins = calcs[re.Person1].winCount;
                    }
                    calcs[key].score = calcs[key].score + wins; // scoreに勝ち数を加算
                }
            }
            return calcs;
        }
    }
}
