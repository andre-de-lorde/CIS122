// Written by Andre
// 4/26/25
public class Solution {
    public int PivotIndex(int[] nums) {
        for(int i = 0; i<nums.Count(); i++) {
            if(nums[0..i].Sum() == nums[(i+1)..(nums.Count())].Sum()) {
                return i;
            }
        }
        return -1;
    }
}
public class Program {
	static void Main(string[] args) {
		int[] testarray = new int[] {1,2,3,4,5,6,7,8,9,0,9,8,7,6,5,4,3,2,1};
		Solution sol = new Solution();
				
		foreach(int i in testarray) {
            Console.Write(i);
        }
		Console.WriteLine();
		
		int pivotindex = sol.PivotIndex(testarray);

		foreach(int i in testarray[0..(pivotindex)]) {
            Console.Write(i);
        }
        Console.Write("|");
        foreach(int i in testarray[(pivotindex+1)..(testarray.Count())]) {
	        Console.Write(i);
        }
        Console.WriteLine();
	}
}
