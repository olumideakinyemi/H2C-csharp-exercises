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
        string Userinput = Console.ReadLine();
        string[] pieces = Userinput.Split(' ');
        if (Userinput == "")
        {
          break;
        }
        for (int i = 0; i < pieces.Length; i++)
        {
          if (pieces[i].Contains("av")) 
          {
            Console.WriteLine(pieces[i]);
          }    
        }
        
          
      }
    }
  }
}
