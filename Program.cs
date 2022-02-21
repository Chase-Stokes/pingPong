using System;
// using System.Linq;
using System.Collections.Generic;
using PingPong.Calculators;

namespace PingPong
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number, bucko: ");
      string input = Console.ReadLine();
      if (int.TryParse(input, out int value))
      {
        Console.WriteLine("=========");
        Pong.PingItUp(int.Parse(input)).ForEach(Console.WriteLine);
      }
      else{
        Console.WriteLine("That's not a number, you bully!");
      }
    }
  }
} 
