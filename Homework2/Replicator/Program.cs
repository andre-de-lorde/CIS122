// Written by Andre de Lorde
// 2/7/25
namespace Replicator;
public class Program {
	static void Main(string[] args) {
		int[] array1 = new int[5];
		int choice;
		for (int i = 0; i < 5; i++) {
			Console.Write("Input a number: ");
			choice = Convert.ToInt32(Console.ReadLine());
			array1[i] = choice;
		}

		int[] array2 = new int[5];
		for (int i = 0; i < 5; i++) {
			array2[i] = array1[i];
		}

		Console.WriteLine("Here are both arrays for comparison:");
		foreach (int i in array1) {
			Console.Write($"{i},");
		}
		Console.Write("\b \n"); // go back a character with \b and overwrite the trailing comma with space, then go to new line
		foreach (int i in array2) {
			Console.Write($"{i},");
		}
		Console.Write("\b \n");
	}
}
