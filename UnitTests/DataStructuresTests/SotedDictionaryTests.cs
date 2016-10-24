namespace Tests.DataStructuresTests
{
    using DataStructures.SortedCollections;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// SortedDictonary datastructure tests.
    /// </summary>
    [TestClass]
    public class SortedDictionaryTests
    {
        /// <summary>
        /// Test for adding elements, into a SortedDictionary.
        /// </summary>
        [TestMethod]
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

        /// <summary>
        /// Add two elements with same keys.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void AddSameElementsWithExistingKeyTest()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            sortedDictionary.Add("A", 1);

            // Throws InvalidOperationExceptions
            sortedDictionary.Add("A", 2); 
        }

        /// <summary>
        /// Change elements value tests.
        /// </summary>
        [TestMethod]
        public void ChangeElementThenVerifyTest()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            sortedDictionary.Add("A", 1);
            sortedDictionary.Add("B", 2);

            sortedDictionary["A"] = 5;
            sortedDictionary["B"] = 10;

            Assert.AreEqual(5, sortedDictionary["A"], "Element value not changed.");
            Assert.AreEqual(10, sortedDictionary["B"], "Element value not changed.");
        }

        /// <summary>
        /// Test for removing elements.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void RemoveElemetTest()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            sortedDictionary.Add("A", 1);
            sortedDictionary.Add("B", 2);

            Assert.AreEqual(2, sortedDictionary.Count);

            sortedDictionary.Remove("B");
            Assert.AreEqual(false, sortedDictionary.ContainsKey("B"));
            Assert.AreEqual(1, sortedDictionary.Count, "Element number is wrong.");

            // sortedDictionary["B"] thorws KeyNotFoundException
            var valueB = sortedDictionary["B"];
        }

        /// <summary>
        /// Fill sortedDictionary with elements, and clear them.
        /// </summary>
        [TestMethod]
        public void ClearSortedDictionaryTest()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            sortedDictionary.Add("A", 1);
            sortedDictionary.Add("B", 2);
            sortedDictionary.Add("C", 3);

            Assert.AreEqual(3, sortedDictionary.Count);
            sortedDictionary.Clear();

            Assert.AreEqual(true, sortedDictionary.IsEmpty);
            Assert.AreEqual(0, sortedDictionary.Count, "sortedDictionary is not empty");
        }

        /// <summary>
        /// Test SortedDictionary Values
        /// </summary>
        [TestMethod]
        public void GetValuesTests()
        {
            var sortedDictionary = new SortedDictionary<string, int>();

            sortedDictionary.Add("A", 1);
            sortedDictionary.Add("B", 2);

            var values = sortedDictionary.Values;

            Assert.AreEqual(2, values.Count);
            Assert.AreEqual(true, values.Contains(1));
            Assert.AreEqual(true, values.Contains(2));
        }
    }
}
