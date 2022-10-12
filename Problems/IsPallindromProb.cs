using System;

namespace PracticeDSA
{
  public class IsPallindromProb
  {
    public static bool IsPalindrome(int x)
    {
      int sum = 0;
      while (x > sum)
      {
        sum = sum * 10 + x % 10;
        x = x / 10;
      }
      return x == sum || x == sum / 10;
    }
  }
}
