namespace TDD_Katas_project.CA_CIB.Fruits
{
    public interface IProduct
    {
         int UnitPrice { get; set; }
         int Quantity { get; set; }
         int Total { get; }
    }

    public interface IPromotionnable
    {
        Promotion Promotion { get; set; }
        void ApplyPromotion(Promotion promotion);
    }
}