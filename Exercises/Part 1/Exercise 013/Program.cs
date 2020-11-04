using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give double value");
      string userInput = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userInput);
      Console.WriteLine("You gave " + doubleValue);
        
    } 
  }   
}
