namespace BakeryPastry.Models
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
      else
      {
        int hello = 55;
        return hello;
      }
    }
  }
}