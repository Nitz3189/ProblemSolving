using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class Matrix
  {

    public static void SumMatrix()
    {

      int[,] metrics = new int[3, 3] { { 1, 2, 3}, { 1, 2, 3}, { 1, 2, 3 } };
      int[,] result = new int[3, 3];

      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          if (i == 0 && j == 0)
          {
            result[i, j] = metrics[i, j];
            continue;
          }

          var l = j; var  t = i;

          var sum = metrics[i, j];
          while (l > 0)
          {
            l--;
            sum += metrics[i, l];
          }
          while (t > 0)
          {
            t--;
            sum += metrics[t, j];
          }
          result[i, j] = sum;
        }
      }

      foreach(var item in result)
      {
        Console.WriteLine(item);
      }
    }
  }
}
