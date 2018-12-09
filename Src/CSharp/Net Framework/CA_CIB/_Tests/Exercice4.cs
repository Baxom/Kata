// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using NUnit.Framework;
using TDD_Katas_project.CA_CIB.Fruits;

namespace TDD_Katas_project.CA_CIB
{
    [TestFixture]
    [Category("CA_CIB")]
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
        public void CheckCreateElectronicShelve()
        {
            var shelve = Shelves.ShelvesFactory.CreateShelve(Shelves.TypeShelves.Electronics);
            Assert.That(shelve.Type, Is.EqualTo(Shelves.TypeShelves.Electronics), $"Erreur création electronic shelve");
            
        }


        [Test]
        public void CheckCreateFruitShelve()
        {
            var shelve = Shelves.ShelvesFactory.CreateShelve(Shelves.TypeShelves.Fruits);
            Assert.That(shelve.Type, Is.EqualTo(Shelves.TypeShelves.Fruits), $"Erreur création fruit shelve");

        }


        [Test]
        public void CheckCreateElectronicClothes()
        {
            var shelve = Shelves.ShelvesFactory.CreateShelve(Shelves.TypeShelves.Clothes);
            Assert.That(shelve.Type, Is.EqualTo(Shelves.TypeShelves.Clothes), $"Erreur création clothe shelve");

        }

        [Test]
        public void CheckCreateNewInstance()
        {

        }
        #endregion
    }
}

