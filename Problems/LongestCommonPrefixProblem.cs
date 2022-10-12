using System.Linq;

namespace PracticeDSA
{
  public class LongestCommonPrefixProblem
  {
    public static string LongestCommonPrefix(string[] strs)
    {
      if (strs == null || strs.Length <= 0)
        return "";
      string prefix = strs[0];
      for (int i = 1; i < strs.Count(); i++)
      {
        while (strs[i].IndexOf(prefix) != 0)
        {
          prefix = prefix.Substring(0, prefix.Length - 1);
          if (prefix == string.Empty)
            return "";
        }
      }
      return prefix;
    }
  }
}
