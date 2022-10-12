using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given a palindromic string of lowercase English letters palindrome, replace exactly one character with any lowercase English letter so that the resulting string is not a palindrome and that it is the lexicographically smallest one possible.
  Return the resulting string. If there is no way to replace a character to make it not a palindrome, return an empty string.

  A string a is lexicographically smaller than a string b (of the same length) if in the first position where a and b differ, a has a character strictly smaller than the corresponding character in b. For example, "abcc" is lexicographically smaller than "abcd" because the first position they differ is at the fourth character, and 'c' is smaller than 'd'. 
 */
namespace ConsoleApp3
{
  internal class BreakPalindrome
  {
    public string BreakAPalindrome(string palindrome)
    {
      string result = "";
      if (palindrome.Length <= 1)
      {
        return result;
      }
      var strArray = palindrome.ToCharArray();

      bool isModified = false;
      for (int i = 0; i < strArray.Length; i++){
        int asciiValue = (int)strArray[i];
        if (asciiValue == (int)'a'){
          continue;
        }
        strArray[i] = 'a';
        isModified = true;
        break;
      }
      if (isModified == false){
        strArray[strArray.Length - 1] = 'b';
      }

      foreach (var item in strArray){
        result += item;
      }
      return result;
    }
  }
}
