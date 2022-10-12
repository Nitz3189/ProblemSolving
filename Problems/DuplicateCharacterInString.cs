using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Given String Find Duplicate Characters
 */
namespace ConsoleApp3
{
  internal class DuplicateCharacterInString
  {
    public void DuplicateCharactersGroupBy(string str) {
      //Covert it to char array
      char[] strArr = str.ToCharArray();
      var itemAndCount = strArr.GroupBy(x => x, (key, g) => new { character = key, count = g.Count() }).ToList();

      //Chanrater having duplicates
      var charsHavingDuplicate = itemAndCount.Where(x => x.count > 1);
      Console.WriteLine("Chanracters which are duplicates:");
      foreach (var c in charsHavingDuplicate)
      {
        Console.WriteLine(c.character);
      }
    }

    public void CharactersInPairGroupBy(string str)
    {
      //Covert it to char array
      char[] strArr = str.ToCharArray();
      var itemAndCount = strArr.GroupBy(x => x, (key, g) => new { character = key, count = g.Count() }).ToList();

      //Characters appeared in pair
      var charsApearedInPair = itemAndCount.Where(x => x.count % 2 == 0);
      Console.WriteLine("Characters Appeared in Pair:");
      foreach (var item in charsApearedInPair){
        Console.WriteLine(item.character);
      }
    }

    public void DuplicateCharacters(string str)
    {
      //Covert it to char array
      char[] strArr = str.ToCharArray();
      Dictionary<char, int> dict = new Dictionary<char, int>();

      for (int i = 0; i < strArr.Length; i++){
        if (dict.ContainsKey(strArr[i])){
          dict[strArr[i]] = dict[strArr[i]] + 1;
          continue;
        }
        dict[strArr[i]] = 1;
      }
      //Chanrater having duplicates
      var charsHavingDuplicate = dict.Where(x => x.Value > 1);
      Console.WriteLine("Chanracters which are duplicates:");
      foreach (var c in charsHavingDuplicate){
        Console.WriteLine(c.Key);
      }
    }
  }
}
