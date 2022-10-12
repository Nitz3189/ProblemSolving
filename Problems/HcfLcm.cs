using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal static class HcfLcm
  {

    public static void FindLcmHcf()
    {
      int x =15, y= 20;

      var hcf = FindHcf(x, y);
      var lcm = FindLcm(hcf, x, y);
      Console.WriteLine("lcm is : {0}, hcf is {1}",lcm,hcf);
    }

    private static int  FindHcf(int a, int b)
    {
        if (b == 0)
          return a;
        return FindHcf(b, a % b);
    }
    private static int FindLcm(int hcf, int x, int y)
    {
      return (x * y) / hcf;
    }

    
  }
}
