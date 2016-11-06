using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using C_Sharp_Algorithms.AlgorithmsTests;
using C_Sharp_Algorithms.DataStructuresTests;
using FsCheck;

namespace C_Sharp_Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // SortedDictionaryTests tests

            var maxLength = 10;

            Arb.Generate<string>().Sample(maxLength, 1).Single();

            SortedDictionaryTests.DoTest();

        }
    }
}
