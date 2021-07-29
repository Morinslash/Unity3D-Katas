using NUnit.Framework;
using UnityEngine;

namespace FizzBuzz.EditModeTests
{
    public class FizzBuzzEditShould
    {
        private FizzBuzz.FizzBuzzScripts.FizzBuzz _systemUnderTest;

        [SetUp]
        public void Init()
        {
            _systemUnderTest = new GameObject().AddComponent<FizzBuzz.FizzBuzzScripts.FizzBuzz>();
        }
        [Test]
        public void ProcessReturnNumber1AsString()
        {
            string expectedResult = "1";

            var result = _systemUnderTest.Process(1);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void ProcessReturnsFizzIfNumberDividableBy3Provided(int number)
        {
            string expectedResult = "Fizz";

            var result = _systemUnderTest.Process(number);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void ProcessReturnsBuzzIfNumberDividableBy5Provided(int number)
        {
            string expectedResult = "Buzz";

            var result = _systemUnderTest.Process(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
