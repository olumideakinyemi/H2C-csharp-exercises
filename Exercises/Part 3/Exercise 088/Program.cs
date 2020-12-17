using System;
using System.Collections.Generic;

namespace exercise_88
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
          if (Userinput.Contains(" ")) 
          {
            Console.WriteLine(pieces[i]);
          }
          if  (!Userinput.Contains(" "))
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
}