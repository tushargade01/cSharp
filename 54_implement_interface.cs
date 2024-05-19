using System;
namespace firstProgram{
    public class Example:IExample{
       
        public static void Main(String[] args){
        
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            Console.WriteLine(string1+" "+string2);
        }

        public void somesthing()
        {
            Console.WriteLine("hello Wrold!");
        }
    }
    interface IExample{
        void somesthing();
        int Example2();
        string Example3(string string1, string string2);
    }
}