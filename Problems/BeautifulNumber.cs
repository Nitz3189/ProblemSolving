using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal static class BeautifulNumber
  {

    public static void BeautifullNumber(long N)
    {

      var Num = N;
      while(!isBeautifull(Num))
      {
        Num++;
      }
      Console.WriteLine(Num);
    }

    private static bool isBeautifull(long N)
    {
      long num = N;
      Dictionary<long, long> dict = new Dictionary<long, long>();
      while (num > 0)
      {
        var rem = num % 10;
        if (rem == 0) return false;
        if (dict.ContainsKey(rem))
        {
          dict[rem]++;
        }
        else
        {
          dict.Add(rem, 1);
        }
        num /= 10;
      }

      bool isBeautifull = dict.Any(x=>x.Key != x.Value);
      return !isBeautifull;
    }

  }

}
