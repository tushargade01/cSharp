//If we have not defined a constructor in our class, then the C# will automatically create a default constructor with an empty code and no parameters
using System;
namespace Accembly1{
    public class Program{
        int a;
        public static void Main(String[] args){
            Program p = new Program();
            Console.WriteLine(p.a);
        }
    }
}