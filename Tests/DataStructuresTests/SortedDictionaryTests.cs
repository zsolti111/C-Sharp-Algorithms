namespace Tests.DataStructuresTests
{
    using DataStructures.SortedCollections;
    using NUnit.Framework;

    /// <summary>
    /// SortedDictonary datastructure tests.
    /// </summary>
    [TestFixture]
    public class SortedDictionaryTests
    {
        /// <summary>
        /// Test for adding elements, into a SortedDictionary.
        /// </summary>
        [Test]
        public void AddElementTest()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            Assert.AreEqual(true, sortedDictionary.IsEmpty);

            sortedDictionary.Add("A", 1);
            sortedDictionary.Add("B", 2);
            sortedDictionary.Add("C", 3);

            Assert.AreEqual(3, sortedDictionary.Count, "Wrong number of elements in the dictionary.");
            Assert.AreEqual(1, sortedDictionary["A"]);
            Assert.AreEqual(2, sortedDictionary["B"]);
            Assert.AreEqual(3, sortedDictionary["C"]);
        }

        [Test]
        public void AddSameElementsWithExistingKey()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            sortedDictionary.Add("A", 1);

            Assert.Throws<System.InvalidOperationException>(() => sortedDictionary.Add("A", 2));
            Assert.AreEqual(1, sortedDictionary.Count, "Wrong number of elements in the dictionary.");
            Assert.AreEqual(1, sortedDictionary["A"]);

        }

        [Test]
        public void ChangeElementThenVerify()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            sortedDictionary.Add("A", 1);
            sortedDictionary.Add("B", 2);

            sortedDictionary["A"] = 5;
            sortedDictionary["B"] = 10;

            Assert.AreEqual(5, sortedDictionary["A"], "Element value not changed.");
            Assert.AreEqual(10, sortedDictionary["B"], "Element value not changed.");
        }
    }
}
