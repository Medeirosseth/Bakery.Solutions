using System;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-----------------------------");
      Console.WriteLine("\n");
      Console.WriteLine("\n");
      Console.WriteLine("---------( ͡° ͜ʖ ͡°( ͡° ͜ʖ ͡°) ͡° ͜ʖ ͡°)----------");
      Console.WriteLine("--)-@ Bienvenue à la boulangerie Pierre --)-@");
      Console.WriteLine("\n");
      Console.WriteLine("\n");
      Console.WriteLine(" voir notre menu en français, entrer [\"Français\"]");
      Console.WriteLine(" To see our menu in English enter [\"English\"]");
      Console.WriteLine("\n");
      Console.WriteLine("------------------------------------------");
      string answer = Console.ReadLine();
      if(answer == "English" || answer == "english" || answer == "ENGLISH")
      {
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("--)-@ Welcome to Pierre's Bakery --)-@");
        Console.WriteLine("\n");
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
      }
      else
      {
        Console.WriteLine("try again");

      }
    }
  }
}

