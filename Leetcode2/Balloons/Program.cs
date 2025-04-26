// Written by Andre
// 4/25/25
public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] balon = {0, 0, 0, 0, 0};
        foreach (char i in text) {
            switch(i) {
                case 'b':
                    balon[0]=balon[0]+2;
                    break;
                case 'a':
                    balon[1]=balon[1]+2;
                    break;
                case 'l':
                    balon[2]++;
                    break;
                case 'o':
                    balon[3]++;
                    break;
                case 'n': 
                    balon[4]=balon[4]+2;
                    break;
            }
        }
        int bbuf = int.MaxValue;
        foreach(int i in balon){
            if (bbuf > i) {
                bbuf = i;
            }
        } 
        return bbuf >> 1;
    }
}

public class Program {
	static void Main(string[] args) {
		string teststring = "teststringteststringbbbbballoonaognaognaolbabablaobnaonbalboanboanlbnaobanblanlboabnalbnalnoanblabaobnalbnaobnoanblanboanobalbnaobnaonblaobn";
		Solution sol = new Solution();
		Console.WriteLine(sol.MaxNumberOfBalloons(teststring));
	}
}
