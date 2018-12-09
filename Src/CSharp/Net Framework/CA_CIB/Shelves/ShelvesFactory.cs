using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.CA_CIB.Shelves
{
    public static class ShelvesFactory
    {
        

        static  Dictionary<TypeShelves, Func<ShelveBase>> Factory = new Dictionary<TypeShelves, Func<ShelveBase>>()
            {

                { TypeShelves.Clothes, () => new ClotheShelve() },
                { TypeShelves.Electronics, () => new ElectronicShelve() },
                { TypeShelves.Fruits, () => new FruitShelve() },

            };


        public static ShelveBase CreateShelve(TypeShelves type)
        {
            if (!Factory.ContainsKey(type))
            {
                throw new ArgumentOutOfRangeException("typeShelves not existing");
            }

            Func<int, int> f = ShelvesFactory.Fois2;
            Func<int, int> f2 = n => n * 2;
            
            return Factory[type]();
        }

        public static int Fois2(int n)
        {
            return n * 2;
        }

        
    }
}
