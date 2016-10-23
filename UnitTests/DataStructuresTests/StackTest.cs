using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Lists;

namespace UnitTests.DataStructuresTests
{
    [TestClass]
    public class StackTest
    {



        /// <summary>
        /// Test the IsEmpty method of the Stack class, if empty
        /// </summary>
        [TestMethod]
        public void IsEmpty_Empty_Test()
        {
            var stackTest = new DataStructures.Lists.Stack<int>();

            Assert.AreEqual(true, stackTest.IsEmpty);

        }

        /// <summary>
        /// Test the IsEmpty method of the Stack class, if not empty
        [TestMethod]
        public void IsEmpty_NotEmpty_Test()
        {
            var stackTest = new DataStructures.Lists.Stack<int>();
            stackTest.Push(1);

            Assert.AreEqual(false, stackTest.IsEmpty);

        }

        /// <summary>
        /// Test the Top method correct working
        [TestMethod]
        public void Top_Test()
        {
            var stackTest = new DataStructures.Lists.Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                stackTest.Push(i);
            }

            Assert.AreEqual(9, stackTest.Top);
        }


        /// <summary>
        /// Test the Push method correct working
        [TestMethod]
        public void Push_Test()
        {
            var stackTest = new DataStructures.Lists.Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                stackTest.Push(i);
            }
            stackTest.Push(1000);
            var stackTestLastItem = stackTest.First();

            Assert.AreEqual(1000, stackTestLastItem);
        }




        /// <summary>
        /// Test the Pop method correct working
        [TestMethod]
        public void Pop_Test()
        {
            var stackTest = new DataStructures.Lists.Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                stackTest.Push(i);
            }

            stackTest.Pop();
            Assert.AreEqual(8, stackTest.First());
            Assert.AreEqual(9, stackTest.Count);
        }


    }
}
