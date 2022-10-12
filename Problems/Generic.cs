using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  internal class Generic
  {
    public void getName<T>(T value)
    {
      Console.WriteLine("1st Gname");
    }

    public void getName<T>(double value)
    {
      Console.WriteLine("2nd Gname");
    }
    public void getName(int value)
    {
      Console.WriteLine("3rd Gname");
    }
  }

}
