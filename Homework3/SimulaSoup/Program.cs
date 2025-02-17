// Written by Andre
// 2/17/25

namespace SimulaSoup;

public class Program {
	enum      Types { Soup, Stew, Gumbo };
	enum      Bases { Mushroom, Chicken, Carrot, Potato };
	enum Seasonings { Spicy, Salty, Sweet };
	static void Main(string[] args) {
		int choice = 0;
		(Types, Bases, Seasonings) soup = (Types.Soup, Bases.Mushroom, Seasonings.Spicy);

		Console.WriteLine("What type of meal do you want? (hint: use numbers. 1,2,3,etc)");
		for (int i = 0; i < Enum.GetValues<Types>().Length; i++) { // this getvalues types garbage just gets the amount of values we have defined for the enum "Types"
			Console.Write($"{(Types)i}, "); // the (Types)i converts integer i to enum Types
			// this is weird type casting and i don't like how it looks :(
		}
		Console.Write("\b\b  \n"); //removes trailing comma and space
		choice = Convert.ToInt32(Console.ReadLine());
		soup.Item1 = (Types) (choice-1);

		for (int i = 0; i < Enum.GetValues<Bases>().Length; i++) {
			Console.Write($"{(Bases)i}, ");
		}
		Console.Write("\b\b  \n");
		choice = Convert.ToInt32(Console.ReadLine());
		soup.Item2 = (Bases) (choice-1);

		for (int i = 0; i < Enum.GetValues<Seasonings>().Length; i++) {
			Console.Write($"{(Seasonings)i}, ");
		}
		Console.Write("\b\b  \n");
		choice = Convert.ToInt32(Console.ReadLine());
		soup.Item3 = (Seasonings) (choice-1);

		Console.WriteLine($"You made a {soup.Item3} {soup.Item2} {soup.Item1}.");
	}
}
