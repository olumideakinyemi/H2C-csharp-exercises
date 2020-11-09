using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine ("Give the first number!");
      string userinput = Console.ReadLine();
      int intValue = Convert.ToInt32(userinput);
      Console.WriteLine ("Give the second number!");
      string SeconduserInput = Console.ReadLine();
      int SecondintValue = Convert.ToInt32(SeconduserInput);
if(intValue > SecondintValue)
{
      Console.WriteLine ("The larger number is " + intValue + "!");      
}
else if (SecondintValue > intValue)
{
      Console.WriteLine ("The larger number is " + SecondintValue + "!");    
}
else
{
     Console.WriteLine ("They are equal!");       
}

    }
  }
}
