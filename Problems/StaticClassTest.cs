//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problems
//{

//  class Base
//  {
//    public static int i;
//    static Base()
//    {
//      Console.WriteLine("In Base Static");
//    }

//    public Base()
//    {
//      Console.WriteLine("In Base");
//    }
//  }

//  class Child:Base
//  {
    
//    static Child()
//    {
//      Console.WriteLine("In child Static");
//    }

//    public Child()
//    {
//      Console.WriteLine("In child");
//    }
//  }


//  public interface BabuRow
//  {

//     public int Id { get; set; }
//     public const int RowId = 1;

//    public virtual void Babu()
//    {
//      Console.WriteLine("Hello");
//    }
//    public void Babu(int id);
//  }

//  public class BbbuRow1 : BabuRow
//  {
//    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    public void Babu(int id)
//    {
//      throw new NotImplementedException();
//    }
//    public override void Babu()
//    {
//      Console.WriteLine("Hello");
//    }
//  }
//}
