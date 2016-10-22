namespace UnitTests.AlgorithmsTests
{
    using Algorithms.Strings;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class PermutationTest
    {

        /// <summary>
        /// Test two string are anagrams.
        /// </summary>
        [TestMethod]
        public void VerifyTwoStringAreAnagramTest()
        {
            var str1 = "anagram";
            var str2 = "aaagmnr";

            Assert.AreEqual(true, Permutations.IsAnargram(str1, str2));

            str1 = "edward daniels";
            str2 = "andrew laeddis";

            Assert.AreEqual(true, Permutations.IsAnargram(str1, str2));
        }

        /// <summary>
        /// Test two string are not anagrams
        /// </summary>
        [TestMethod]
        public void VerifyTwoStringAreNotAnagramTest()
        {
            var str1 = "alpha";
            var str2 = "beta";

            Assert.AreEqual(false, Permutations.IsAnargram(str1, str2));

            str1 = "gamma";
            str2 = "delta";

            Assert.AreEqual(false, Permutations.IsAnargram(str1, str2));
        }

        /// <summary>
        /// Verify IsAnagram is case-sensitive
        /// </summary>
        [TestMethod]
        public void AngaramIsCaseSensitiveTest()
        {
            var str1 = "ABCDEFGH";
            var str2 = "abcdefgh";
            Assert.AreEqual(false, Permutations.IsAnargram(str1, str2));

            str1 = str1.ToLower();
            Assert.AreEqual(true, Permutations.IsAnargram(str1, str2));

            str1 = str1.ToUpper();
            str2 = str2.ToUpper();
            Assert.AreEqual(true, Permutations.IsAnargram(str1, str2));
        }

        /// <summary>
        /// Number of permutations of a string 
        /// </summary>
        [TestMethod]
        public void NumberOfPermutationsTest()
        {
            //// TODO: Permutations.ComputeDistinct(string) methode is not working correctly.
            //// Tests are failed!

            var str1 = "string";
            var str2 = "random";

            var permutation = Permutations.ComputeDistinct(str1);
            var permutation2 = Permutations.ComputeDistinct(str2);

            Assert.AreEqual(true, permutation.Count == permutation2.Count);
            Assert.AreEqual(720, permutation.Count);

            str1 = "word";
            permutation = Permutations.ComputeDistinct(str1);
            Assert.AreEqual(24, permutation.Count);

            str1 = "aaaaaa";
            permutation = Permutations.ComputeDistinct(str1);
            Assert.AreEqual(1, permutation.Count);

            str1 = "aAAa";
            permutation = Permutations.ComputeDistinct(str1);
            Assert.AreEqual(6, permutation.Count);

            str1 = "aaabccdd";
            permutation = Permutations.ComputeDistinct(str1);
            Assert.AreEqual(1680, permutation.Count);
        }

    }
}
