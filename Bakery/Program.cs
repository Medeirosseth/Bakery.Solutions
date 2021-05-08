using System;
using Bakery.Models;
using BakeryPastry;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\n");
      Console.WriteLine("\n");
      Console.WriteLine(" - --'-(@ Welcome to Pierre's Bakery --,-(@ -");
      Console.WriteLine(" -                                          -");
      Console.WriteLine(" -     (☞ﾟヮﾟ)☞  Todays Specials  ☜(ﾟヮﾟ☜)   -");
      Console.WriteLine(" -              ----------------            -");
      Console.WriteLine(" -                  Baguettes:              -");
      Console.WriteLine(" -           Buy 2 get 1 free for $10       -");
      Console.WriteLine(" -                    Or                    -");
      Console.WriteLine(" -             1 Baguette for $5            -");
      Console.WriteLine(" -                                          -");
      Console.WriteLine(" -                  Pastries:               -");
      Console.WriteLine(" -           Buy 2 get 1 1/2 Off $5         -");
      Console.WriteLine(" -                    Or                    -");
      Console.WriteLine(" -             1 Pastry for $2              -");
      Console.WriteLine("\n");
      Console.WriteLine("If you are here for Baguettes enter[\"B\"]");
      Console.WriteLine("If you are here for Pastries enter[\"P\"]");
      Console.WriteLine("\n");
      string userAnswer = Console.ReadLine();
      if(userAnswer == "B" || userAnswer == "b")
      {
        Console.WriteLine(" How many Baguettes will you be purchasing today");
        Console.WriteLine(" Enter number below then press enter");
        string userQuantity = Console.ReadLine();
        CostOfBread();
      }

    
    }
  }
}

