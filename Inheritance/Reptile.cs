using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public int Weight { get; set; }

		public bool HasClaws { get; set; }

		public bool HasScales { get; set; }

		public string ColdBlooded { get; set; }

		public void RepDetails()
		{
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Weight: {100} pounds");
            Console.WriteLine($"Has Claws: {false} ");
            Console.WriteLine($"Has Scales: {true}");
            Console.WriteLine($"Legs: {0}");
            Console.WriteLine($"BodySize: {"Extra Large"}");
            Console.WriteLine($"Male or Female: {"Male"}");
            Console.WriteLine($"Age; {8} years old ");
        }


	}
}

