using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.CA_CIB.Shelves
{
    public abstract class ShelveBase
    {
        public TypeShelves Type { get; private set; }

        public ShelveBase(TypeShelves type)
        {
            Type = type;
        }
    }
}
