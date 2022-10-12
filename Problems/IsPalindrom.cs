using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal class IsPalindrom
  {
    public bool IsPalindrome(int x)
    {

      //return StringWay(x);

      //Int way
      if (x < 0) { return false; }
      int reverse = Reverse(x, 0);
      if (x == reverse) { return true; }
      return false;
    }
    public int Reverse(int x, int sum = 0)
    {
      sum = sum * 10 + x % 10;
      int num = x / 10;
      if (num == 0) { return sum; }
      return Reverse(num, sum);
    }

    public bool StringWay(int x)
    {
      string number = x.ToString();
      for (int i = 0, j = number.Length - 1; i < j; i++, j--){
        if (number[i] != number[j]){
          return false;
        }
      }
      return true;
    }
  }
}

