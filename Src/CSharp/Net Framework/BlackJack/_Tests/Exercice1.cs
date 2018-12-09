// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;

namespace TDD_Katas_project.BlackJack
{
    [TestFixture]
    [Category("BlackJack")]
    public class Exercice1
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
        [TestCase("A", 11)]
        [TestCase("K", 10)]
        [TestCase("Q", 10)]
        [TestCase("J", 10)]
        [TestCase("10", 10)]
        [TestCase("9", 9)]
        [TestCase("8", 8)]
        [TestCase("7", 7)]
        [TestCase("6", 6)]
        [TestCase("5", 5)]
        [TestCase("4", 4)]
        [TestCase("3", 3)]
        [TestCase("2", 2)]
        public void CheckValueCard(string s, int valeur)
        {
            var card = new Card(s);
            Assert.That(card.Points, Is.EqualTo(valeur), $"Valeur attendu pour carte {s} : {valeur}");
        }
        
        #endregion
    }
}

