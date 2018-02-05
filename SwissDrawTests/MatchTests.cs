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
    public class MatchTests
    {
        [TestMethod()]
        public void MatchTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void MakeMatchTest1()    //6人3マッチ
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person { LotNumber = 1, PersonGroup = "A", PersonName = "安藤" });
            persons.Add(2, new Person { LotNumber = 2, PersonGroup = "A", PersonName = "伊藤" });
            persons.Add(3, new Person { LotNumber = 3, PersonGroup = "B", PersonName = "有働" });
            persons.Add(4, new Person { LotNumber = 4, PersonGroup = "B", PersonName = "遠藤" });
            persons.Add(5, new Person { LotNumber = 5, PersonGroup = "C", PersonName = "尾堂" });
            persons.Add(6, new Person { LotNumber = 6, PersonGroup = "C", PersonName = "加藤" });

            Match[] matches1 = Match.MakeMatch(persons, new Match[0]);
            Assert.AreEqual(3, matches1.Length);
            Assert.AreEqual(1, matches1[0].Person1);
            Assert.AreEqual(3, matches1[0].Person2);
            Assert.AreEqual(2, matches1[1].Person1);
            Assert.AreEqual(4, matches1[1].Person2);
            Assert.AreEqual(5, matches1[2].Person1);
            Assert.AreEqual(6, matches1[2].Person2);

            matches1[0].Result = 1;//1-3
            matches1[1].Result = 1;//2-4
            matches1[2].Result = 1;//5-6

            var result1 = Match.MergeMatch(matches1, new Match[0]);
            Assert.AreEqual(3, result1.Length);
            
            Match[] matches2 = Match.MakeMatch(persons, result1);
            Assert.AreEqual(3, matches2.Length);
            Assert.AreEqual(1, matches2[0].Person1);
            Assert.AreEqual(5, matches2[0].Person2);
            Assert.AreEqual(2, matches2[1].Person1);
            Assert.AreEqual(3, matches2[1].Person2);
            Assert.AreEqual(4, matches2[2].Person1);
            Assert.AreEqual(6, matches2[2].Person2);
            
            matches2[0].Result = 1;//1-5
            matches2[1].Result = 1;//2-3
            matches2[2].Result = 1;//4-6

            var result2 = Match.MergeMatch(matches2, result1);
            Assert.AreEqual(6, result2.Length);
            
            Match[] matches3 = Match.MakeMatch(persons, result2);
            Assert.AreEqual(3, matches3.Length);
            Assert.AreEqual(1, matches3[0].Person1);
            Assert.AreEqual(2, matches3[0].Person2);
            Assert.AreEqual(4, matches3[1].Person1);
            Assert.AreEqual(5, matches3[1].Person2);
            Assert.AreEqual(3, matches3[2].Person1);
            Assert.AreEqual(6, matches3[2].Person2);
            //*/
        }

        [TestMethod()]
        public void MakeMatchTest2()    //20人3マッチ
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person { LotNumber = 1, PersonGroup = "A", PersonName = "安藤" });
            persons.Add(2, new Person { LotNumber = 2, PersonGroup = "B", PersonName = "伊藤" });
            persons.Add(3, new Person { LotNumber = 3, PersonGroup = "C", PersonName = "有働" });
            persons.Add(4, new Person { LotNumber = 4, PersonGroup = "D", PersonName = "遠藤" });
            persons.Add(5, new Person { LotNumber = 5, PersonGroup = "E", PersonName = "尾堂" });
            persons.Add(6, new Person { LotNumber = 6, PersonGroup = "F", PersonName = "鎌田" });
            persons.Add(7, new Person { LotNumber = 7, PersonGroup = "G", PersonName = "木下" });
            persons.Add(8, new Person { LotNumber = 8, PersonGroup = "H", PersonName = "クスノキ博士" });
            persons.Add(9, new Person { LotNumber = 9, PersonGroup = "I", PersonName = "煙山" });
            persons.Add(10, new Person { LotNumber = 10, PersonGroup = "J", PersonName = "小泉総理" });
            persons.Add(11, new Person { LotNumber = 11, PersonGroup = "K", PersonName = "佐々木" });
            persons.Add(12, new Person { LotNumber = 12, PersonGroup = "L", PersonName = "嶋" });
            persons.Add(13, new Person { LotNumber = 13, PersonGroup = "M", PersonName = "鈴木" });
            persons.Add(14, new Person { LotNumber = 14, PersonGroup = "N", PersonName = "清石" });
            persons.Add(15, new Person { LotNumber = 15, PersonGroup = "O", PersonName = "曽我" });
            persons.Add(16, new Person { LotNumber = 16, PersonGroup = "P", PersonName = "滝沢" });
            persons.Add(17, new Person { LotNumber = 17, PersonGroup = "Q", PersonName = "千代田" });
            persons.Add(18, new Person { LotNumber = 18, PersonGroup = "R", PersonName = "榴岡" });
            persons.Add(19, new Person { LotNumber = 19, PersonGroup = "S", PersonName = "寺田" });
            persons.Add(20, new Person { LotNumber = 20, PersonGroup = "T", PersonName = "富沢" });

            Match[] matches1 = Match.MakeMatch(persons, new Match[0]);
            Assert.AreEqual(10, matches1.Length);
            Assert.AreEqual(1, matches1[0].Person1);
            Assert.AreEqual(2, matches1[0].Person2);
            Assert.AreEqual(3, matches1[1].Person1);
            Assert.AreEqual(4, matches1[1].Person2);
            Assert.AreEqual(5, matches1[2].Person1);
            Assert.AreEqual(6, matches1[2].Person2);
            Assert.AreEqual(7, matches1[3].Person1);
            Assert.AreEqual(8, matches1[3].Person2);
            Assert.AreEqual(9, matches1[4].Person1);
            Assert.AreEqual(10, matches1[4].Person2);
            Assert.AreEqual(11, matches1[5].Person1);
            Assert.AreEqual(12, matches1[5].Person2);
            Assert.AreEqual(13, matches1[6].Person1);
            Assert.AreEqual(14, matches1[6].Person2);
            Assert.AreEqual(15, matches1[7].Person1);
            Assert.AreEqual(16, matches1[7].Person2);
            Assert.AreEqual(17, matches1[8].Person1);
            Assert.AreEqual(18, matches1[8].Person2);
            Assert.AreEqual(19, matches1[9].Person1);
            Assert.AreEqual(20, matches1[9].Person2);

            matches1[0].Result = 1;
            matches1[1].Result = 1;
            matches1[2].Result = 1;
            matches1[3].Result = 1;
            matches1[4].Result = 1;
            matches1[5].Result = 1;
            matches1[6].Result = 1;
            matches1[7].Result = 1;
            matches1[8].Result = 1;
            matches1[9].Result = 1;

            var result1 = Match.MergeMatch(matches1, new Match[0]);
            Assert.AreEqual(10, result1.Length);

            Match[] matches2 = Match.MakeMatch(persons, result1);
            Assert.AreEqual(10, matches2.Length);
            Assert.AreEqual(1, matches2[0].Person1);
            Assert.AreEqual(3, matches2[0].Person2);
            Assert.AreEqual(5, matches2[1].Person1);
            Assert.AreEqual(7, matches2[1].Person2);
            Assert.AreEqual(9, matches2[2].Person1);
            Assert.AreEqual(11, matches2[2].Person2);
            Assert.AreEqual(13, matches2[3].Person1);
            Assert.AreEqual(15, matches2[3].Person2);
            Assert.AreEqual(17, matches2[4].Person1);
            Assert.AreEqual(19, matches2[4].Person2);
            Assert.AreEqual(2, matches2[5].Person1);
            Assert.AreEqual(4, matches2[5].Person2);
            Assert.AreEqual(6, matches2[6].Person1);
            Assert.AreEqual(8, matches2[6].Person2);
            Assert.AreEqual(10, matches2[7].Person1);
            Assert.AreEqual(12, matches2[7].Person2);
            Assert.AreEqual(14, matches2[8].Person1);
            Assert.AreEqual(16, matches2[8].Person2);
            Assert.AreEqual(18, matches2[9].Person1);
            Assert.AreEqual(20, matches2[9].Person2);

            matches2[0].Result = 1;
            matches2[1].Result = 1;
            matches2[2].Result = 1;
            matches2[3].Result = 1;
            matches2[4].Result = 1;
            matches2[5].Result = 1;
            matches2[6].Result = 1;
            matches2[7].Result = 1;
            matches2[8].Result = 1;
            matches2[9].Result = 1;

            var result2 = Match.MergeMatch(matches2, result1);
            Assert.AreEqual(20, result2.Length);

            Match[] matches3 = Match.MakeMatch(persons, result2);
            Assert.AreEqual(10, matches3.Length);
            Assert.AreEqual(1, matches3[0].Person1);
            Assert.AreEqual(5, matches3[0].Person2);
            Assert.AreEqual(9, matches3[1].Person1);
            Assert.AreEqual(13, matches3[1].Person2);
            Assert.AreEqual(17, matches3[2].Person1);
            Assert.AreEqual(2, matches3[2].Person2);
            Assert.AreEqual(3, matches3[3].Person1);
            Assert.AreEqual(6, matches3[3].Person2);
            Assert.AreEqual(7, matches3[4].Person1);
            Assert.AreEqual(10, matches3[4].Person2);
            Assert.AreEqual(11, matches3[5].Person1);
            Assert.AreEqual(14, matches3[5].Person2);
            Assert.AreEqual(15, matches3[6].Person1);
            Assert.AreEqual(18, matches3[6].Person2);
            Assert.AreEqual(19, matches3[7].Person1);
            Assert.AreEqual(4, matches3[7].Person2);
            Assert.AreEqual(8, matches3[8].Person1);
            Assert.AreEqual(12, matches3[8].Person2);
            Assert.AreEqual(16, matches3[9].Person1);
            Assert.AreEqual(20, matches3[9].Person2);

            matches3[0].Result = 1;
            matches3[1].Result = 1;
            matches3[2].Result = 1;
            matches3[3].Result = 1;
            matches3[4].Result = 1;
            matches3[5].Result = 1;
            matches3[6].Result = 1;
            matches3[7].Result = 1;
            matches3[8].Result = 1;
            matches3[9].Result = 1;

            var result3 = Match.MergeMatch(matches3, result2);
            Assert.AreEqual(30, result3.Length);
            //*/
        }

        [TestMethod()]
        public void MergeMatchTest()
        {
            Match[] matches1 = new Match[1];
            matches1[0] = new Match(1, 2);

            Match[] matches2 = new Match[2];
            matches2[0] = new Match(2, 3);
            matches2[1] = new Match(1, 4);

            var result1 = Match.MergeMatch(matches1, new Match[0]);
            Assert.AreEqual(1, result1.Length);

            var result2 = Match.MergeMatch(matches1, matches2);
            Assert.AreEqual(3, result2.Length);
            
        }


        /////////  独自に追加したメソッド
        [TestMethod()]
        public void GetKeyArrayTest()
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person { LotNumber = 1, PersonGroup = "A", PersonName = "安藤" });
            persons.Add(2, new Person { LotNumber = 2, PersonGroup = "A", PersonName = "伊藤" });
            persons.Add(3, new Person { LotNumber = 3, PersonGroup = "A", PersonName = "有働" });
            persons.Add(4, new Person { LotNumber = 4, PersonGroup = "B", PersonName = "遠藤" });
            persons.Add(5, new Person { LotNumber = 5, PersonGroup = "B", PersonName = "尾堂" });
            persons.Add(6, new Person { LotNumber = 6, PersonGroup = "C", PersonName = "加藤" });

            int[] result = Match.GetKeyArray(persons);
            Assert.AreEqual(6, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(5, result[4]);
            Assert.AreEqual(6, result[5]);
        }

        [TestMethod()]
        public void GetMinimumKeyTest()
        {
            int[][] keys = new int[1][];
            int[] key0 = { 1, 2, 3, 4, 5, 6 };
            keys[0] = key0;
            Match[] matches1 = new Match[0];
            Match[] matches2 = new Match[1];
            matches2[0] = new Match(1, 2);
            Match[] matches3 = new Match[2];
            matches3[0] = new Match(1, 2);
            matches3[1] = new Match(3, 6);

            var result1 = Match.GetMinimumKey(keys, matches1);
            Assert.AreEqual(1, result1);
            var result1_2 = Match.GetMinimumKey(keys, matches2);
            Assert.AreEqual(3, result1_2);
            var result1_3 = Match.GetMinimumKey(keys, matches3);
            Assert.AreEqual(4, result1_3);

            int[][] keys2 = new int[2][];
            int[] key1 = { 1, 2, 4 };
            int[] key2 = { 3, 5, 6 };
            keys2[0] = key1;
            keys2[1] = key2;
            var result3 = Match.GetMinimumKey(keys2, matches1);
            Assert.AreEqual(1, result3);
            var result4 = Match.GetMinimumKey(keys2, matches2);
            Assert.AreEqual(4, result4);
        }
        [TestMethod()]

        public void isSameGroupTest()
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person { LotNumber = 1, PersonGroup = "A", PersonName = "安藤" });
            persons.Add(2, new Person { LotNumber = 2, PersonGroup = "A", PersonName = "伊藤" });
            persons.Add(3, new Person { LotNumber = 3, PersonGroup = "A", PersonName = "有働" });
            persons.Add(4, new Person { LotNumber = 4, PersonGroup = "B", PersonName = "遠藤" });
            persons.Add(5, new Person { LotNumber = 5, PersonGroup = "B", PersonName = "尾堂" });
            persons.Add(6, new Person { LotNumber = 6, PersonGroup = "C", PersonName = "加藤" });
            Assert.AreEqual(true, Match.isSameGroup(persons, 1, 2));
            Assert.AreEqual(false, Match.isSameGroup(persons, 1, 4));
        }
        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]

        public void isSameGroupTest2()
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person { LotNumber = 1, PersonGroup = "A", PersonName = "安藤" });
            persons.Add(2, new Person { LotNumber = 2, PersonGroup = "A", PersonName = "伊藤" });
            persons.Add(3, new Person { LotNumber = 3, PersonGroup = "A", PersonName = "有働" });
            persons.Add(4, new Person { LotNumber = 4, PersonGroup = "B", PersonName = "遠藤" });
            persons.Add(5, new Person { LotNumber = 5, PersonGroup = "B", PersonName = "尾堂" });
            persons.Add(6, new Person { LotNumber = 6, PersonGroup = "C", PersonName = "加藤" });
            var result = Match.isSameGroup(persons, 1, 8);
        }

        [TestMethod()]
        public void makePersonArrayTest()
        {
            Dictionary<int, int> winCounts = new Dictionary<int, int>();
            winCounts.Add(1, 0);
            winCounts.Add(2, 0);
            winCounts.Add(3, 0);
            winCounts.Add(4, 0);

            var result = Match.makePersonArray(0, winCounts);
            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);

            Dictionary<int, int> winCounts2 = new Dictionary<int, int>();
            winCounts2.Add(1, 1);
            winCounts2.Add(2, 1);
            winCounts2.Add(3, 0);
            winCounts2.Add(4, 0);

            var result2 = Match.makePersonArray(0, winCounts2);
            Assert.AreEqual(2, result2.Length);
            Assert.AreEqual(3, result2[0]);
            Assert.AreEqual(4, result2[1]);
            var result3 = Match.makePersonArray(1, winCounts2);
            Assert.AreEqual(2, result3.Length);
            Assert.AreEqual(1, result3[0]);
            Assert.AreEqual(2, result3[1]);


        }

        [TestMethod()]
        public void splitPersonsTest()
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person { LotNumber = 1, PersonGroup = "A", PersonName = "安藤" });
            persons.Add(2, new Person { LotNumber = 2, PersonGroup = "A", PersonName = "伊藤" });
            persons.Add(3, new Person { LotNumber = 3, PersonGroup = "A", PersonName = "有働" });
            persons.Add(4, new Person { LotNumber = 4, PersonGroup = "B", PersonName = "遠藤" });
            persons.Add(5, new Person { LotNumber = 5, PersonGroup = "B", PersonName = "尾堂" });
            persons.Add(6, new Person { LotNumber = 6, PersonGroup = "C", PersonName = "加藤" });
            int[][] result = Match.splitPersons(persons, new Match[0]);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(6, result[0].Length);
            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(2, result[0][1]);
            Assert.AreEqual(3, result[0][2]);
            Assert.AreEqual(4, result[0][3]);
            Assert.AreEqual(5, result[0][4]);
            Assert.AreEqual(6, result[0][5]);

            Match[] matches = new Match[3];
            matches[0] = new Match(1, 4);
            matches[0].Result = 1;
            matches[1] = new Match(2, 5);
            matches[1].Result = 1;
            matches[2] = new Match(3, 6);
            matches[2].Result = 1;
            int[][] result2 = Match.splitPersons(persons, matches);
            Assert.AreEqual(2, result2.Length);
            Assert.AreEqual(3, result2[0].Length);
            Assert.AreEqual(3, result2[1].Length);
            Assert.AreEqual(1, result2[0][0]);
            Assert.AreEqual(2, result2[0][1]);
            Assert.AreEqual(3, result2[0][2]);
            Assert.AreEqual(4, result2[1][0]);
            Assert.AreEqual(5, result2[1][1]);
            Assert.AreEqual(6, result2[1][2]);

        }


        [TestMethod()]
        public void getVersusKey1Test()
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();
            persons.Add(1, new Person { LotNumber = 1, PersonGroup = "A", PersonName = "安藤" });
            persons.Add(2, new Person { LotNumber = 2, PersonGroup = "A", PersonName = "伊藤" });
            persons.Add(3, new Person { LotNumber = 3, PersonGroup = "A", PersonName = "有働" });
            persons.Add(4, new Person { LotNumber = 4, PersonGroup = "B", PersonName = "遠藤" });
            persons.Add(5, new Person { LotNumber = 5, PersonGroup = "B", PersonName = "尾堂" });
            persons.Add(6, new Person { LotNumber = 6, PersonGroup = "C", PersonName = "加藤" });
            int[] keys = Match.GetKeyArray(persons);
            int[][] SplittedKeys = Match.splitPersons(persons, new Match[0]);
            var result = Match.getVersusKey1(1, SplittedKeys, new Match[0], persons, new Match[0]);
            Assert.AreEqual(4, result);


        }
    }
}