using System;
namespace firstProgram{
    public class Example{
        static void example1(params string[] words){
            foreach(string word in words){
                Console.WriteLine(word);
            }
        }
        public static void Main(String[] args){
            example1();
            example1("hii");
            example1("hi","hello");
        }
    }
}