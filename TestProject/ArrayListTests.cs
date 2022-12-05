namespace TestProject
{
    using System.Collections;

    [TestClass]
    public class ArrayListTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList list = new ArrayList();
            list.Add("one");
            list.Add(5);
            list.Add(7.45m);

            Assert.AreEqual(3, list.Count);
        }
    }
}