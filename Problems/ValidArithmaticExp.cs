using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal static class ValidArithmaticExp
  {

    public static bool Is_valid()
    {
      string expression = "((1+2)*3)%(1*1)"; //"{(1+2)*3}+4";
      bool result = true;
      /*stores digits*/
      Stack<int> st1 = new Stack<int>();
      /*stores operators and parantheses*/
      Stack<char> st2 = new Stack<char>();
      bool isTrue = true;
      for (int i = 0; i < expression.Length; i++)
      {
        char temp = expression[i];
        /*if the character is a digit, we push it to st1*/
        if (isDigit(temp))
        {
          st1.Push(temp - '0');
          if (isTrue)
          {
            isTrue = false;
          }
          else
          {
            return false;
          }
        }
        /*if the character is an operator, we push it to st2*/
        else if (isOperator(temp))
        {
          st2.Push(temp);
          isTrue = true;
        }
        else
        {
          /*if the character is an opening parantheses we push it to st2*/
          if (isBracketOpen(temp))
          {
            st2.Push(temp);
          }
          /*If it is a closing bracket*/
          else
          {
            bool flag = true;
            /*we keep on removing characters until we find the corresponding
            open bracket or the stack becomes empty*/
            while (!(st2.Count()<=0))
            {
              char c = st2.Pop();
              if (c == getCorrespondingChar(temp))
              {
                flag = false;
                break;
              }
              else
              {
                if (st1.Count() < 2)
                {
                  return false;
                }
                else
                {
                  st1.Pop();
                }
              }
            }
            if (flag)
            {
              return false;
            }

          }
        }
      }
      while (!(st2.Count() <=0))
      {
        char c = st2.Pop();
        if (!isOperator(c))
        {
          return false;
        }
        if (st1.Count() < 2)
        {
          return false;
        }
        else
        {
          st1.Pop();
        }
      }
      if (st1.Count() > 1 || !(st2.Count()<=0))
      {
        return false;
      }
      return result;
    }
    /*method to get corresponding opening and closing bracket.*/
    public static char getCorrespondingChar(char c)
    {
      switch (c)
      {
        case ')':
          return '(';
        case '}':
          return '{';
        case ']':
          return '[';
          default: return c;
      }
    }

    /*checks if the given bracket is open or not.*/
    public static bool isBracketOpen(char c)
    {
      if (c == '(' || c == '[' || c == '{')
      {
        return true;
      }
      return false;
    }

    /*checks if the given character is a digit.*/
    public static bool isDigit(char c)
    {
      if (c >= '0' && c <= '9')
      {
        return true;
      }
      return false;
    }

    public static bool isOperator(char c)
    {

      switch (c)
      {
          case '+':
          case '-':
          case '*':
          case '/':
          case '%':
            return true;
          default: 
            return false;
      }      
    }
  }
}
