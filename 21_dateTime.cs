using System;

namespace datetime
{
	public class Program
	{
		public static void Main(string[] args)
		{
			System.Console.WriteLine(DateTime.Now);
			System.Console.WriteLine(DateTime.UtcNow);
			
			DateTime dt = new DateTime(2021,12,22);
			System.Console.WriteLine(dt);
			
			TimeSpan ts = new TimeSpan(5,2,59);
			System.Console.WriteLine(ts);
			System.Console.WriteLine(ts.Hours);
			System.Console.WriteLine(ts.Minutes);
			System.Console.WriteLine(ts.Seconds);
			
			System.Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
			System.Console.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy"));
			System.Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
			System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss tt"));
			System.Console.WriteLine(DateTime.UtcNow.Kind);
			System.Console.WriteLine(DateTime.Now.ToUniversalTime().ToString("hh:mm:ss tt")); //ToLocalTime()
			
		}
	}
}
