using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static  class BubbleSort
  {

    public static void BubbleSorting()
    {
      //Bubble sort
      int[] intArr = { 8, 3, 4, 5, 8, 2 };

      for (int i = 0; i < intArr.Length; i++)
      {
        for (int j = i + 1; j < intArr.Length; j++)
        {
          if (intArr[i] > intArr[j])
          {
            int t = intArr[i];
            intArr[i] = intArr[j];
            intArr[j] = t;
          }
        }
      }
      foreach (int i in intArr)
      {
        Console.WriteLine(i);
      }
    }
  }
}
