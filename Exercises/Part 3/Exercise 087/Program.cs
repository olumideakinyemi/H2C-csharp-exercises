using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        string input = Console.ReadLine();
        string[] pieces = input.Split(' ');
        if (input == "")
        {
          break;
        }
        for (int i = 0; i < pieces.Length; i++)
        {
           Console.WriteLine(pieces[i]);
        }
          if (input.Contains("av")) 
          {
            Console.WriteLine(input.Contains("av"));
          }
          if  (!input.Contains("av"))
          {
              
          }
          else
          {
            break;
          }
            
        }
        
          
      }
    }
  }



