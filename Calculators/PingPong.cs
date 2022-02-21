using System;
using System.Collections.Generic;

namespace PingPong.Calculators
{
  public class Pong
  {
    public static List<string> PingItUp(int input)
    {
      List<string> output = new List<string> {};
      for (int num = 1; num <= input; num++)
      {
        if ((num % 5 == 0) && (num % 3 == 0))
        {
          output.Add(" PingPong");
        }
        else if(num % 5 == 0)
        {
          output.Add(" Pong");
        }
        else if(num % 3 == 0) 
        {
          output.Add(" Ping");
        }
        else 
        {
          output.Add(num.ToString());
        }
      }
    
      return output;
    }
  }
  
  
}