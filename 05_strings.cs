using System;
namespace Strings
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string s1 = "tushar";
			string s2 = ""; //empty string
			string s3 = string.Empty;
			
			string s4 = "hey";
			string s5 = "mr.";
			string s6 = s4+" "+s5;
			System.Console.WriteLine(s6);
			s6 += s1;
			s6 += "!";
			System.Console.WriteLine(s6);
		}
	}
}
