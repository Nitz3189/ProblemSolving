using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class BinarySearch
  {

    public static void BinarySearchAlgo()
    {
      //Binary search
      int[] searcharr = { 2, 3, 4, 10, 40, 30, 45, 50, 51 };
      int x = 51;
      int found = binarySearch(searcharr, 0, searcharr.Length - 1, x);
      if (found != -1) Console.WriteLine("Found" + found);
      else Console.WriteLine("not found" + found);
    }

    static int binarySearch(int[] arr, int l, int r, int x)
    {
      if (r >= l)
      {
        int mid = l + (r - l) / 2;
        if (arr[mid] == x)
          return mid;
        if (x > arr[mid])
        {
          return binarySearch(arr, mid + 1, r, x);
        }
        else { return binarySearch(arr, l, mid - 1, x); }
      }
      return -1;
    }
  }
}
