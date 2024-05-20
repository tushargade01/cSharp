using System;
namespace Accembly1{
    public class Program{
       Program(){
        Console.WriteLine("this is parameterless Constructor.");
       }

        public static void Main(String[] args){
                new Program(); //call constructor
                
        }
    }
}