using System;
namespace Accembly1{
    public class Program{
        string name = "tushar";
        public void printName(){
            Console.WriteLine(name);
        }
//we can't use static for class variable
        /*
        static void printName(){
            Console.WriteLine(name);
        }
        */
        public static void Main(String[] args){
            Program s = new Program();
            s.printName();
        }
    }

}