using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class ReverseArray
  {

    public static void ReverseArr()
    {
      /// reverse the array
      /// 
      int[] array = { 1, 2, 3, 4, 5, 6, 7 };
      for (int i = 0; i < array.Length / 2; i++)
      {
        int t = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = t;
      }
      foreach (int i in array)
      {
        Console.WriteLine(i);
      }
    }
  }
}
