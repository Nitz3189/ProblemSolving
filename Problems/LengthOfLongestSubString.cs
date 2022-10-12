using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDSA
{
  public class LengthOfLongestSubString
  {
    public static int LengthOfLongestSubstring(string str)
    {
      int j = 0, i, ans = 0;
      Dictionary<char, int> dic = new Dictionary<char, int>();
      for (i = 0; i < str.Length; i++)
      {
        if (!dic.ContainsKey(str[i]))
        {
          dic.Add(str[i], i);
        }
        else
        {
          var oldIndex = dic.GetValueOrDefault(str[i]);
          if (oldIndex >= j)
          {
            j = oldIndex + 1;
          }
          dic.Remove(str[i]);
          dic.Add(str[i], i);
        }
        ans = Math.Max(ans, i - j + 1);
      }
      return ans;
    }
  }
}
