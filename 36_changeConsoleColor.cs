using System;
namespace firstProgram {
    public class Program 
    {
        public static void Main(String[] args) {
            System.Console.WriteLine("'r' for red\n 'g' for green\n 'b' for blue");
            int x = Console.Read();
            char userInput = Convert.ToChar(x);

            while (userInput != 'z') {
                switch (userInput)
                {
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    default: break;
                }
                Console.Clear();
                System.Console.WriteLine("'r' for red\n 'g' for green\n 'b' for blue");
                x = Console.Read();
                userInput = Convert.ToChar(x);
            }

        }
    }
}
