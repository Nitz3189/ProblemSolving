using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class ProductExceptSelf
  {
    
    //int[] nums = new int[5] { -1, 1, 0, -3, 3 };
    public static int[] ProductExceptSelff(int[] nums)
      {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
          result[i] = 1;
          for (int j = 0; j < nums.Length; j++)
          {
            if (result[i] == 0)
            {
              break;
            }
            if (i == j)
            {
              continue;
            }
            result[i] *= nums[j];
          }
        }
        return result;
      }
    }
}
