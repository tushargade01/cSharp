using System;
namespace program{
    public class Program{
        private string name;
        public string userName{
            get{
                return name;
            }
            set{
                name=value;
            }
        }
        public static void Main(string[] args){
            Program p = new Program();
            p.name = "tushar";
            Console.WriteLine(p.name);
        }
    }
}