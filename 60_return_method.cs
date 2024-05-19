using System;
namespace secondProgram{
    class Program{
        //use void if it does't have return type
        //if method has return type then we use int
        public int sumReturn(){
            int a=5, b=4;
            return a+b;
        }        public static void Main(string[] args){
            Program p = new Program(); //creating object
            Console.WriteLine(p.sumReturn()); //call method 
        }
    }
}