using System;

namespace Switch
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  int day = 3;
			switch(day)
			{
			  case 1:System.Console.WriteLine("monday");
			  break;
			  case 2: System.Console.WriteLine("Tuesaday");
			  break;
			  case 3: System.Console.WriteLine("Wednsday");
			  break;
			  case 4:System.Console.WriteLine("Thursday");
			  break;
			  case 5: System.Console.WriteLine("Friday");
			  break;
			  case 6: System.Console.WriteLine("Saturday");
			  break;
			  case 7: System.Console.WriteLine("Sunday");
			  break;
			  default:System.Console.WriteLine("day out of range");
			  break;
			}
		}
	}
}
