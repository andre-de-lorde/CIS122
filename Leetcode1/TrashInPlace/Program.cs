// Written by Andre
// 4/3/25

namespace TrashInPlace;



public class Program {
	//this was worded really annoyingly and could have been written much better
	static int PurgeInPlace(int[] data, int topurge) {
		int purges = 0;
		for (int i = 0; i<data.Length-purges; i++) {
			if (data[i] == topurge) {
                purges++;
                data[i] = data[^purges];
				data[^purges] = topurge;
                i--;
			}
		}
		return (data.Length)-purges;
	}

	static void Main(string[] args) {
		int[] data = {1,2,3,4,5,6,7,8,9,10,9,8,7,6,5,4,3,2,1};

		Console.Write("data={");
		foreach (int i in data) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b}");

		PurgeInPlace(data,2);
		
		Console.WriteLine("\"Purged\" the number 2.");

		Console.Write("data={");
		foreach (int i in data) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b}");
	}
}
