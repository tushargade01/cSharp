using System;
namespace readLine
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter your name: ");
			string userName = System.Console.ReadLine();
			Console.WriteLine($"hello,{userName}");
		}
	}
}
