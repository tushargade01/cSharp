//we can not inherit static class
using System;
namespace Accembly1{
    class Student{
        public string stdName;
        public string stdCollege;
        public void setName(){
            Console.WriteLine("Name: "+stdName);
        }
    }
    class Program: Student{
        public void getCollage(){
            Console.WriteLine("College: "+stdCollege);
        }
        public static void Main(String[] args){
            Program p = new Program();
            p.stdName = "tushar";
            p.stdCollege = "DPMK";

            p.setName();
            p.getCollage();
        }
    }
}