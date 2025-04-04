// Written by Andre
// 4/3/25
namespace TwoSum;

// i guess we doin arrays now
public class Program {
	static int[] NaiveFindIndicesToSum(int[] data, int sum) {
		for (int i=0; i<data.Length; i++) {
			for (int j=data.Length-1; j>=0; j--) {
				if (i == j) { break; } //skip over so you don't compare the same number
				if ((data[i] + data[j]) == sum) {
					return new int[] {i,j};
				}
			}
		}
	    return new int[] {-1,-1};
	}
	
	// you know i was gonna try and do this but i am NOT smart enough for this yet
	/*static int[] FastFindIndicesToSum(int[] data, int sum) {
		
	}*/
	static void Main(string[] args) {
		int[] numbers = {1,2,3,4,5,6,7,8,9,10};
		Console.WriteLine($"{NaiveFindIndicesToSum(numbers, 6)[0]}, {NaiveFindIndicesToSum(numbers, 6)[1]}");
	}
}
