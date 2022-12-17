namespace TestProject.Collections.Collections
{
    using System.Collections;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SortedListTests
    {
        private class NumericComparer : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x == null || y== null)
                {
                    return 0;
                }

                if (decimal.TryParse(x.ToString(), out decimal first)
                    && decimal.TryParse(y.ToString(), out decimal second))
                {
                    return decimal.Compare(first, second);
                }

                return 0;
            }
        }

        [TestMethod]
        public void SortedListTest()
        {
            IComparer comparer = new NumericComparer();

            SortedList sortedList = new SortedList(comparer);
            sortedList.Add(2, "two");
            sortedList.Add(4L, "four");
            sortedList.Add("1", 1);
            sortedList.Add(3m, 3m);

            Assert.AreEqual(1, sortedList.GetByIndex(0));
            Assert.AreEqual("two", sortedList.GetByIndex(1));
            Assert.AreEqual(3m, sortedList.GetByIndex(2));
            Assert.AreEqual("four", sortedList.GetByIndex(3));
        }
    }
}
