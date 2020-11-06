using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine ("Give the first number!");
      string userInput = Console.ReadLine ();
      int FirstintValue = Convert.ToInt32(userInput);
      Console.WriteLine ("Give the second number!");
      string SeconduserInput = Console.ReadLine();
      int SecondintValue = Convert.ToInt32(SeconduserInput);
      Console.WriteLine ("Give the third number!");
      string ThirduserInput = Console.ReadLine();
      int ThirdintValue = Convert.ToInt32(ThirduserInput);
      double average = (FirstintValue + SecondintValue + ThirdintValue) / 3.0;
      Console.WriteLine ("The average is " + average);
    }
  }
}
