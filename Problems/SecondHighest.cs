using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class SecondHighest
  {

    public static void SecondHighestNum()
    {
      //second highest 
      int[] arr = { 2, 1, 4, 1, 23, 19 };
      int hightest = int.MinValue;
      int secondHight = int.MinValue;
      foreach (int i in arr)
      {
        if (i > hightest)
        {
          secondHight = hightest;
          hightest = i;
        }
        else if (i > secondHight)
        {
          secondHight = i;
        }
      }
      Console.WriteLine("second highest {0}", secondHight);
    }
  }
}
