using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
      
        while(true)
          {
                string Userinput = Console.ReadLine();
                string[] pieces = Userinput.Split(' ');
                    if( Userinput == "" )
                    {
                    break;
                    }
                int pituus = pieces.Length;
                Console.WriteLine(pieces[pituus]);
                }
    }
  }
    }
  