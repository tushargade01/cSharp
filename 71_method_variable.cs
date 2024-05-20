using System;
namespace Accembly1{
    public class Program{
        public void inputData(){
            string name = "tushar";
        }
        //we get error becuase name is method level variable
        public void getData(){
            Console.WriteLine(name);
        }
        public static void Main(String[] args){
                
        }
    }

}