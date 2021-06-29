using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
public class FizzBuzzEditShould
{
    [Test]
    public void ProcessReturnNumber1AsString()
    {
        var systemUnderTest = new GameObject().AddComponent<FizzBuzz.FizzBuzzScripts.FizzBuzz>();
        string expectedResult = "1";

        var result = systemUnderTest.Process(1);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void ProcessReturnsFizzIfNumberDividableBy3Provided(int number)
    {
        var systemUnderTest = new GameObject().AddComponent<FizzBuzz.FizzBuzzScripts.FizzBuzz>();
        string expectedResult = "Fizz";

        var result = systemUnderTest.Process(number);
        Assert.AreEqual(expectedResult, result);
    }
}
