// Written by Andre de Lorde
// 2/7/25
namespace MagicCannon;
public class Program {
	static void Main(string[] args) {
		bool fire;
		bool electric;
		ConsoleColor prevColor = Console.ForegroundColor;
		for (int i = 1; i <= 100; i++) {
			fire = false;
			electric = false;
			if (i % 3 == 0) {
				fire = true;
			}
			if (i % 5 == 0) {
				electric = true;
			}
			Console.ForegroundColor = ConsoleColor.White;	
			Console.Write($"{i}: ");
			if (fire && electric) {
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("Fire and Electric");
			} else if (fire) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Fire");
			} else if (electric) {
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Electric");
			} else {
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Normal.");
			}
		}
		Console.ForegroundColor = prevColor;
	}
}
