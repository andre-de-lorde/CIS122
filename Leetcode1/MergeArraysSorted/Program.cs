// Written by Andre
// 4/3/25

namespace MergeArraysSorted;

public class Program {
	static void Merge(int[] arr1, int amt1, int[] arr2, int amt2) {
		for(int i=0; i<amt2; i++) {
    		arr1[amt1+i] = arr2[i];
    	}
    	Array.Sort(arr1);
    }

	static void Main(string[] args) {
		int[] arr1 = {1,3,5,7,9,0,0,0,0};
		int[] arr2 = {2,4,6,8};

		Console.Write("Array 1: {");
		foreach (int i in arr1) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b}");

		Console.Write("Array 2: {");
		foreach (int i in arr2) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b}");


		Merge(arr1,5,arr2,4);
			
		Console.Write("Output:  {");
		foreach (int i in arr1) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b}");
	}
}
