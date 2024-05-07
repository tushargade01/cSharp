using System;
namespace logicalOperator
{
	public class Program
	{
		public static void Main(string[] args)
		{
			bool isComplete = false;
			isComplete &= true;//isComplete = isComplete & true.
			System.Console.WriteLine(isComplete);
			System.Console.WriteLine(!isComplete+"\n");
			System.Console.WriteLine(true & true);
			System.Console.WriteLine(true & false);
			System.Console.WriteLine(true && true);
			System.Console.WriteLine(false && true);
			
			System.Console.WriteLine(true | true);
			System.Console.WriteLine(true | false);
			System.Console.WriteLine(true || true);
			System.Console.WriteLine(false || true);
			System.Console.WriteLine(false || false);
		}
	}
}
