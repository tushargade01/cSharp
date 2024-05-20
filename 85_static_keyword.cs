using System;
namespace Accembly1{
  public class Program{
    static string department = "computer science";
    public static void Main(String[] args){
      //there will be a single copy instead of createing a individual copy
      Console.WriteLine(Program.department);
    }
  }
}