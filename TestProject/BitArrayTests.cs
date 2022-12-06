namespace TestProject
{
    using System.Collections;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BitArrayTests
    {
        [TestMethod]
        public void BitArrayTest()
        {
            BitArray bitArrayOne = new BitArray(5, true);
            BitArray bitArrayTwo = new BitArray(new bool[5] { true, true, true, true, true });

            CollectionAssert.AreEqual(bitArrayOne, bitArrayTwo);
        }

        [TestMethod]
        public void BitArrayNotTest()
        {
            BitArray bitArrayOne = new BitArray(5, false);
            BitArray bitArrayTwo = new BitArray(new bool[5] { true, true, true, true, true });

            CollectionAssert.AreEqual(bitArrayOne.Not(), bitArrayTwo);            
        }
    }
}
