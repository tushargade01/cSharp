using System;
namespace secondProgram{
    class Program{
        string student;
        public void stdDeatail(){
            System.Console.WriteLine("student Name: "+student);
        }
        public static void Main(string[] args){
            Program p = new Program();
            p.student = "tushar";
            Console.WriteLine(p.student);
            p.stdDeatail();
        }
    }
}