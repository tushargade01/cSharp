//we can not inherit static class
using System;
namespace Accembly1{
    class Student{
      //within the class and derived class accessable
        protected string stdName = "shubham";
    }
    class Program: Student{
            public static void Main(String[] args){
            Program p = new Program();
            Console.WriteLine(p.stdName);
        }
    }
}