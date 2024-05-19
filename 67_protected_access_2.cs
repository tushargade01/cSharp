/*
access modifiers:
1.public : anywhere
2.private : with in same Class
3.protected : with in same class and derived class
4.internal : same assembly
*/
using System;
namespace secondProgram{
    class Student{
        protected string name = "tushar";
    }
    class Program:Student{
       public static void Main(string[] args){
            Program p = new Program();
           string name = p.name;
           Console.WriteLine(name);
        }
    }
}