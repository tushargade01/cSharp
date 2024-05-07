using System;
namespace boxingAndUnboxing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int i = 5;
			float ft = i;
			System.Console.WriteLine(ft);//implicit conversion. it directly convert without change type.
			
			float floatNumber = 4.5f;
			int intNumber = (int)floatNumber;//explicit conversion. example: (float),(int)..etc.
			System.Console.WriteLine(intNumber);
		
		  string myName = "tushar";
		  object obj1 = myName;//boxing.store (int,string,float,etc) value in object refernce.  
		  System.Console.WriteLine(obj1);
		  
		  string getMyName = (string)obj1;//unboxing.when we retrieve a value form object refernce.
		  System.Console.WriteLine(getMyName);
		}
	}
}
