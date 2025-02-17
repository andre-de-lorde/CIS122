// Written by Andre
// 2/17/25

namespace Manticore;
public class Program {
	static void Main(string[] args) {
		Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
		int manticoreRange = Convert.ToInt32(Console.ReadLine());
		Console.Clear();

		bool        gameEnd = false;
		bool            win = false;
		int manticoreHealth = 10;
		int      cityHealth = 15;
		int           round = 0;
		int      inputRange = -1;
		Cannon MagicCannon = new Cannon();


		Console.WriteLine("Player 2, it is now your turn.");

		while (!gameEnd) {
			round++;
			MagicCannon.Increment();
			Console.Write(
$@"-----------------------------------------------------------
STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10
The cannon is expected to deal {MagicCannon.CalculateDamage()} this round.
Enter desired cannon range: ");
			inputRange = Convert.ToInt32(Console.ReadLine());
			if (inputRange < manticoreRange) {
				Console.WriteLine("That round UNDERSHOT the target.");
			} else if (inputRange > manticoreRange) {
				Console.WriteLine("That round OVERSHOT the target.");
			} else {
				Console.WriteLine("That round was a direct hit.");
				manticoreHealth -= MagicCannon.CalculateDamage();
			}

			if (manticoreHealth < 1) { // might go below zero
				win = true;
				gameEnd = true;
			} else if (cityHealth < 1) {
				win = false;
				gameEnd = true;
			}
			cityHealth--;
		}

		if (win) {
			Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
		} else {
			Console.WriteLine("You failed to destroy the manticore in time! The city has fallen.");
			Console.WriteLine("(Hey pal, google binary tree for a hint.)");
		}
	}
}
