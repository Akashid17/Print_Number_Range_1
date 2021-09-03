
using System;

class ArithmeticX
{
	public void DisplayRange(int iNo1, int iNo2)
	{
		if(iNo1 > iNo2)
		{
			Console.WriteLine("Invalid Range");
			return;
		}

		for(int i = iNo1; i <= iNo2; i++)
		{
			Console.Write(i+" ");
		}
		Console.WriteLine();
	}
}

class main
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter First Number");
		int iValue1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter Second Number");
		int iValue2 = Convert.ToInt32(Console.ReadLine());

		ArithmeticX aobj = new ArithmeticX();
		aobj.DisplayRange(iValue1,iValue2);
	}
}