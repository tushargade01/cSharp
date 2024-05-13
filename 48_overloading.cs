using System;
namespace firstProgram{
    class Program{
     int addNUmber(int a,int b){return a+b;}
     int addNUmber(int a,int b,int c){return a+b+c;}
     int addNUmber(int a,int b,int c,int d){return a+b+c+d;}
     //float addNUmber(int a,int b){return a+b;}
     static void Main(String[] args){
        Program p = new Program();
        Console.WriteLine(p.addNUmber(2,4));
     }
    }
}