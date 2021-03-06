// <copyright file="GreatestCommonDivisorTest.cs">ahmadalhour</copyright>

using System;
using Algorithms.Numeric;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Numeric.Tests
{
    [TestClass]
    [PexClass(typeof(GreatestCommonDivisor))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GreatestCommonDivisorTest
    {

        [PexMethod]
        public uint FindGCD(uint a, uint b)
        {
            uint result = GreatestCommonDivisor.FindGCD(a, b);
            return result;
            // TODO: add assertions to method GreatestCommonDivisorTest.FindGCD(UInt32, UInt32)
        }

        [PexMethod]
        public bool IsRelativelyPrime(uint a, uint b)
        {
            bool result = GreatestCommonDivisor.IsRelativelyPrime(a, b);
            return result;
            // TODO: add assertions to method GreatestCommonDivisorTest.IsRelativelyPrime(UInt32, UInt32)
        }
    }
}
