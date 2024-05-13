using System;
using System.Diagnostics;
using System.Threading.Tasks;
namespace firstProgram{
    public class Example{
        static async Task cookMeat(){
            Console.WriteLine("cook Meat");
        }
        static async Task cookVegetables(){
            Console.WriteLine("cook Meat");
        }
        static async Task makeBread(){
            Console.WriteLine("make bread");
        }
        static async Task makeSoup(){
            Console.WriteLine("make soup");
        }
        static async void makeDinner(){
            await cookMeat();
            await cookVegetables();
            await makeBread();
            await makeSoup();
        }
        public static void Main(String[] args){
            makeDinner();
        }
    }
}