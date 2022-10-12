using TestProj;

namespace PracticeDSA
{
  public class ValidParanthesis
  {
    public static bool IsValid(string s)
    {
      TestProj.Stack<char> stack = new TestProj.Stack<char>();
      foreach (char ch in s.ToCharArray())
      {

        if (ch == '{' || ch == '(' || ch == '[')
        {
          stack.Push(ch);
          continue;
        }
        if (ch == '}' && stack.Top >= 0 && stack.GetTopItem() == '{')
        {
          stack.Pop();
          continue;
        }

        if (ch == ']' && stack.Top >= 0 && stack.GetTopItem() == '[')
        {
          stack.Pop();
          continue;
        }

        if (ch == ')' && stack.Top >= 0 && stack.GetTopItem() == '(')
        {
          stack.Pop();
          continue;
        }
      }
      return s.Length < 2 && stack.IsEmpty();

    }
  }
}
