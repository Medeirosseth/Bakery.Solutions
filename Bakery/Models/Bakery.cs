using System;
namespace Bakery.Models

{

  public class Bread
  {
    
  
    public int BreadPurchased { get; set; }
    public Bread(int breadPurchased)
    {
      BreadPurchased = breadPurchased;

    }
        public int CostOfBread()
    {
     if (BreadPurchased < 3 ) 
     {
       int BreadCostTotal = (BreadPurchased * 5);
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

  public class Pastry
  {
    public int PastriesPurchased { get; set; }
   
    public Pastry(int pastriesPurchased)
    {
      PastriesPurchased = pastriesPurchased;
    }
  }

  
}