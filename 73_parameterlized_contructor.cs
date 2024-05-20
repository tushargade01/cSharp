using System;
namespace Accembly1{
    public class Program{
        string StdName;
        double percentage;
       Program(string name, double per){
        StdName = name;
        percentage = per;
       }
        public static void Main(String[] args){
            Program p = new Program("tushar",77);
            Program p1 = new Program("shubham",97);
            Console.WriteLine("Name: "+p.StdName+" Per: "+p.percentage); 
            Console.WriteLine("Name: "+p1.StdName+" Per: "+p1.percentage); 
                
        }
    }
}