using System;
namespace Accembly1{
    public class Program{
      int num;
      Program(int num){
       // num = num; 
       //(we are getting 0 as an output. This is because the C# gets confused because the names of the instance variable and the parameter are the same.)

       this.num = num;
      }
      public static void Main(String[] args){
        Program p = new Program(3);
        Console.WriteLine(p.num);
    }
    }
}