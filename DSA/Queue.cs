using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
  internal class CustomQueue<T>
  {
    T[] array;
    int capacity;
    int front, rear;

    public CustomQueue(int size)
    { 
      array = new T[size];
      capacity = size;
      front = -1;
      rear = -1;
    }

    public int Size()
    {
      if (front == -1) return 0;
      if (rear > front)
      {
        return (rear - front) + 1;
      }
      return (capacity - front) + rear + 1;
    }
    public bool IsEmpty()
    {
      if(front == -1)
        return true;
      return false;
    }

    public bool IsFull()
    {
      if (front == 0 && rear == capacity -1)
        return true;
      if(front == rear +1)
      return true;
      return false;
    }

    public void Enqueue(T item)
    {
      if (IsFull())
      {
        Console.WriteLine("Queue full");
        throw null;
      }
      if (front == -1)
      {
        front++;
      }
      rear = (rear + 1) % capacity;
      array[rear] = item;
    }

    public T Dequeue()
    {
      T element;
      if (IsEmpty()){
        Console.WriteLine("Queue Empty");
        throw null;
      }
      element = array[front];
      // only one element left
      if (front == rear){
        front = -1;
        rear = -1;
      }
      else {
      front = (front+1)% capacity; 
      }
      return element;
    }

    public void PrintQueue()
    {
      int i;
      if (IsEmpty()){
        Console.WriteLine("Queue Empty");
      }
      else{
        Console.WriteLine("Front -> " + front);
        Console.WriteLine("Items -> ");
        for (i = front; i != rear; i = (i + 1) % capacity)
          Console.WriteLine(array[i] + " ");
          Console.WriteLine(array[i]);
          Console.WriteLine("Rear -> " + rear);
      }
    }
  }
}
