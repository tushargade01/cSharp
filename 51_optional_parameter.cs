using System;
namespace firstProgram{
    public class Example{
        static void optionalPar(int roll,string name,string std_class = "tybcs"){ //optional parameter is always last
            Console.WriteLine("name: {0}\nroll number: {1}\nclass: {2}",name,roll,std_class);
        }
        public static void Main(String[] args){
            optionalPar(9,"tushar gade");
            optionalPar(9,"tushar gade","sybcs");
        }
    }
}