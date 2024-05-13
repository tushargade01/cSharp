using System;
namespace firstProgram{
    class Program{
        public static void Main(String[] args){
            Func<int,int,int> additionProgram = (a,b) => {return a+b;};//<x,y,retrun value type>
            Console.WriteLine(additionProgram(1,5));

            Func<int,int,int> mod = (x,y) =>{return x%y;};
            Console.WriteLine(mod(5,2));
        }
    }
}