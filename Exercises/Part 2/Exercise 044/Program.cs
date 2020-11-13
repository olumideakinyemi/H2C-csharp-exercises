using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      int FirstuserInput = Convert.ToInt32(Console.ReadLine());
      int SeconduserInput = Convert.ToInt32(Console.ReadLine());
      if (FirstuserInput > SeconduserInput)
      {
         Console.WriteLine ( FirstuserInput + " is grEater than " + SeconduserInput + "." );
      }
      else if (FirstuserInput < SeconduserInput)
      {
         Console.WriteLine (FirstuserInput + " is less than " + SeconduserInput + ".");  
      }
      else
      {
         Console.WriteLine (FirstuserInput + " is equal to " + SeconduserInput + "." );
      }

    }
  }
}
