// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;
using TDD_Katas_project.CA_CIB.Fruits;

namespace TDD_Katas_project.CA_CIB
{
    [TestFixture]
    [Category("CA_CIB")]
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
        public void CheckApple()
        {
            var apple = new Apple();
            Assert.That(apple.Quantity, Is.EqualTo(10), $"Quantite Apple, attendu : 10, lu : {apple.Quantity}");
            Assert.That(apple.UnitPrice, Is.EqualTo(25), $"UnitPrice Apple, attendu : 25, lu : {apple.UnitPrice}");
            Assert.That(apple.Total, Is.EqualTo(250), $"Total Apple, attendu : 250, lu : {apple.Total}");
        }

        [Test]
        public void CheckApple2()
        {
            var apple = new Apple();
            apple.Quantity = 20;
            Assert.That(apple.Quantity, Is.EqualTo(20), $"Quantite Apple, attendu : 10, lu : {apple.Quantity}");
            Assert.That(apple.UnitPrice, Is.EqualTo(25), $"UnitPrice Apple, attendu : 25, lu : {apple.UnitPrice}");
            Assert.That(apple.Total, Is.EqualTo(500), $"Total Apple, attendu : 250, lu : {apple.Total}");
        }
        #endregion
    }
}

