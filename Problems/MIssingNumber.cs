using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class MIssingNumber
  {

    public static void MissingNum()
    {
      ////Missing number
      int[] arra = { 1, 3, 4, 5, 2, 6, 8 };
      int numbers = 8;
      int total = 0;
      foreach (int item in arra)
      {
        total = total + item;
      }

      int missingNumber = (numbers * (numbers + 1) / 2) - total;
      Console.WriteLine("missing number is {0} ", missingNumber);
    }
  }
}
