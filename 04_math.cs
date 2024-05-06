using System;//math class Found in System class


namespace math
{
	public class Program
	{
		public static void Main(string[] args)
		{
			System.Console.WriteLine(Math.Abs(-2.6f)); //it return absolute value.
			System.Console.WriteLine(Math.Round(6.7)); //it reurn higher
			System.Console.WriteLine(Math.Ceiling(6.7)); //siiler as round
			System.Console.WriteLine(Math.Floor(6.7)); //oppsite to round
			System.Console.WriteLine(Math.Truncate(6.7)); //similer as floor
			System.Console.WriteLine(Math.Min(6,2)); //take only two value
			System.Console.WriteLine(Math.Max(6,7)); //take only two arguments
		}
	}
}
