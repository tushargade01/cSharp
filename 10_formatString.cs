using System;

namespace FormateString
{
	public class Program
	{
		public static void Main(String[] args)
		{
		  string name = "tushar";
		  int roll_no = 9;
		  float per = .71f;
		  System.Console.WriteLine(string.Format("my name is {1:C}.\nroll number is {0:C}.]\ni got a {2:P} percentage.",roll_no,name,per));
		}
	}
}
