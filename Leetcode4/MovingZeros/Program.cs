// Written by Andre
// 4/27/25
public class Solution {
    public void MoveZeroes(int[] nums) {
        int[] output = nums[0..nums.Count()];
        int counter = 0;
        for(int i = 0; i<nums.Count(); i++) {
            if(nums[i] != 0) {
                output[counter]=nums[i];
                counter++;
            }
        }
        while(counter<nums.Count()) {
            output[counter] = 0;
            counter++;
        }
        for(int i = 0; i<nums.Count(); i++) {
            nums[i] = output[i];
        }
    }
}
public class Program {
	static void Main(string[] args) {
		int[] testarray = {0, 1, 0, 2, 0, 3, 0, 4, 0, 5};
		Solution sol = new Solution();

		sol.MoveZeroes(testarray);

		foreach(int i in testarray) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b ");
	}
}
