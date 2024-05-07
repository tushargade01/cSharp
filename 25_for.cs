using System;
namespace forLoop
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  /*
			int i = 0;
			for( ; ; ){
			  if(i<4){
			    System.Console.WriteLine(i);
			    i++;
			  }
			}
			*/
			string name = "tushar";
			for(int t = 0; t<name.Length; t++){
			  System.Console.WriteLine(name[t]);
			}
			System.Console.WriteLine("\n");
			for(int t = name.Length-1; t>=0; t--){
			  System.Console.WriteLine(name[t]);
			}
		}
	}
}
