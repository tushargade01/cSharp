using System;
namespace Accembly1{
    class Student{
      private string[] name = new string[3];//create array name.
       // declaring an indexer
      public string this[int index]{ 
        get{
          return name[index];
        }
        set{
          name[index] = value;
        }
      }
    }

    public class Program{
      public static void Main(String[] args){
        Student s = new Student();
        s[0]="tushar";
        s[1]="omkar";
        s[2]="shubham";
        for(int i=0;i<3;i++){
          Console.WriteLine(s[i]);
        }
    }
    }
}