//we can not inherit static class
using System;
namespace Accembly1{
  static class Program{
    static public string name="tushar";
    static void printMsg(){
      Console.WriteLine("static class.");
    }
    public static void Main(String[] args){
      Console.WriteLine(name);
      printMsg();
    }
  }
}