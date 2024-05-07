using System;
namespace firstProgram {
    public class Program 
    {
        public static void Main(String[] args) {
            System.Console.WriteLine("enter first number: ");
            string a = Console.ReadLine();
            System.Console.WriteLine("enter sec number: ");
            string b = Console.ReadLine();
            int num = Convert.ToInt32(a) + Convert.ToInt32(b);
            System.Console.WriteLine(num);

        }
    }
}
