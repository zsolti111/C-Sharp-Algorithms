namespace UnitTests.AlgorithmsTests
{
    using Algorithms.Numeric;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Greates common divisor tests.
    /// </summary>
    [TestClass]
    public class GreatestCommonDivisorTest
    {
        /// <summary>
        /// Test greatest common divisors algorithms.
        /// </summary>
        [TestMethod]
        public void GreatestCommonDivisorAlgorithmTest()
        {
            uint a = 10;
            uint b = 5;

            int GCD = (int)GreatestCommonDivisor.FindGCD(a, b);
            Assert.AreEqual(5, GCD);

            a = 154;
            b = 77;

            GCD = (int)GreatestCommonDivisor.FindGCD(a, b);
            Assert.AreEqual(77, GCD);

            a = 582;
            b = 168;

            GCD = (int)GreatestCommonDivisor.FindGCD(a, b);
            Assert.AreEqual(6, GCD);
        }

        /// <summary>
        /// Test GreatesCommonDivisor algortihm with primes.
        /// </summary>
        [TestMethod]
        public void GreatestCommonDivisorWithPrimesTest()
        {
            uint a = 79; // is prime
            uint b = 128;

            int GCD = (int)GreatestCommonDivisor.FindGCD(a, b);
            Assert.AreEqual(1, GCD);

            a = 1193; // is prime
            b = 2222;

            GCD = (int)GreatestCommonDivisor.FindGCD(a, b);
            Assert.AreEqual(1, GCD);

            a = 1553; // is prime
            b = 1559; // is prime

            GCD = (int)GreatestCommonDivisor.FindGCD(a, b);
            Assert.AreEqual(1, GCD);
        }

        /// <summary>
        /// Test IsRelativlyPrime algorithm.
        /// </summary>
        [TestMethod]
        public void IsRelativlyPrimeTest()
        {
            uint a = 31;
            uint b = 36;

            Assert.AreEqual(true, GreatestCommonDivisor.IsRelativelyPrime(a, b));

            a = 128;
            b = 28;

            Assert.AreEqual(false, GreatestCommonDivisor.IsRelativelyPrime(a, b));

            a = 13;   // is prime
            b = 1559; // is prime

            Assert.AreEqual(true, GreatestCommonDivisor.IsRelativelyPrime(a, b));
        }
    }
}
