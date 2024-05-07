using System;
namespace valueTypeAndReferType
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  /*
		  valueType
		  it create copy
		  */
		  int i = 100;
		  System.Console.WriteLine(i);
			changeValue(i);
			System.Console.WriteLine(i);
			
			/*
		  refernce Type
		  */
			Person p = new Person();
			p.name = "shubham";
			chnageperName(p);
			System.Console.WriteLine(p.name);
		}
		static void changeValue(int num){
		  num = 500;
		  System.Console.WriteLine(num);
		}
		
		class Person{
		  public string name;
		}
		static void chnageperName(Person person){
		  person.name = "tushar";
		}
	}
}
