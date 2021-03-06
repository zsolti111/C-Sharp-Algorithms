using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="PermutationsTest.IsAnargram.g.cs">ahmadalhour</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Algorithms.Strings.Tests
{
    public partial class PermutationsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(PermutationsTest))]
public void IsAnargram253()
{
    bool b;
    b = this.IsAnargram((string)null, (string)null);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(PermutationsTest))]
public void IsAnargram154()
{
    bool b;
    b = this.IsAnargram("\0", (string)null);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(PermutationsTest))]
public void IsAnargram248()
{
    bool b;
    b = this.IsAnargram("\0", "\0");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(PermutationsTest))]
public void IsAnargram930()
{
    bool b;
    b = this.IsAnargram("", "\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(PermutationsTest))]
public void IsAnargram158()
{
    bool b;
    b = this.IsAnargram("\0\0", "\0");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(PermutationsTest))]
public void IsAnargram548()
{
    bool b;
    b = this.IsAnargram("\0\0 ", "￻怂 က怂");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(PermutationsTest))]
public void IsAnargram62()
{
    bool b;
    b = this.IsAnargram("現", "現");
    Assert.AreEqual<bool>(true, b);
}
    }
}
