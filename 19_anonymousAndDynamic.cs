using System;
namespace anonymousAndDynamic
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var name = "tushar"; // anonymous type
			var roll_no = 9; //create at compile time
			
			dynamic name1 = "mia";//dynamic type
			dynamic roll_no1 = "1"; //created or resolve at runtime
			
		}
	}
}
