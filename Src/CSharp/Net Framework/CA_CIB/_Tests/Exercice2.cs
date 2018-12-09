// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;
using TDD_Katas_project.CA_CIB.Fruits;

namespace TDD_Katas_project.CA_CIB
{
    [TestFixture]
    [Category("CA_CIB")]
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
        public void CheckPasta()
        {
            var pasta = new Pasta();
            Assert.That(pasta.Quantity, Is.EqualTo(50), $"Quantite Pasta, attendu : 50, lu : {pasta.Quantity}");
            Assert.That(pasta.UnitPrice, Is.EqualTo(12), $"UnitPrice Pasta, attendu : 12, lu : {pasta.UnitPrice}");
            Assert.That(pasta.Total, Is.EqualTo(600), $"Total Pasta, attendu : 600, lu : {pasta.Total}");
        }
        #endregion
    }
}

