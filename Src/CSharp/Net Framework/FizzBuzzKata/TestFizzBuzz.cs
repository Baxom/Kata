// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;

namespace TDD_Katas_project.FizzBuzzKata
{
    [TestFixture]
    [Category("TheFizzBuzzKata")]
    public class TestFizzBuzz
    {
        #region Private members
        private string _resultFizz;
        #endregion

        #region Setup/TearDown
        [TestFixtureSetUp]
        public void Setup()
        {
        }
        [TestFixtureTearDown]
        public void TearDown()
        {
        }
        #endregion

        #region Test Methods
        
        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(49, "Qix")]
        [TestCase(30, "FizzBuzz")]
        public void CanTestSingleNumber(int number, string expectedresult)
        {
            var actualresult = new FizzBuzz().PrintFizzBuzz(number);
            Assert.That(actualresult, Is.EqualTo(expectedresult),
                             string.Format("result of entered number [{0}] is [{1}] but it should be [{2}]", number,
                                           actualresult, expectedresult));
        }
        #endregion
    }
}

