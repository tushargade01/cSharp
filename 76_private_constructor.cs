using System;
namespace Accembly1{
    public class Program{
        //we can not access this contructor outside the class
        private Program(){
            Console.WriteLine("this is private constructor.");
        }
        // public static void Main(string[] args){
        //     new Program();
        // }
    }
    class Car{
        public static void Main(String[] args){
            new Program();//error
        }
    }
}