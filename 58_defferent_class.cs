using System;
namespace secondProgram{
    class Student{
        public string name;
        public void stdDeatail(){
            Console.WriteLine("Stucent Name is: "+name);
        }
    }
    class Program{
        public static void Main(string[] args){
           Student std = new Student();
           std.name = "tushar";
           Console.WriteLine(std.name);
           std.stdDeatail();
        }
    }
}