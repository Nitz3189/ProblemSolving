using System;
using System.Collections.Generic;
using System.Text;

namespace TestProj
{
  public class Stack<T>
  {
    IList<T> items;
    private int _Top;

    public Stack()
    {
      items = new List<T>();
      _Top = -1;
    }
    public int Top
    {
      get
      {
        return _Top;
      }
      set
      {
        _Top = value;
      }
    }
    public void Push(T item)
    {
      items.Add(item);
      Top++;
    }

    public T Pop()
    {
      if (Top == -1)
        return default(T);
      var item = items[_Top--];
      items.Remove(item);
      return item;

    }

    public T GetTopItem()
    {
      return items[Top];
    }

    public bool IsEmpty() => Top == -1;
  }
}
