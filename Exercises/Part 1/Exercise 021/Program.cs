using System;

namespace exercise_21
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
      double average = (FirstintValue + SecondintValue)/2.0;
      Console.WriteLine ("The average is " + average);

    }
  }
}
