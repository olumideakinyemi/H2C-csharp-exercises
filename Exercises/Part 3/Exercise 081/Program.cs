using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here

      string[] arrayOfStrings = {"Mike L.", "Mike P.", "Mike V."};
double[] arrayOfFloatingpoints = {1.20, 3.14, 100.0, };

for (int i = 0; i < arrayOfFloatingpoints.Length; i++) {
    Console.WriteLine(arrayOfStrings[i] + " " +  arrayOfFloatingpoints[i]);
}
}
  }
}