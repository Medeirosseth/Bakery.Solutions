using System;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-----------------------------");
      Console.WriteLine("\n");
      Console.WriteLine("---------( ͡° ͜ʖ ͡°( ͡° ͜ʖ ͡°) ͡° ͜ʖ ͡°)----------");
      Console.WriteLine("--)-@ Bienvenue à la boulangerie Pierre --)-@");
      Console.WriteLine("\n");
      Console.WriteLine(" voir notre menu en français, entrer [\"Français\"]");
      Console.WriteLine(" To see our menu in English enter [\"English\"]");
      Console.WriteLine("-----------------------------");
      string answer = Console.ReadLine();
      if(answer == "Enter" || answer == "english" || answer == "ENTER")
      {
        Console.WriteLine(" Todays Specials ");
        Console.WriteLine("--)-@ Welcome to Pierre's Bakery --)-@");
        Console.WriteLine(" Todays Specials Are");
      }
      else
      {
        Console.WriteLine("try again");

      }
    }
  }
}

