// Written by Andre WHILE HE WAS ASLEEP
// 4/27/25          how about some hard problems next time lmao
public class Solution {
    public void ReverseString(char[] s) {
        char buffer;
        for(int i = 0; i<(s.Length/2); i++) {
            buffer = s[i];
            s[i] = s[^(i+1)];
            s[^(i+1)] = buffer;
        }
    }
}
public class Program {
	static void Main(string[] args) {
		char[] teststring = new char[24];
		for(int i = 0; i<24; i++) {
			teststring[i]="He lived as a devil, eh?"[i];
		}
		Solution sol = new Solution();
		Console.WriteLine(teststring);
		sol.ReverseString(teststring);
		Console.WriteLine(teststring);
	}
}
