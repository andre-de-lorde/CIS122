// Written by Andre
// 4/27/25
public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        bool took_sandwich = true;
        Queue<bool> stu = new Queue<bool>();
        Stack<bool> sand = new Stack<bool>();
        for(byte i = (byte)students.Length; i>0; i--) {
            stu.Enqueue(students[^i]==1);
            sand.Push(sandwiches[i-1]==1);
        }
        byte counter = 0;
        while(took_sandwich) {
            took_sandwich = false;
            counter=0;
            while(counter < stu.Count()) {
                if(stu.Peek() == sand.Peek()) {
                    sand.Pop();
                    took_sandwich = true;
                } else {
                    stu.Enqueue(stu.Peek());
                }
                stu.Dequeue();
                counter++;
            }
        }
        return stu.Count();
    }
}
public class Program {
	static void Main(string[] args) {
		int[] students   = {0, 1, 0, 1, 0, 1, 1, 0, 1};
		int[] sandwiches = {1, 0, 1, 0, 1, 0, 0, 1, 0};
		Solution sol = new Solution();
		Console.WriteLine(sol.CountStudents(students,sandwiches));
	}
}
