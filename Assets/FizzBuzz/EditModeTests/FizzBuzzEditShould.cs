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

        var result = systemUnderTest.process(1);
        Assert.AreEqual(expectedResult, result);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator FizzBuzzEditShouldWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
