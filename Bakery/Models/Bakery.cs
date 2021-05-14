namespace PierresBakery.Models
{
    public class Bread
  {
    public int BreadPurchased { get; set; }
    public Bread(int breadPurchased)
    {
      BreadPurchased = breadPurchased;

    }
        public int CostOfBread(int breadTotal)
    {
     if (BreadPurchased < 3 ) 
     {
       int BreadCostTotal = (BreadPurchased * 5);
       return BreadCostTotal;
     }
     else if (BreadPurchased % 3 == 0)
     {
       int BreadCostTotal = ((BreadPurchased / 3) * 10);
       return BreadCostTotal;
     }
     else if (BreadPurchased % 3 != 0  )
     {
       int BreadCostTotal = ((((BreadPurchased - (BreadPurchased % 3)) / 3) * 10 ) + ((BreadPurchased % 3) * 5));
       return BreadCostTotal;
     }
     else
     {
       return BreadPurchased;
     }
    }
  }
  
}