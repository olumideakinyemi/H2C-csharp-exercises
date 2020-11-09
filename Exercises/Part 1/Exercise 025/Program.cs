using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
if (intValue == 1984)
{
     Console.WriteLine("Orwell");       
}
    }
  }
}
