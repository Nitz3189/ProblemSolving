using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticeDSA
{
  public class RomanToInteger : System.Object
  {
    public static int RomanToInt(string s)
    {
      var dic = new Dictionary<char, int>();
      dic.Add('I', 1);
      dic.Add('V', 5);
      dic.Add('X', 10);
      dic.Add('L', 50);
      dic.Add('C', 100);
      dic.Add('D', 500);
      dic.Add('M', 1000);
      int len = s.Count();
      int sum = dic.GetValueOrDefault(s[len - 1]);
      for (int i = len - 2; i >= 0; i--)
      {
        if (dic.GetValueOrDefault(s[i]) >= dic.GetValueOrDefault(s[i + 1]))
          sum += dic.GetValueOrDefault(s[i]);
        else
          sum -= dic.GetValueOrDefault(s[i]);
      }
      return sum;
    }
  }
}
