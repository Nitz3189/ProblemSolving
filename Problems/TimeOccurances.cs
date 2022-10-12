using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class TimeOccurances
  {


    //var numberofOccurrences = Numbers(1,4,5,7);
    //var numberofOccurrences = Numbers(1, 8, 3, 2);
    //Console.WriteLine(numberofOccurrences);
    static int Numbers(int a, int b, int c, int d)
    {
      List<int> numbers = new List<int>() { a, b, c, d };
      int occurences = 0;
      var numberbetween0to9 = numbers.Any(x => x < 0 || x > 9);
      if (numberbetween0to9)
      {
        return occurences;
      }

      Dictionary<int, int> dict = new Dictionary<int, int>();
      foreach (int i in numbers)
      {
        if (dict.ContainsKey(i)) dict[i]++;
        else dict.Add(i, 1);
      }


      foreach (var hour1 in dict.Keys)
      {
        var dictClone = availableNumbers(dict);
        if (hour1 > 2) continue;
        if (!updateDict(dictClone, hour1)) continue;
        foreach (var hour2 in dict.Keys)
        {
          if (hour1 < 2 || (hour1 == 2 && hour2 < 4))
          {
            if (!updateDict(dictClone, hour2)) continue;
            foreach (var minute1 in dict.Keys)
            {
              if (minute1 > 5) continue;
              if (!updateDict(dictClone, minute1)) continue;
              foreach (var minute2 in dict.Keys)
              {
                if (!updateDict(dictClone, minute2)) continue;
                occurences++;
                dictClone[minute2]++;
              }
              dictClone[minute1]++;
            }
            dictClone[hour2]++;
          }
        }
        dictClone[hour1]++;
      }
      return occurences;
    }
    static bool updateDict(Dictionary<int, int> dict, int item)
    {
      if (dict.ContainsKey(item) && dict[item] > 0)
      {
        dict[item]--;
        return true;
      }
      return false;
    }

    static Dictionary<int, int> availableNumbers(Dictionary<int, int> pairs)
    {
      Dictionary<int, int> dictClone = new Dictionary<int, int>();
      foreach (var pair in pairs)
      {
        dictClone.Add(pair.Key, pair.Value);
      }
      return dictClone;
    }
  }
}
