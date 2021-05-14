namespace PierresBakery.Models
{
public class Pastry
  {
    public int PastriesPurchased { get; set; }
   
    public Pastry(int pastriesPurchased)
    {
      PastriesPurchased = pastriesPurchased;
    }

    public int CostOfPastry()
    {
      if(PastriesPurchased < 3)
      {
        int PastryCostTotal = (PastriesPurchased * 2);
        return PastryCostTotal;
      }
      else if ( PastriesPurchased % 3 == 0)
      {
        int PastryCostTotal = ((PastriesPurchased / 3) * 5);
        return PastryCostTotal;
      }
      else  
      {
        int PastryCostTotal = ((((PastriesPurchased - (PastriesPurchased % 3)) / 3) * 5) + ((PastriesPurchased % 3) * 2));
        return PastryCostTotal;
      }
   
      
    }
  }
}