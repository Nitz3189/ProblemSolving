using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal  class LocationVistedCounter
  {
    //int[] arr = new int[] {2,1,1,3,2,1,1,3 };
    int[] arr = new int[] { 7, 5, 2, 7, 2, 7, 4, 7 };
    public int LocationVistedCount(int[] A)
    {

      if (A.Length is 0 or 1)
      {
        return A.Length;
      }

      var startingIndex = 0;
      var endingIndex = 0;
      var locationVisitedCounter = new int[A.Length];
      locationVisitedCounter[A[0] - 1] = 1;

      for (var i = 1; i < A.Length; i++)
      {
        var locationIndex = A[i] - 1;

        locationVisitedCounter[locationIndex]++;

        if (A[i] == A[i - 1])
        {
          continue;
        }

        endingIndex = i;

        while (locationVisitedCounter[A[startingIndex] - 1] > 1)
        {
          locationVisitedCounter[A[startingIndex] - 1]--;
          startingIndex++;
        }

      }

      return endingIndex - startingIndex;
    }
  }
}
