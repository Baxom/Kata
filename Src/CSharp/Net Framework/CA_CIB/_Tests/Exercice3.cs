// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;
using TDD_Katas_project.CA_CIB.Fruits;

namespace TDD_Katas_project.CA_CIB
{
    [TestFixture]
    [Category("CA_CIB")]
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
        public void CheckTruffe()
        {
            var truffe = new Truffes();
            Assert.That(truffe.Quantity, Is.EqualTo(8), $"Quantite Truffes, attendu : 8, lu : {truffe.Quantity}");
            Assert.That(truffe.UnitPrice, Is.EqualTo(80), $"UnitPrice Truffes, attendu : 80, lu : {truffe.UnitPrice}");
            Assert.That(truffe.Total, Is.EqualTo(640), $"Total Truffes, attendu : 640, lu : {truffe.Total}");
        }
        #endregion
    }
}

