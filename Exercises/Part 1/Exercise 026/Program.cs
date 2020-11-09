using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your age:");
      string inputValue = Console.ReadLine();
      int intValue = Convert.ToInt32(inputValue);
if(intValue < 1900)
{
     Console.WriteLine("You`re old");       
}
    }
  }
}
