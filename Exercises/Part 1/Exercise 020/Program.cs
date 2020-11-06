using System;
using System.Diagnostics.CodeAnalysis;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine ("Give the first number!");
      string userInput = Console.ReadLine();
      int FirstintValue = Convert.ToInt32(userInput);
      Console.WriteLine ("Give the second number!");
      string SeconduserInput = Console.ReadLine();
      int SecondintValue = Convert.ToInt32(SeconduserInput);
      int multiply = FirstintValue * SecondintValue;
      Console.WriteLine ( FirstintValue + " * " + SecondintValue + " = " + multiply);
    }
  }
}
