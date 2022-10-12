using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
  internal class CustomStack<T>
  {
    private T[] array;
    private int capacity;
    private int top;
    public CustomStack(int size)
    {
      array = new T[size];
      capacity = size;
      top = -1;
    }

    public void Push(T item)
    {
      if (IsFull())
      {
        throw new Exception("Stack full");
      }
      array[++top] = item;
    }

    public T Pop()
    {
      if (IsEmpty())
      {
        throw new Exception("Stack Empty");
      }
      return array[top--];
    }

    public int Size()
    {
      return top + 1;
    }

    public bool IsFull()
    {
      if(top == capacity - 1) return true;
      return false;
    }

    public bool IsEmpty()
    {
      if (top == -1) return true;
      return false;
    }

    public void PrintStack()
    {
      for (int i = 0; i<=top;i++)
      {
        Console.WriteLine(array[i]);
      }
    }
  }
}
