using System;
using System.Collections.Generic;

namespace boolFlag
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> list = new List<int>();
			
			list.Add(1);
			list.Add(2);
			list.Add(6);
			list.Add(3);
			System.Console.WriteLine(list);
			
			bool flag = false;
			foreach(int i in list){
			  if(i == 6){
			    flag = true;
			  }
			}
			
			if(flag){
			  System.Console.WriteLine("6 number is present in the list.");
			}else{
			  System.Console.WriteLine("6 not present in the list.");
			}
		}
	}
}
