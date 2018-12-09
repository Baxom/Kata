using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.CA_CIB.Fruits
{
    public class Promotion
    {
        public int Type { get; set; } // Pourcentage ou valeur fixe
        public int Valeur { get; set; }

        public Promotion()
        {

        }

        public int Apply(int montant)
        {
            int montantPromo = 0;

            switch (Type)
            {
                case 1:// valeur
                    montantPromo = Valeur;
                    break;
                case 2:
                    montantPromo = montant * Valeur / 100;
                    break;
            }
            return  montantPromo;
        }
    }
}
