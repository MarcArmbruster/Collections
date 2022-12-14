namespace TestProject.Collections.Collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void HashTableTest()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key1", "any value");
            hashtable.Add(1m, "value1m");
            hashtable.Add(1, 345.6456m);

            Assert.AreEqual(3, hashtable.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DuplicateKeyTest()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key1", "any value");
            hashtable.Add(1m, "value1m");
            hashtable.Add(1m, "value1m_again"); //should raise an argumentexception due to duplicate hash value for key

            Assert.AreEqual(3, hashtable.Count);
        }

        [TestMethod]
        public void LoadPerformanceBigTest()
        {
            for (int step = 1000000; step < 1000000; step += 10000)
            {
                Dictionary<long, string> dict = new Dictionary<long, string>();
                Hashtable hashtable = new Hashtable();

                Stopwatch stopwatchDict = new Stopwatch();
                Stopwatch stopwatchHash = new Stopwatch();

                // 1. fill Dictionary
                stopwatchDict.Start();
                foreach (int i in Enumerable.Range(0, 1000000))
                {
                    dict.Add(i, i.ToString());
                }
                stopwatchDict.Stop();

                // 2. fill HashTable
                stopwatchHash.Start();
                foreach (int i in Enumerable.Range(0, 1000000))
                {
                    hashtable.Add(i, i.ToString());
                }
                stopwatchHash.Stop();

                Assert.IsTrue(
                    stopwatchDict.ElapsedMilliseconds <= stopwatchHash.ElapsedMilliseconds,
                    $"Failed for {step}");
            }
        }
    }
}
