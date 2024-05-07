using System;
namespace breakContinue
{
	public class Program
	{
		public static void Main(string[] args)
		{
			for(int i=1;i<11;i++){
			  if(i==4){
			    continue;
			  }
			  //here we use both if or else if. 
			  else if(i==7){
			    break;
			  }
			  System.Console.WriteLine(i);
			}
		}
	}
}
