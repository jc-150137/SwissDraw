using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissDraw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissDraw.Tests
{
    [TestClass()]
    public class ScoreTests
    {
        [TestMethod()]
        public void CalcWinClontTest()
        {
            Match[] result = new Match[3];
            result[0] = new Match(1, 3);
            result[0].Result = 1;
            result[1] = new Match(2, 5);
            result[1].Result = 1;
            result[2] = new Match(4, 6);
            result[2].Result = 1;

            var score = Score.CalcScore(result);
            Assert.AreEqual(1, score[1].winCount);
            Assert.AreEqual(1, score[2].winCount);
            Assert.AreEqual(1, score[4].winCount);
            Assert.AreEqual(0, score[3].winCount);
            Assert.AreEqual(0, score[5].winCount);
            Assert.AreEqual(0, score[6].winCount);

            Match[] result2 = new Match[6];
            result2[0] = new Match(1, 3);
            result2[0].Result = 1;
            result2[1] = new Match(2, 5);
            result2[1].Result = 1;
            result2[2] = new Match(4, 6);
            result2[2].Result = 1;
            result2[3] = new Match(1, 2);
            result2[3].Result = 1;
            result2[4] = new Match(4, 5);
            result2[4].Result = 1;
            result2[5] = new Match(3, 6);
            result2[5].Result = 1;

            var score2 = Score.CalcScore(result2);
            Assert.AreEqual(2, score2[1].winCount);
            Assert.AreEqual(1, score2[2].winCount);
            Assert.AreEqual(1, score2[3].winCount);
            Assert.AreEqual(2, score2[4].winCount);
            Assert.AreEqual(0, score2[5].winCount);
            Assert.AreEqual(0, score2[6].winCount);


        }
        
        [TestMethod()]
        public void CalcScoreTest1()    //6人マッチ
        {
            Match[] result1 = new Match[9];

            //1回戦目
            result1[0] = new Match(1, 3);
            result1[0].Result = 1;
            result1[1] = new Match(2, 4);
            result1[1].Result = 1;
            result1[2] = new Match(5, 6);
            result1[2].Result = 1;

            //2回戦目
            result1[3] = new Match(1, 5);
            result1[3].Result = 1;
            result1[4] = new Match(2, 3);
            result1[4].Result = 1;
            result1[5] = new Match(4, 6);
            result1[5].Result = 1;

            //3回戦目
            result1[6] = new Match(1, 2);
            result1[6].Result = 1;
            result1[7] = new Match(4, 5);
            result1[7].Result = 1;
            result1[8] = new Match(3, 6);
            result1[8].Result = 1;

            var score1 = Score.CalcScore(result1);
            Assert.AreEqual(3, score1[1].winCount);
            Assert.AreEqual(2, score1[2].winCount);
            Assert.AreEqual(1, score1[3].winCount);
            Assert.AreEqual(2, score1[4].winCount);
            Assert.AreEqual(1, score1[5].winCount);
            Assert.AreEqual(0, score1[6].winCount);

            Assert.AreEqual(4, score1[1].score);
            Assert.AreEqual(3, score1[2].score);    
            Assert.AreEqual(0, score1[3].score);
            Assert.AreEqual(1, score1[4].score);
            Assert.AreEqual(0, score1[5].score);
            Assert.AreEqual(0, score1[6].score);

        }

        [TestMethod()]
        public void CalcScoreTest2()    //20人マッチ
        {
            Match[] result1 = new Match[50];

            //1回戦目
            result1[0] = new Match(1, 2);
            result1[0].Result = 1;
            result1[1] = new Match(3, 4);
            result1[1].Result = 1;
            result1[2] = new Match(5, 6);
            result1[2].Result = 1;
            result1[3] = new Match(7, 8);
            result1[3].Result = 1;
            result1[4] = new Match(9, 10);
            result1[4].Result = 1;
            result1[5] = new Match(11, 12);
            result1[5].Result = 1;
            result1[6] = new Match(13, 14);
            result1[6].Result = 1;
            result1[7] = new Match(15, 16);
            result1[7].Result = 1;
            result1[8] = new Match(17, 18);
            result1[8].Result = 1;
            result1[9] = new Match(19, 20);
            result1[9].Result = 1;

            //2回戦目
            result1[10] = new Match(1, 3);
            result1[10].Result = 1;
            result1[11] = new Match(5, 7);
            result1[11].Result = 1;
            result1[12] = new Match(9, 11);
            result1[12].Result = 1;
            result1[13] = new Match(13, 15);
            result1[13].Result = 1;
            result1[14] = new Match(17, 19);
            result1[14].Result = 1;
            result1[15] = new Match(2, 4);
            result1[15].Result = 1;
            result1[16] = new Match(6, 8);
            result1[16].Result = 1;
            result1[17] = new Match(10, 12);
            result1[17].Result = 1;
            result1[18] = new Match(14, 16);
            result1[18].Result = 1;
            result1[19] = new Match(18, 20);
            result1[19].Result = 1;

            //3回戦目
            result1[20] = new Match(1, 5);
            result1[20].Result = 1;
            result1[21] = new Match(9, 13);
            result1[21].Result = 1;
            result1[22] = new Match(17, 2);
            result1[22].Result = 1;
            result1[23] = new Match(3, 6);
            result1[23].Result = 1;
            result1[24] = new Match(7, 10);
            result1[24].Result = 1;
            result1[25] = new Match(11, 14);
            result1[25].Result = 1;
            result1[26] = new Match(15, 18);
            result1[26].Result = 1;
            result1[27] = new Match(19, 4);
            result1[27].Result = 1;
            result1[28] = new Match(8, 12);
            result1[28].Result = 1;
            result1[29] = new Match(16, 20);
            result1[29].Result = 1;

            //4回戦目
            result1[30] = new Match(1, 9);
            result1[30].Result = 1;
            result1[31] = new Match(17, 3);
            result1[31].Result = 1;
            result1[32] = new Match(5, 11);
            result1[32].Result = 1;
            result1[33] = new Match(7, 13);
            result1[33].Result = 1;
            result1[34] = new Match(15, 19);
            result1[34].Result = 1;
            result1[35] = new Match(2, 6);
            result1[35].Result = 1;
            result1[36] = new Match(8, 10);
            result1[36].Result = 1;
            result1[37] = new Match(14, 18);
            result1[37].Result = 1;
            result1[38] = new Match(16, 4);
            result1[38].Result = 1;
            result1[39] = new Match(12, 20);
            result1[39].Result = 1;

            //5回戦目
            result1[40] = new Match(1, 17);
            result1[40].Result = 1;
            result1[41] = new Match(5, 9);
            result1[41].Result = 1;
            result1[42] = new Match(7, 15);
            result1[42].Result = 1;
            result1[43] = new Match(2, 3);
            result1[43].Result = 1;
            result1[44] = new Match(8, 11);
            result1[44].Result = 1;
            result1[45] = new Match(13, 16);
            result1[45].Result = 1;
            result1[46] = new Match(14, 19);
            result1[46].Result = 1;
            result1[47] = new Match(6, 10);
            result1[47].Result = 1;
            result1[48] = new Match(12, 18);
            result1[48].Result = 1;
            result1[49] = new Match(4, 20);
            result1[49].Result = 1;

            var score1 = Score.CalcScore(result1);
            Assert.AreEqual(5, score1[1].winCount);
            Assert.AreEqual(3, score1[2].winCount);
            Assert.AreEqual(2, score1[3].winCount);
            Assert.AreEqual(1, score1[4].winCount);
            Assert.AreEqual(4, score1[5].winCount);
            Assert.AreEqual(2, score1[6].winCount);
            Assert.AreEqual(4, score1[7].winCount);
            Assert.AreEqual(3, score1[8].winCount);
            Assert.AreEqual(3, score1[9].winCount);
            Assert.AreEqual(1, score1[10].winCount);
            Assert.AreEqual(2, score1[11].winCount);
            Assert.AreEqual(2, score1[12].winCount);
            Assert.AreEqual(3, score1[13].winCount);
            Assert.AreEqual(3, score1[14].winCount);
            Assert.AreEqual(3, score1[15].winCount);
            Assert.AreEqual(2, score1[16].winCount);
            Assert.AreEqual(4, score1[17].winCount);
            Assert.AreEqual(1, score1[18].winCount);
            Assert.AreEqual(2, score1[19].winCount);
            Assert.AreEqual(0, score1[20].winCount);

            Assert.AreEqual(16, score1[1].score);
            Assert.AreEqual(5, score1[2].score);
            Assert.AreEqual(3, score1[3].score);
            Assert.AreEqual(0, score1[4].score);
            Assert.AreEqual(11, score1[5].score);
            Assert.AreEqual(4, score1[6].score);
            Assert.AreEqual(10, score1[7].score);
            Assert.AreEqual(5, score1[8].score);
            Assert.AreEqual(6, score1[9].score);
            Assert.AreEqual(2, score1[10].score);
            Assert.AreEqual(5, score1[11].score);
            Assert.AreEqual(1, score1[12].score);
            Assert.AreEqual(8, score1[13].score);
            Assert.AreEqual(5, score1[14].score);
            Assert.AreEqual(5, score1[15].score);
            Assert.AreEqual(1, score1[16].score);
            Assert.AreEqual(8, score1[17].score);
            Assert.AreEqual(0, score1[18].score);
            Assert.AreEqual(1, score1[19].score);
            Assert.AreEqual(0, score1[20].score);

        }
    }
}