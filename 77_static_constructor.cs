using System;
namespace Accembly1{
    public class Program{
      //We can have only one static constructor in a class. It cannot have any parameters or access modifiers.
      static Program(){
        //static constructor execute only ones.
        Console.WriteLine("static constructor");
      }
      Program(){
        Console.WriteLine("default constructor");
      }
      public static void Main(String[] args){
        Program p1 = new Program();
        Program p2 = new Program();
    }
    }
}