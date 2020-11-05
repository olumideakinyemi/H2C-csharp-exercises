using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput); 
      Console.WriteLine("Give a double:");
      string inputValue = Console.ReadLine();
      double doubleValue = Convert.ToDouble(inputValue);
      Console.WriteLine("Give a boolean:");
      string True = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(True);
      Console.WriteLine ("Your string: " + message);
      Console.WriteLine ("Your integer: " + intValue);
      Console.WriteLine ("Your double: " + doubleValue);
      Console.WriteLine ("Your boolean: " + booleanValue);

    }
  }
}
