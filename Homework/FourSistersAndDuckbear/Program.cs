// Written by Shatranj
// Date: 1/30/25

namespace FourSistersAndDuckbear;
// Found out I can just declare namespaces like this, which is nice for me because I'm a moderately dedicated never-nester.


public class Program {
	static void Main(string[] args) {
		Console.Write("How many eggs were collected? "); // Write instead of writeline to keep the text on one line because I like it that way.


		int eggCount = Convert.ToInt32(Console.ReadLine()); // Get user input and convert to an int named eggCount
		// Found out I can use Convert instead of Parse, which is probably better, but I don't know enough yet.
		int remainder = eggCount % 4;
		eggCount -= remainder; // fed to duckbear

		int perSister = eggCount / 4;

		// no need to go to a new line for the above Write statement, as the user's inputs already apply one.

		Console.Write("The sisters each get "); //cutoff for special text in case of 1 or 0 eggs.
		if (perSister == 0) {
			Console.Write("no eggs. Looks like we're having chicken soup.");
		} else if (perSister == 1) {
			Console.Write("1 egg.");
		} else {
			Console.Write($"{perSister} eggs. Chocolate omelettes for everyone!");
		}
		Console.Write("\n"); //go to new line for printing the bugbear's amount


		Console.Write("The bugbear gets the leftovers, of which there are "); //again, another cutoff for special text
		if (remainder == 0) {
			Console.Write("none. Too bad.");
		} else if (remainder == 1) {
			Console.Write("only 1.");
		} else {
			Console.Write($"{remainder}. Very nice.");
		}
		Console.Write("\n"); //go to newline
	}
}
