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
      Console.WriteLine(intValue); 
      //Console.WriteLine("Give a double:");
      //string inputDoubleValue = Console.ReadLine();
      //double doubleValue = Convert.ToDouble(inputDoubleValue);
      //Console.WriteLine = (doubleValue);
      Console.WriteLine("Give a boolean:");
      string True = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(True);
      Console.WriteLine(booleanValue);
      Console.WriteLine ("Your string: " + message);
      Console.WriteLine ("Your integer " + intValue);
      //Console.WriteLine ("Your double " + doubleValue);
      Console.WriteLine ("Your boolean: " + booleanValue);

    }
  }
}
