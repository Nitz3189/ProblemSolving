using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class BinaryGap
  {

    public static void BinaryGaps()
    {
      //BInaryGap
      //For example, given N = 1041 the function should return 5, because N has binary representation 10000010001

      var maxGap = BinarayGap(20);
      Console.WriteLine(maxGap);
    }

    static int BinarayGap(int v)
    {
      int result = 0, count = 0;
      string binaryNumber = "10100001000000";// Convert.ToString(v, 2);
      for (int i = 0; i < binaryNumber.Length; i++)
      {
        if (binaryNumber[i] == '0')
        {
          count++;
        }
        else if (binaryNumber[i] == '1')
        {
          result = Math.Max(result, count);
          count = 0;
        }
      }
      return result;
    }
  }
}
