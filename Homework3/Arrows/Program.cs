// Written by Andre
// 2/17/25

namespace Arrows;
public class Program {
	static void Main(string[] args) {
		Console.WriteLine("What material is the arrowhead? (hint: use numbers. 1,2,3,etc)");
		for (int i = 0; i < Enum.GetValues<Arrowheads>().Length; i++) { // this getvalues types garbage just gets the amount of values we have defined for the enum "Types"
			Console.Write($"{(Arrowheads)i}, "); // the (Arrowheads)i converts integer i to enum Types
		}
		Console.Write("\b\b  \n");//remove trailing comma and space

		Arrowheads arrowhead = (Arrowheads) Convert.ToInt32(Console.ReadLine()); // i still hate this type casting method. i really hope there's a better way to do this that i'm too stupid to understand right now

		Console.Write("How long is the shaft? (60-100) ");
		int shaftLength = Convert.ToInt32(Console.ReadLine());


		Console.WriteLine("What material is the fletching?");
		for (int i = 0; i < Enum.GetValues<Fletchings>().Length; i++) { // this getvalues types garbage just gets the amount of values we have defined for the enum "Types"
			Console.Write($"{(Fletchings)i}, ");
		}
		Console.Write("\b\b  \n"); 

		Fletchings fletching = (Fletchings) Convert.ToInt32(Console.ReadLine());

		Arrow arrow = new Arrow(arrowhead, shaftLength, fletching);

		Console.WriteLine($"The cost of this particular arrow is: {arrow.GetCost()}g");
	}
}
