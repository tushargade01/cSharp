//try it but i cant unserstand
using System;
namespace firstProgram{
    class exampleProgram{
    public static void Main(String[] args){
        Action printSomething = () => Console.WriteLine("tushar"); //expresion lamda
        printSomething();
        Action staticLamda = () => {
            Console.WriteLine("hello World!");
            Console.WriteLine("hello World!");
            Console.WriteLine("hello World!");
        };
        staticLamda();
        Action<string> getInput = (name) => System.Console.WriteLine(name);
        getInput("tushar");
    }
    }
}