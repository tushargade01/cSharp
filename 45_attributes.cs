//try it but i cant unserstand
using System;
namespace firstProgram{
    class exampleProgram{
       [Obsolete("oldmethod is absolute.Please use newMethod instead.")]
       static void oldMethod(){Console.WriteLine("hello");}
       static void newMethod(){Console.WriteLine("wrold");}
        public static void Main(String[] args){
            oldMethod();
        }
    }
}