// Written by Andre
// 2/27/25

namespace Homework5;

public class Program {
	static void Main(string[] args) {
		Car        popemobile = new Car("Mercedes-Benz", "G-Wagen", 2024, 2);
		Motorcycle ghostrider = new Motorcycle("Satan", "Hell Cycle", 666, false);

		Engineer engi = new Engineer("Dell Conagher", double.MinValue, "Practical Problems");
		Manager  HER  = new Manager("HER", double.MaxValue, 9);

		Circle    circle = new Circle("Blue", 20.0);
		Rectangle square = new Rectangle("Red", 10.0, 10.0);

		Cat cat = new Cat("Cheshire");
		Dog dog = new Dog("K9");
                                                                    //ish
		EBook ebook = new EBook("C# Player's Guide", "RB Whitaker", 2022, 6);
		PhysicalBook book = new PhysicalBook("Bible", "King James", 0, int.MaxValue);



		Console.WriteLine(popemobile);
		Console.WriteLine(ghostrider);
		Console.WriteLine(engi);
		Console.WriteLine(HER);
		Console.WriteLine(circle);
		Console.WriteLine(square);
		Console.WriteLine(cat);
		Console.WriteLine(dog);
		Console.WriteLine(ebook);
		Console.WriteLine(book);
	}
}
