using System;
namespace Accembly1{
    public class Program{
      Program(int num1,int num2){//this execute first
        Console.WriteLine("two parameter Constructor.");
      }
      Program(int num1) : this(33,54){
        Console.WriteLine("one Parameter class.");
      }
      public static void Main(String[] args){
        Program p = new Program(11);
    }
    }
}