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
      Console.WriteLine(int.TryParse(Console.ReadLine(), out int value) ? string.Join(Environment.NewLine , Pong.PingItUp(value)) : "That's not a number, you bully!");
    }
  }
} 
