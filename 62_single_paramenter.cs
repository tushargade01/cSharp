using System;
namespace secondProgram{
    class Program{
        string stdName(string name){
            return name;
        }
       public static void Main(string[] args){
           Program p = new Program();
           string name = p.stdName("tushar");
           Console.WriteLine("student name is: {0}",name);
        }
    }
}