// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;
using System.Linq;

namespace TDD_Katas_project.BlackJack
{
    [TestFixture]
    [Category("BlackJack")]
    public class Exercice3
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
        public void CheckBlackJack()
        {
            var firstCard = new Card("K");
            var secondCard = new Card("A");

            var hand = new Hand(firstCard, secondCard);

            Assert.That(hand.IsBlackJack, Is.EqualTo(true), $"Doit etre blackjack");

        }

        [Test]
        public void Check21PasBlackJack()
        {
            var firstCard = new Card("K");
            var secondCard = new Card("5");

            var hand = new Hand(firstCard, secondCard);

            hand.AddCard(new Card("6"));

            Assert.That(hand.IsBlackJack, Is.EqualTo(false), $"Doit etre blackjack");
        }

        [Test]
        public void CheckLosingHand()
        {
            var firstCard = new Card("K");
            var secondCard = new Card("K");

            var hand = new Hand(firstCard, secondCard);

            hand.AddCard(new Card("9"));

            Assert.That(hand.IsLosingHand, Is.EqualTo(true), $"Doit etre blackjack");
        }

        [Test]
        [TestCase("A","K")]
        [TestCase("K","K")]
        [TestCase("K","6")]
        public void CheckCorrectHand(string first, string second)
        {
            var firstCard = new Card(first);
            var secondCard = new Card(second);

            var hand = new Hand(firstCard, secondCard);
            
            Assert.That(hand.IsLosingHand, Is.EqualTo(false), $"Doit etre main non perdante");
        }
        #endregion
    }
}

