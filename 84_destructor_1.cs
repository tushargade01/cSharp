using System;
namespace Accembly1{
  public class Program{
    string name;
    void printMsg(){
      Console.WriteLine("Name: "+name);
    }
    ~Program(){
      Console.WriteLine("Destructor (it also called finilizer.)"); 
      //destructor is called implicitly which destroys object p
    }
    public static void Main(String[] args){
      Program p =new Program();
      p.name = "tushar";
      p.printMsg();
    }
  }
}