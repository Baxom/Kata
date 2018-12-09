// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;
using System.Linq;
namespace TDD_Katas_project.BlackJack
{
    [TestFixture]
    [Category("BlackJack")]
    public class Exercice4
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
        [TestCase("un AS en dessous 21", new string[2] { "A", "5" }, 16)]
        [TestCase("un AS au dessus 21", new string[3] { "A", "6", "J" }, 17)]
        [TestCase("Cinq AS", new string[5] { "A", "A", "A", "A", "A" }, 15)]
        public void CheckValueHand(string nom, string[] cards, int valeur)
        {
            var cardList = cards.Select(c => new Card(c));

            var hand = new Hand(cardList.First(), cardList.Skip(1).First());

            foreach (var c in cardList.Skip(2))
            {
                hand.AddCard(c);
            }

            Assert.That(hand.Points, Is.EqualTo(valeur), $"{nom}, attendu : {valeur}, lu : {hand.Points}");
        }



        #endregion
    }
}

