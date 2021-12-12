using System;
using System.Collections.Generic;

public class checkbook
{
	private List<int> nums = new List<int>();
	private int sum = 0;


	public void add_item(int amount)
	{
		nums.Add(amount);
		sum += amount;
	}

	public int total()
	{
		return sum;
	}
}

public static class Globals
{
	internal static void Main()
	{
		checkbook c = new checkbook();

		c.add_item(5);
		c.add_item(6);
		c.add_item(7);
		c.add_item(8);
		c.add_item(9);

		Console.Write(c.total());
	}
}