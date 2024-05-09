using System;
namespace fristProgram{
    class Program{
        public static void Main(String[] args){
            bool running = true;
            do{
                Console.WriteLine("Enter Your name:");
                string userName = Console.ReadLine();
                int num;
                if(int.TryParse(userName,out num)){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter Name:");
                    Console.ResetColor();
                }else{
                    if(userName=="q"||userName=="quit" || userName=="Q"|| userName=="exit"||userName=="left" || userName=="close"){
                        running = false;
                    }else{
                        if(userName=="clear"){
                            Console.Clear();
                        }else{
                            Console.WriteLine($"Hello, {userName}");
                        }
                    }
                }
            }while(running);
        }
    }
}