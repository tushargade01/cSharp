using System;
namespace Accembly1{
  class Student{
    public void NonStaticMethod(){
      Console.WriteLine("non static method");
    }
    static public void staticMethod(){
      Console.WriteLine("static method");
    }
  }
  public class Program{
    public static void Main(String[] args){
      Student s = new Student();
      s.NonStaticMethod();
      Student.staticMethod();
    }
  }
}