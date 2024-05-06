using System;
namespace cheackEqualString {
  class Program{
    static void Main(String[] args){
      string s1 = "abc";
      string s2 = "abc";
      System.Console.WriteLine(s1==s2); //check equak or not
      System.Console.WriteLine(string.Equals(s1,s2)); //check equak or not using function
    }
  }
}
