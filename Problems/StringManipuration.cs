using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PracticeDSA
{
  public class StringManipuration
  {

    public int LengthOfLastWorld(string s)
    {
      var splitedWorld = s.Split(" ", StringSplitOptions.None);
      var lastWorld = splitedWorld[splitedWorld.Length - 1];
      return lastWorld.Length;
    }
  }
}
