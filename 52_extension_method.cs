using System;
namespace firstProgram{
    public static class Example{
        public static bool greaters(this int i,int val){
            if(i>val){
                return true;
            }else{
                return false;
            }
        }
        public static void Main(String[] args){
          Console.WriteLine(2.greaters(1));
          Console.WriteLine(greaters(5,1));
          Console.WriteLine(greaters(1,2));
        }
    }
}