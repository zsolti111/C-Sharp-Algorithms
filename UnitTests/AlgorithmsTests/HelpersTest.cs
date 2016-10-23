using Algorithms.Common;
using DataStructures.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.AlgorithmsTests
{
    [TestClass]
    public class HelpersTest
    {

        /// <summary>
        /// Test the swap method with IList
        /// </summary>
        [TestMethod]
        public void Swap1_Test()
        {
            IList<int> testList = new int[] { 1, 2, 3, 4, 5, 6 };
            int firstindex = 3;
            int secondindex = 4;

            Helpers.Swap<int>(testList, firstindex, secondindex);

            Assert.AreEqual(5, testList.ElementAt(3));
            Assert.AreEqual(4, testList.ElementAt(4));

        }


        /// <summary>
        /// Test the swap method with ArrayList
        /// </summary>
        [TestMethod]
        public void Swap2_Test()
        {
            ArrayList<int> testList = new ArrayList<int> { 1, 2, 3, 4, 5, 6 };
            int firstindex = 3;
            int secondindex = 4;

            Helpers.Swap<int>(testList, firstindex, secondindex);

            Assert.AreEqual(5, testList.ElementAt(3));
            Assert.AreEqual(4, testList.ElementAt(4));

        }

        /// <summary>
        /// Test the populate method 
        /// </summary>
        [TestMethod]
        public void Populate_Test()
        {
            IList<int> testList = new int[] { 1, 2, 3, 4, 5, 6 };


            Helpers.Populate(testList, 9);

            foreach (var item in testList)
            {
                Assert.AreEqual(9, item);
            }

        }


    }
}
