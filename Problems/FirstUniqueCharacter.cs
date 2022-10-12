using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given a string str, find the first non-repeating character in it and return its index. If it does not exist, return -1.
*/
namespace ConsoleApp3
{
  internal class FirstUniqueCharacter
  {

    public int UniqueCharGroupBy(string str) {
      char[] charArr = str.ToCharArray();
      var itemCount = charArr.GroupBy(x => x, (key, g) => new { character = key, count = g.Count() }).ToList();
      var uniqueChar = itemCount.FirstOrDefault(x => x.count == 1);
      if (uniqueChar != null)
      {
        for (int i = 0; i < charArr.Length; i++)
        {
          if (charArr[i] == uniqueChar.character)
          {
            return i;
          }
        }
      }
      return -1;
    }
  }
}
