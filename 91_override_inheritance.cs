//we can not inherit static class
using System;
namespace Accembly1{
    class Student{
        //if we define as virtual then we can overriden it in derived class
        public virtual void department(){
            Console.WriteLine("my department is b.com");
        }
    }
    class Program: Student{
        public override void department()
        {
            Console.WriteLine("my department is a computer science.");
        }
        public static void Main(String[] args){
            Program p = new Program();
            p.department();
        }
    }
}