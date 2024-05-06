using System;

namespace Slicing
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  string str = "abc"; 
		  string name = "tushar";
		  System.Console.WriteLine(str.Contains("bc"));
		  System.Console.WriteLine(str.Contains("ac"));
		  System.Console.WriteLine(str.Substring(0)); //index start form zero if there is 1 the it return bc,if there is 0 then it return abc.
		  System.Console.WriteLine(name.Substring(0,4));//(start index,length of index)
		}
	}
}
