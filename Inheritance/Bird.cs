using System;
namespace Inheritance
{
	public class Bird : Animal
	{
        public Bird()
        {

        }

        public string BeakSize { get; set; }

        public int WingSpan { get; set; }

        public int Height { get; set; }

        public string Color { get; set; }

        public void Details()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Wing Span: {12} inches");
            Console.WriteLine($"Height: {6} inches");
            Console.WriteLine($"Bird Color: {"Red"}");
            Console.WriteLine($"Legs: {2}");
            Console.WriteLine($"BodySize: {"Tiny"}");
            Console.WriteLine($"Male or Female: {"Female"}");
            Console.WriteLine($"Age; {5} years old ");
        }

    }
    
}

