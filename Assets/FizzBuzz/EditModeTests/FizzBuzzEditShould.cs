using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FizzBuzzEditShould
{
    [Test]
    public void ProcessReturnNumber1AsString()
    {
        var systemUnderTest = new GameObject().AddComponent<FizzBuzz>();
        string expectedResult = "1";

        var result = systemUnderTest.Process(1);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void ProcessReturnsFizzIf3Provided()
    {
        var systemUnderTest = new GameObject().AddComponent<FizzBuzz>();
        string expectedResult = "Fizz";

        var result = systemUnderTest.Process(3);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void ProcessReturnsFizzIf6Provided()
    {
        var systemUnderTest = new GameObject().AddComponent<FizzBuzz>();
        string expectedResult = "Fizz";

        var result = systemUnderTest.Process(6);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void ProcessReturnsFizzIf9Provided()
    {
        var systemUnderTest = new GameObject().AddComponent<FizzBuzz>();
        string expectedResult = "Fizz";

        var result = systemUnderTest.Process(9);
        Assert.AreEqual(expectedResult, result);
    }
}
