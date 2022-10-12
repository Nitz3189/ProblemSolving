using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class VowelCount
  {

    public static void  VowelsCount()
    {

      string charStr = "aeioubcd";
      int vowewl = 0, consonent = 0;
      var vowelList = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
      foreach (char c in charStr)
      {
        if (vowelList.Contains(c))
        {
          vowewl++;
        }
        else { consonent++; }
      }
      Console.WriteLine("vowel count {0}, consonent count {1}", vowewl, consonent);
    }
  }
}
