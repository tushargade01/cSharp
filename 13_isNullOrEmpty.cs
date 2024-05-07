using System;
namespace isNullOrEmpty
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  string str = null;
		  string str1 = String.Empty;
		  string str3 = "tushar";
			System.Console.WriteLine(String.IsNullOrEmpty(str));
			System.Console.WriteLine(String.IsNullOrEmpty(str1));
			System.Console.WriteLine(String.IsNullOrEmpty(str3));
			System.Console.WriteLine(String.IsNullOrEmpty("hello"));
		}
	}
}
