using System.Collections.Generic;
// <copyright file="PermutationsTest.cs">ahmadalhour</copyright>

using System;
using Algorithms.Strings;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Strings.Tests
{
    [TestClass]
    [PexClass(typeof(Permutations))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PermutationsTest
    {

        [PexMethod]
        public bool IsAnargram(string Source, string Other)
        {
            bool result = Permutations.IsAnargram(Source, Other);
            return result;
            // TODO: add assertions to method PermutationsTest.IsAnargram(String, String)
        }

        [PexMethod]
        public HashSet<string> ComputeDistinct(string Source)
        {
            HashSet<string> result = Permutations.ComputeDistinct(Source);
            return result;
            // TODO: add assertions to method PermutationsTest.ComputeDistinct(String)
        }
    }
}
