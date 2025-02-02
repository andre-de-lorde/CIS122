// Written by Shatranj
// Date is 1/30/25


namespace TriangleFarmer {
	public class Program {
		static void Main(string[] args) {
			Console.Write("Width of Triangle: "); //Write instead of WriteLine so i can have it all on one line because i like it that way
			double width = double.Parse(Console.ReadLine());

			// I don't have to print a newline since the user already does when inputing the numbers

			Console.Write("Height of Triangle: ");
			double height = double.Parse(Console.ReadLine());

			Console.Write("\n"); // I do make a newline here, though, just to make the output spaced a line away from the inputs

			double area = (width*height)/2;
			Console.WriteLine("Triangle Area is {0}.",area);
		}
	}
}
