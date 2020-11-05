using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("How many days?");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine(intValue*86400);
      //The 86400 above is the total number of seconds in a day. 
    }
  }
}
