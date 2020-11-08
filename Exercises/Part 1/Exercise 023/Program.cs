using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string userInput = Console.ReadLine();
      int FirstintValue = Convert.ToInt32(userInput);
      Console.WriteLine("Give the second number!");
      string SeconduserInput = Console.ReadLine();
      int SecondintValue = Convert.ToInt32(SeconduserInput);
      int sum = FirstintValue + SecondintValue;
      Console.WriteLine ( FirstintValue + " + " + SecondintValue + " = " + sum);
      int subtract = FirstintValue - SecondintValue;
      Console.WriteLine ( FirstintValue + " - " + SecondintValue + " = " + subtract);
      int multiply = FirstintValue * SecondintValue;
      Console.WriteLine ( FirstintValue + " * " + SecondintValue + " = " + multiply);
      double division = ((double)FirstintValue / SecondintValue);
      Console.WriteLine (FirstintValue + " / " + SecondintValue + " = " + division);

    }
  }
}
