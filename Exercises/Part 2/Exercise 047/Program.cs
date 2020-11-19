using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Where to?");
      int whereToinput = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int whereFromnumber = Convert.ToInt32(Console.ReadLine());
      while (whereFromnumber <= whereToinput)
      {
           Console.WriteLine(whereFromnumber);
           whereFromnumber++;
           
      }
       
   
      
    }
  }
}
