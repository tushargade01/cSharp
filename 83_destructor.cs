/*
Features of Destructors
There are some important features of the C# destructor. They are as follows:

We can only have one destructor in a class.
A destructor cannot have access modifiers, parameters, or return types.
A destructor is called implicitly by the Garbage collector of the .NET Framework.
We cannot overload or inherit destructors.
We cannot define destructors in structs.
*/
using System;
namespace Accembly1{
  public class Program{
    public Program(){
      Console.WriteLine("Constructor");
    }
    ~Program(){
      Console.WriteLine("Destructor (it also called finilizer.)");
    }
    public static void Main(String[] args){
      Program p =new Program();
    }
  }
}