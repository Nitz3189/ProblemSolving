using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal  class ExcelFindRow
  {

    public static void excelFindColoumValue()
    {
      int colNumber = 4446;
      string colString = "";
      while (colNumber > 0)
      {
        int mod = colNumber % 26;
        if (mod == 0)
        {
          colString += 'Z';
          colNumber /= 26;
        }
        else
        {
          var  c = (char)(mod-1 +'A');
          colString += c;
          colNumber /= 26;
        }
      }
      StringBuilder colName = new StringBuilder();
      foreach (char c in colString.Reverse())
      {
        colName.Append(c);
      }
      Console.WriteLine(colName);
    }

  }
}
