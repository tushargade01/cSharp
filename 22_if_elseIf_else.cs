using System;
namespace ifElse
{
	public class Program
	{
		public static void Main(string[] args)
		{
			if(2>3){
			  System.Console.WriteLine("2 is greater than 3");
			}
			else if(3>2){
			  System.Console.WriteLine("3 is greater than 2");
			  if(true){
			    System.Console.WriteLine("this program is easy to understand.");
			  }else{
			    System.Console.WriteLine("this program is difficult to understand.");
			  }
			  
			}
			else{
			  System.Console.WriteLine("both are not Number");
			}
		}
	}
}
