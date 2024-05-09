using System;
namespace fristProgram{
    class Program{
        public static void Main(String[] args){
            do{
                string userInput = Console.ReadLine();
                int num;
                if(!int.TryParse(userInput, out num)){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Enterd invalid Input.");
                    Console.ResetColor();
                    Console.WriteLine("Enter NUmber: ");
                }
                else{
                    Console.WriteLine("\nthanks for Entering NUmber.");
                }
            }while(true);
        }
    }
}