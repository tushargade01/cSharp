using System;
namespace Accembly1{
    public class Program{
       Program(string car){
        Console.WriteLine(car+"is my fav car");
      }
      Program(){
        Console.WriteLine("default constructor");
      }
      public static void Main(String[] args){
       
        Program p2 = new Program();
        Program p1 = new Program("bugati");
    }
    }
}