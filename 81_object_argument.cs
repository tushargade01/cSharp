using System;
namespace Accembly1{
    public class Program{
      int num1;
      int num2;
      Program(){
        num1 = 23;
        num2 = 34;
      }
      void printParameter(Program p){
        Console.WriteLine(p.num1);
        Console.WriteLine(num2);
      }
      void Display(){
        printParameter(this);//this keyword refer instance of class
      }
      public static void Main(String[] args){
        Program p = new Program();
        p.Display();
    }
    }
}