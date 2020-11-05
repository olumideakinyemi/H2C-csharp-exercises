using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string userinput = Console.ReadLine();
      int FirstintValue = Convert.ToInt32(userinput);
      Console.WriteLine ("Give the second number!");
      string secondUserinput = Console.ReadLine();
      int SecondintValue = Convert.ToInt32(secondUserinput);
      Console.WriteLine ("Give the third number!");
      string thirduserinput = Console.ReadLine();
      int ThirdintValue = Convert.ToInt32(thirduserinput);
      Console.WriteLine ("The sum is " + (FirstintValue + SecondintValue + ThirdintValue));
    }
  }
}
