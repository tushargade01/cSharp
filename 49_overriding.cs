using System;
namespace firstProgram{
    class Example{
        public void printMSG(){
            Console.WriteLine("hello, tushar!");
        }
    }
    class Example2 : Example{
        //new public void printMSG() we can use new keyword.
        public void printMSG(){
            Console.WriteLine("hello, tushar(after overriding a method.)");
        }
        static void Main(String[] args){
            Example2 ex2 = new Example2();
            ex2.printMSG();
        }
    }
}