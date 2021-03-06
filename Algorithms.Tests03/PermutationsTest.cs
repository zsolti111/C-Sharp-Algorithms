// <copyright file="PermutationsTest.cs">ahmadalhour</copyright>
using System;
using Algorithms.Strings;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Strings.Tests
{
    /// <summary>This class contains parameterized unit tests for Permutations</summary>
    [PexClass(typeof(Permutations))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PermutationsTest
    {
        /// <summary>Test stub for IsAnargram(String, String)</summary>
        [PexMethod]
        public bool IsAnargramTest(string Source, string Other)
        {
            bool result = Permutations.IsAnargram(Source, Other);
            return result;
            // TODO: add assertions to method PermutationsTest.IsAnargramTest(String, String)
        }
    }
}
