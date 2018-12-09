// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;
using TDD_Katas_project.CA_CIB.Fruits;

namespace TDD_Katas_project.BlackJack
{
    [TestFixture]
    [Category("BlackJack")]
    public class Exercice2
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
        public void CheckValueHand()
        {
            var firstCard = new Card("K");
            var secondCard = new Card("7");

            var hand = new Hand(firstCard, secondCard);

            Assert.That(hand.Points, Is.EqualTo(17), $"Quantite Pasta, attendu : 17, lu : {hand.Points}");
            
        }

        [Test]
        public void CheckValueHand4Card()
        {
            var firstCard = new Card("2");
            var secondCard = new Card("7");

            var hand = new Hand(firstCard, secondCard);

            hand.AddCard(new Card("3"));
            hand.AddCard(new Card("4"));

            Assert.That(hand.Points, Is.EqualTo(17), $"Quantite Pasta, attendu : 17, lu : {hand.Points}");
        }
        #endregion
    }
}

