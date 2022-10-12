using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal static class ArrayNllyFy
  {

    public static void NullyFyArray()
    {
      List<int> change = new List<int>() {0,1,1,1 };
      List<int> arr =new List<int>() {1,1 };
      
      for (int i = 0; i < change.Count; i++)
      {
        var changeIndex = change[i];
        Console.WriteLine(changeIndex);
      }
    }
  }
}
