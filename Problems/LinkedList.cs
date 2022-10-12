using System;
using System.Collections.Generic;
using System.Text;

namespace TestProj
{
  public class Node<T>
  {
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data, Node<T> node = null)
    {
      Data = data;
      Next = node;
    }
  }
  public class LinkedList<T>
  {
    public Node<T> head { get; private set; }
    public Node<T> lastNode { get; private set; }
    public LinkedList()
    {
      head = null;
      lastNode = null;
    }

    public Node<T> AddNode(T data)
    {
      var node = new Node<T>(data, lastNode?.Next);
      if (head == null)
      {
        head = node;
        lastNode = node;
        return lastNode;
      }
      lastNode.Next = node;
      lastNode = lastNode.Next;
      return lastNode;
    }

    //traverse and find the data through position
    public T DeleteNode(int position)
    {
      T data;
      Node<T> node = head;
      Node<T> PrevNode = head;
      if (position == 1)
      {
        head = head.Next;
        PrevNode = null;
      }
      else while (position > 1)
        {
          PrevNode = node;
          node = node.Next;
          position--;
        }
      PrevNode.Next = node.Next; // This line delete the node
      data = node.Data;
      return data;
    }
  }
}
