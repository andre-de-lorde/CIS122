// Written by Shatranj
// 1/30/25

namespace ClocktowerRepair;

public class Program {
	static void Main(string[] args) {
		Console.Write("Input number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		if (number % 2 == 0) {   // easy peasy
			Console.WriteLine("Tick.");
		} else {
			Console.WriteLine("Tock.");
		}
	}
}
