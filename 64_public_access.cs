/*
access modifiers:
1.public : anywhere
2.private : with in same Class
3.protected : with in same class and derived class
4.internal : same assembly
*/
using System;
namespace secondProgram{
    class Program{
       public string name = "tushar";
       public void hello(){
        Console.WriteLine("hello, my name is "+name);
       }
       public static void Main(string[] args){
            Program p = new Program();
            p.hello();//access method

            Console.WriteLine(p.name);//access field 
        }
    }
}