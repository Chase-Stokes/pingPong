using System;
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

      // To Display Output on one line
      Console.WriteLine(int.TryParse(input, out int value) ? string.Join(", " , Pong.PingItUp(value)) : "That's not a number, you bully!");

      // To Display Output on multiple lines
      // if (int.TryParse(input, out int value))
      // {
      //   Console.WriteLine("=========");
      //   Pong.PingItUp(value).ForEach(Console.WriteLine);
      // }
      // else{
      //   Console.WriteLine("That's not a number, you bully!");
      // }
    }
  }
} 
