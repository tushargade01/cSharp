using System;
namespace redKey{
    class Program{
        public static void Main(String[] args){
            ConsoleKeyInfo keyInfo;
            Console.TreatControlCAsInput = true;
            do{
                keyInfo = Console.ReadKey();
                if((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0){
                    Console.WriteLine(" ALT ");
                }
                if((keyInfo.Modifiers & ConsoleModifiers.Shift)!=0){
                    System.Console.WriteLine(" Shift ");
                }
                if((keyInfo.Modifiers & ConsoleModifiers.Control)!=0){
                    System.Console.WriteLine("Control");
                }
            }while(keyInfo.Key != ConsoleKey.Escape);
        }
    }
}