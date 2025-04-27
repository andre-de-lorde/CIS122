// Written by Andre
// 4/27/25
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> db = new Dictionary<int,int>();
        foreach(int i in nums) {
            if(!db.ContainsKey(i)) {
                db[i] = 1;
            } else {
                db[i]++;
            }
        }
        foreach(KeyValuePair<int,int> i in db) {
            if(i.Value > nums.Length/2) {
                return i.Key;
            }
        }
        return -1;//should never happen
    }
}
public class Program {
	static void Main(string[] args) {
		int[] testarray = {1,1,1,1,1,1,1,1,1,2,3,4,5,6,7};
		Solution sol = new Solution();
		
		Console.WriteLine(sol.MajorityElement(testarray));
	}
}
