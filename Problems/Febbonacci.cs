using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal static class Febbonacci
  {

    //generate the febonacci for n number

    public static void FebbonacciS()
    {
      var n = 50;
      long[] febonacci = new long[n];
      febonacci[0] = 0;
      febonacci[1] = 1;
      for (int i = 2; i < n; i++)
      {
        febonacci[i] = febonacci[i - 1] + febonacci[i - 2];
      }

      Console.WriteLine(febonacci);
    }
  }
}


