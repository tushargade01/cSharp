using System;

namespace workingwithString
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string str = "abc";
			str = str.Insert(3,"d");
			str = str.Remove(2,1);
			str = str.Trim('a');
			str = str.Replace("bd","abcdreplace");
			System.Console.WriteLine(str);
			
			string str1 = "my name is tushar";
			string[] sarr = str1.Split(' ');
			
			System.Console.WriteLine(str1);
			
			foreach(string i in sarr){
			  System.Console.WriteLine(i);
			}
		}
	}
}
