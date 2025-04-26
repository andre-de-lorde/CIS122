// Written by Andre
// 4/25/25
public class Solution {
    public bool JudgeCircle(string moves) {
        int[] pos = {0,0};
        foreach(char i in moves) {
            switch(i) {
                case 'U':
                    pos[1]++;
                    break;
                case 'R':
                    pos[0]++;
                    break;
                case 'D':
                    pos[1]--;
                    break;
                case 'L':
                    pos[0]--;
                    break;
            }
        }
        return (pos[0]==0 && pos[1] == 0);
    }
}
public class Program {
	static void Main(string[] args) {
		string teststring = "LRLRLRLRLRLRLRLRDUDUDUDUDUDUDUDU";
		Solution sol = new Solution();
		Console.WriteLine(sol.JudgeCircle(teststring));
	}
}
