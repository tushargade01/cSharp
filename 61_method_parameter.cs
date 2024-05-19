using System;
namespace secondProgram{
    class Program{
        //use void if it does't have return type
        //if method has return type then we use int
        public int sumReturn(int a, int b){
            int sum = a+b;
            return sum;
        }        public static void Main(string[] args){
            Program p = new Program(); //creating object
            int sum = p.sumReturn(30,60);
            Console.WriteLine("sum is: "+sum); //call method 
        }
    }
}