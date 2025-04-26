// Written by Andre
// 4/25/25
public class Solution {
    public int CountSegments(string s) {
        List<string> data = s.Split(' ').ToList();
        for(int i = 0; i<data.Count; i++) {
            if (data[i]=="") {
                data.RemoveAt(i);
                i--;
            }
        }
        return data.Count;
    }
}
public class Program {
	static void Main(string[] args) {
		string teststring = "’Twas brillig, and the slithy toves Did gyre and gimble in the wabe: All mimsy were the borogoves, And the mome raths outgrabe.";
		Solution sol = new Solution();
		Console.WriteLine(sol.CountSegments(teststring));
	}
}
