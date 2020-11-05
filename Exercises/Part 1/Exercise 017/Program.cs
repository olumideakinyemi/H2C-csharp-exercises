using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string userInput = Console.ReadLine();
      int FirstintValue = Convert.ToInt32(userInput);
      Console.WriteLine("Give the second number!");
      string secondnumber = Console.ReadLine();
      int SecondintValue = Convert.ToInt32(secondnumber);
      Console.WriteLine ("The sum is " + (FirstintValue + SecondintValue) );
      
    }
  }
}
