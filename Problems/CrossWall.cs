using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class CrossWall
  {
    public static void CrossWalls()
    {
      // cross wall
      int[] walls = { 11, 45, 10, 5 };
      int x1 = 10, y = 1;
      int jumps = 0;
      for (int i = 0; i < walls.Length; i++)
      {
        if (walls[i] < x1)
        {
          jumps++;
          continue;
        }
        int h = walls[i];
        while (h > x1)
        {
          jumps++;
          h = h - (x1 - y);
        }
        jumps++;
      }
      Console.WriteLine(jumps);
    }
  }
}
