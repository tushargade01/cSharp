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

            Program p2 = new Program();
            p2.student = "shubham";
            p2.stdDeatail();
            Console.WriteLine(p2.student);
        }
    }
}