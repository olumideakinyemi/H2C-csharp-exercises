using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      int FirstuserInput = Convert.ToInt32(Console.ReadLine());
      int SeconduserInput = Convert.ToInt32(Console.ReadLine());
      int sum = ( FirstuserInput + SeconduserInput);
      double squareRoot = Math.Sqrt(sum);
      Console.WriteLine(squareRoot);
    }
  }
}
