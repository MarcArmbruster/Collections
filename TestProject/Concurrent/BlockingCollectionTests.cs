namespace TestProject.Concurrent
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BlockingCollectionTests
    {
        [TestMethod]
        public void BlockingCollectionTest()
        {
            BlockingCollection<string> blockingCollection = new BlockingCollection<string>(4);
            blockingCollection.Add("a");
            blockingCollection.Add("b");
            blockingCollection.Add("c");
            blockingCollection.Add("d");

            Assert.AreEqual(4, blockingCollection.Count);
        }

        [TestMethod]
        public void BlockingCollectionOverflowTest()
        {
            BlockingCollection<string> blockingCollection = new BlockingCollection<string>(4);
            blockingCollection.Add("a");
            blockingCollection.Add("b");
            blockingCollection.Add("c");
            blockingCollection.Add("d");
            bool added = blockingCollection.TryAdd("e");
            Assert.IsFalse(added);

            blockingCollection.CompleteAdding();
            Assert.IsTrue(blockingCollection.IsAddingCompleted);
        }
    }
}
