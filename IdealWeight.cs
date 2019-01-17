using System;

class IdealWeight
{
	public static void Main(string[] args) 
	{
	/*
		BMI = W / H^2
		LW = 19 * H^2
		HW = 20 * H^2
	*/
	Console.WriteLine("Your height in meters: ");	
	double height = double.Parse(Console.ReadLine());
	Console.WriteLine("Your current weight: ");
	double currentWeight = double.Parse(Console.ReadLine());
	double lowBorder = 19 * Math.Pow(height, 2);
	double highBorder = 20 * Math.Pow(height, 2);
	string message = $"Your optimal weight is between {lowBorder:F2} and {highBorder:F2}.";
	Console.WriteLine(message);

		if (currentWeight >= highBorder) 
		{
			Console.WriteLine($"You need to lose between {(currentWeight - highBorder):F2} and {(currentWeight - lowBorder):F2} kilograms");
		}
	}
}
