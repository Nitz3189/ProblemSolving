using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDSA
{
  class FindPossibleDecoding
  {
    public int FindDecodings2(string digits)
    {
      var length = digits.Length;
      var count = new int[length+1];

      count[0] = 1;
      count[1] = 1;
      for(int i=2;i<=length;i++)
      {
        count[i] = 0;
        if(digits[i-1] > '0')
          count[i] = count[i - 1];
        
        if (digits[i - 2] == '1' ||
          (digits[i - 2] == '2' &&
          digits[i - 1] < '7'))
          count[i] += count[i - 2];
      }
      return count[length];

    }
  }
}
