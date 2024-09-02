//we can not inherit static class
using System;
namespace Accembly1{
    class Codes{
        public virtual void codeMsg(){
            Console.WriteLine("mere itane karib mat aao me tumhe barbad kar dungi.");
        }
    }
    class Program: Codes{
        public override void codeMsg()
        {
            base.codeMsg();
            Console.WriteLine("me barbad hona chahata hu....😶");
        }
        public static void Main(String[] args){
            Program p = new Program();
            p.codeMsg();
        }
    }
}