using System;
namespace Accembly1{
  class Student{
    static public string studentCollage = "DPMK";
    public string studentName;
  }
  public class Program{
    public static void Main(String[] args){
      Student std1 = new Student();
      std1.studentName = "tushar";
      Console.WriteLine("Name: "+std1.studentName);
      Console.WriteLine("College: "+Student.studentCollage);

      Student std2 = new Student();
      std2.studentName = "shubham";
      Console.WriteLine("Name: "+std2.studentName);
      Console.WriteLine("college: "+Student.studentCollage);
    }
  }
}