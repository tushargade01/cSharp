using System;
using System.Text;
namespace stringBuild{
  class Program{
    static void Main(String[] args){
      StringBuilder sd = new StringBuilder();
      sd.Append("hello");
      sd.Append("my name is tushar");
      System.Console.WriteLine(sd.ToString());
      sd.Clear();
      System.Console.WriteLine("this: "+sd.ToString());
      
      sd.AppendLine("hello world!");
      sd.AppendLine("my name is tushar!");
      System.Console.WriteLine(sd.ToString());
      
      StringBuilder sd1 = new StringBuilder("this is sd1.");
      System.Console.WriteLine(sd1.ToString());
      
      sd1.Remove(5,2);
      System.Console.WriteLine(sd1.ToString());
      
      sd1.Replace(" ","_");
      System.Console.WriteLine(sd1.ToString()); 
      //sd1.Length;
    }
  }
}
