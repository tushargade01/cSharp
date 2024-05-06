
using System;
namespace dataType{
  class A{
    public static void Main(String[] args){
      int itgr = 2;
      float ft = 2.8f;
      char ch = 'a'; //use single quate
      String str = "This is string.."; //use double quate
      
      System.Console.WriteLine(itgr);
      System.Console.WriteLine(ft);
      System.Console.WriteLine(ch);
      System.Console.WriteLine(str);
      
      System.Console.WriteLine(typeof(int));
      System.Console.WriteLine(typeof(float));
      System.Console.WriteLine(typeof(double));
      System.Console.WriteLine(typeof(char));
      System.Console.WriteLine(typeof(string));
      
      /*
        double is just alias of System.double
      */
      
      System.Double d = 5.3546d;
      System.Console.WriteLine(d);
    }
  }
}
