using System;
namespace Accembly1{
    public class Student{
        internal string name = "tushar";
    }
    public class Program{
        public static void Main(String[] args){
            Student s = new Student();
            string name = s.name;
            Console.WriteLine(name);
        }
    }

}