using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class PrimeNumber
  {
    public static void PrimeNum()
    {
      //prime
      int number = 3;
      if (number == 0 || number ==1)
      { Console.WriteLine("not prime"); }
      if (number == 2) { Console.WriteLine("Prime"); return; }
      for(int i= 2; i <= number/2; i++)
      {
        if (number % i == 0) {
          Console.WriteLine("not prime");
          return;
        }
      }
      Console.WriteLine("prime");
    }

    internal static bool FindPrime(int number)
    {
      if (number == 1) return false;
      if (number == 2) return true;
      if (number % 2 == 0) return false;
      var squareRoot = (int)Math.Floor(Math.Sqrt(number));
      for (int i = 3; i <= squareRoot; i += 2)
      {
        if (number % i == 0) return false;
      }
      return true;
    }
  }
}
