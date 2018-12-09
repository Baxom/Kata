using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.CA_CIB.Fruits
{
    public abstract class Aliment: IProduct, IPromotionnable
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Promotion Promotion { get; set; }

        public int Total
        {
            get
            {
                return Quantity * (UnitPrice - Promotion.Apply(UnitPrice));
            }
        }

        public Aliment(int qte, int prixUnitaire)
        {
            Quantity = qte;
            UnitPrice = prixUnitaire;
        }

        public virtual void ApplyPromotion(Promotion promotion)
        {
            Promotion = promotion;
        }
        

    }
}
