using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class StringWrap
  {
    public static void CharacterWrap()
    {
      string text = "This is my name vishwajeet singh, I work for JDA.";
      string[] stringArray = text.Split(" ", StringSplitOptions.None);
      StringBuilder stringBuilder = new StringBuilder();
      List<string> finalItems = new List<string>();
      foreach (var item in stringArray)
      {
        stringBuilder.Append(item + " ");
        if (stringBuilder.Length < 6)
        {
          continue;
        }
        else
        {
          finalItems.Add(stringBuilder.ToString());
          stringBuilder.Clear();
        }
      }

      foreach (var item in finalItems)
      {
        Console.WriteLine(item);
      }
    }
  }
}
