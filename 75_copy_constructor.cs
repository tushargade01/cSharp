using System;
namespace Accembly1{
    public class Program{
        string car;
        string copyCar;
        Program(string getGarName){
            car = getGarName;
        }
        Program(Program p1){ //copy contructor
            copyCar = p1.car;
        }

        public static void Main(String[] args){
            Program p = new Program("bugati");
            Console.WriteLine(p.car);
            Program p1 = new Program(p);
            Console.WriteLine(p1.copyCar);
        }
    }
}