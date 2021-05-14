using System;
using static System.Console;
using PierresBakery.Models;



namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    { 
      
      Console.WriteLine("\n");
      Console.WriteLine("\n");
      ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine(" - --'-(@ Welcome to Pierre's Bakery --,-(@ -");
      ForegroundColor = ConsoleColor.Yellow;
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
      ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("If you are here for Baguettes enter[\"B\"]");
      Console.WriteLine("If you are here for Pastries enter[\"P\"]");
      Console.WriteLine("\n");
      string userAnswer = Console.ReadLine();
      if(userAnswer == "B" || userAnswer == "b")
      {
        ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        Console.WriteLine(" -        (☞ﾟヮﾟ)☞  Baguettes  ☜(ﾟヮﾟ☜)        -");
        Console.WriteLine(" How many Baguettes will you be purchasing today?");
        Console.WriteLine(" -                                          -");
        Console.WriteLine(" -           Buy 2 get 1 free for $10       -");
        Console.WriteLine(" -                    Or                    -");
        Console.WriteLine(" -             1 Baguette for $5            -");
        Console.WriteLine(" -                                          -");
        Console.WriteLine(" -                                          -");
        ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(" Enter quantity below then press enter");
        Console.WriteLine("\n");
        string breadPurchasedQuantity = Console.ReadLine();
        int breadPurchased = int.Parse(breadPurchasedQuantity);
        Bread usersBreadPurchase = new Bread(breadPurchased);
        int breadTotal = usersBreadPurchase.CostOfBread(breadPurchased);
        Console.WriteLine("Your total comes out to $" + breadTotal + " ☜(ﾟヮﾟ☜)");
      }
      else if(userAnswer == "P" || userAnswer == "p")
      {
        ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n");
        Console.WriteLine(" -        (☞ﾟヮﾟ)☞  Pastries  ☜(ﾟヮﾟ☜)        -");
        Console.WriteLine(" How many pastries will you be purchasing today?");
        Console.WriteLine(" -                                          -");
        Console.WriteLine(" -           Buy 2 get 1 1/2 Off $5         -");
        Console.WriteLine(" -                    Or                    -");
        Console.WriteLine(" -             1 Pastry for $2              -");
        Console.WriteLine(" -                                          -");
        Console.WriteLine(" -                                          -");
        ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(" -  Enter quantitiy below then press enter  -");
        Console.WriteLine("\n");


      }
      else
      {
       Console.WriteLine("\n");
       Console.WriteLine("\n");
       Console.WriteLine(" -         Merci, reviens nous voir         -");
       Console.WriteLine(" -                                          -");
       Console.WriteLine(" -            (╯°□°)╯︵ ┻━┻                 -");
       Console.WriteLine("\n");
       Console.WriteLine("\n");
       Main();
      }
    }
  }
}

