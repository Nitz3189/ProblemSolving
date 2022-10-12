using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
  You may assume that each input would have exactly one solution, and you may not use the same element twice.
  You can return the answer in any order. 
*/
namespace ConsoleApp3
{
  public class TwoSum
  {
    public int[] TwoSumMethod(int[] nums, int target)
    {
      int[] resultArr = new int[2];
      IDictionary<int, int> dict = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++) {
        dict.Add(i, nums[i]);
        int remainder = target - nums[i];
        var result = dict.Where(x => x.Value == remainder);
        if (result.Count() >= 1 && i != result.Select(x => x.Key).First()){
          resultArr[0] = result.Select(x => x.Key).First(); 
          resultArr[1] = i;
          break;
        }
        
      }
      return resultArr;
    }
  }
}
