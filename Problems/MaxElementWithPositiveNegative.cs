using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal class MaxElementWithPositiveNegative
  {
    public MaxElementWithPositiveNegative()
    {
      int[] A = new int[] { 3, 2, -2, 5, -3 };
      //int[] A = new int[] { 1,1,2, -1, 2,-1 };
      //int[] A = new int[] { 1,2,3,-4};

      int max = int.MinValue;
      for (int i = 0; i < A.Length; i++)
      {
        if (A.Contains(-A[i]))
        {
          max = Math.Max(Math.Max(A[i], -A[i]), max);
        }
      }
      if (max == int.MinValue)
      {
        Console.WriteLine("0");
      }
      else
      {
        Console.WriteLine(max);
      }

    }
  }
}
