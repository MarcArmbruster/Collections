namespace TestProject.Collections.Collections
{
    using System.Collections;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("zwei");
            queue.Enqueue(3m);

            var first = queue.Dequeue();
            Assert.AreEqual(1, first);

            var second = queue.Dequeue();
            Assert.AreEqual("zwei", second);

            var third = queue.Dequeue();
            Assert.AreEqual(3m, third);
        }
    }
}
