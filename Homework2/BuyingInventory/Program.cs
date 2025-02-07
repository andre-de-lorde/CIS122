// Written by Andre de Lorde
// 2/6/25
namespace BuyingInventory;
public class Program {
	static void Main(string[] args) {
		string menu = @"The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
What number do you want to see the price of? ";
		Console.Write(menu);
		int choice = Convert.ToInt32(Console.ReadLine());
		switch (choice) {
			case 1:
				Console.WriteLine("Rope costs 10 gold.");
				break;
			case 2:
				Console.WriteLine("Torches cost 15 gold.");
				break;
			case 3:
				Console.WriteLine("Climbing Equipment costs 25 gold.");
				break;
			case 4:
				Console.WriteLine("Clean Water costs 1 gold.");
				break;
			case 5:
				Console.WriteLine("A Machete costs 20 gold.");
				break;
			case 6:
				Console.WriteLine("A Canoe costs 200 gold.");
				break;
			case 7:
				Console.WriteLine("Food Supplies cost 1 gold.");
				break;
			default:
				Console.WriteLine("That's not an item, silly.");
				break;
		}
	}
}
