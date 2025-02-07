// Written by Andre de Lorde
// 2/7/25
namespace ThePrototype;
public class Program {
	static void Main(string[] args) {
		Console.Write("Pilot, enter a number from 1-100: ");
		int number = Convert.ToInt32(Console.ReadLine());
		Console.Write("Pilot, enter how many tries the hunter gets: ");
		int lives = Convert.ToInt32(Console.ReadLine());
		Console.Clear();
		int guess = -1;
		
		while (lives >= 0) {
			Console.Write($"You have {lives} guess(es) left, so Hunter, enter your guess: ");
			guess = Convert.ToInt32(Console.ReadLine());
			if (guess > number) {
				Console.Write("Too high. ");
			} else if (guess < number) {
				Console.Write("Too low. ");
			}

			if (guess == number) {
				Console.WriteLine("Ding Ding Ding! You got it!");
				Console.WriteLine($"You had {lives} guess(es) left.");
				break;
			} else {
				Console.WriteLine("Try again.");
			}
			lives -= 1;
		}
	}
}

