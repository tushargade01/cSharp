using System;
namespace secondProgram{
    class Program{
        //use void if it does't have return type
        //if method has return type then we use int
        public void PrintData(){
            Console.WriteLine("hello World!");
        }
        public static void Main(string[] args){
            Program p = new Program(); //creating object
            p.PrintData(); //call method 
        }
    }
}