namespace TestProject.Collections.Collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackTest()
        {
            Stack stack = new Stack();

            stack.Push("One");
            stack.Push(2m);
            stack.Push(3L);

            Assert.AreEqual(3L, stack.Pop());
            Assert.AreEqual(2m, stack.Pop());
            Assert.AreEqual("One", stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StackExceptionTest()
        {
            Stack stack = new Stack();

            stack.Push("One");

            Assert.AreEqual("One", stack.Pop());
            stack.Pop(); // will raise an InvalidOperationException
        }
    }
}
