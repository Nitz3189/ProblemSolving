using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class Anogram
  {

    public static void IsAnogram()
    {
      string a = "aaaa";
      string b = "aaaa";
      if (a.Length != b.Length)
      {
        Console.WriteLine("not anograms");
        return;
      }
      Dictionary<char, int> pairs = new Dictionary<char, int>();
      foreach (char c in a)
      {
        if (pairs.ContainsKey(c))
        {
          pairs[c]++;
        }
        else
        {
          pairs.Add(c, 1);
        }
      }
      foreach (char c in b)
      {
        if (pairs.ContainsKey(c))
        {
          pairs[(c)]--;
        }
      }

      bool isAnograms = pairs.Any(x => x.Value > 0);
      if (!isAnograms) Console.WriteLine("anogram");
      else Console.WriteLine("not anagram");
    }
  }
}
