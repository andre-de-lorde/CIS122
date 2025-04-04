// Written by Andre
// 4/4/25

namespace ParityShift;

public class Program {
	static int[] SortByParity(int[] data) {
		// may have been forgetting to not modify the parameters in earlier programs... oopsies
		// i don't wanna go fix it though... :(
        // i tried and it was so tedious and we're not in a serious real enviroment so i don't care
		int index = 0;
		bool reversed = false;
		bool swapmade = true;
        int swapbuffer;

        if (data.Length < 2) {
            return data;
        }

		while (swapmade) { //haha shaker sort go brrr
			swapmade=false;
			while (true) {
				if (!reversed) {
					if ((data[index] % 2) != 0 && (data[index+1] % 2) == 0) {
                        swapbuffer = data[index];
                        data[index]=data[index+1];
                        data[index+1] = swapbuffer;
						swapmade=true;
					}
					index++;
					if (index == data.Length-1) {
						reversed = true;
						break;
					}
				} else {
					if ((data[index] % 2) == 0 && (data[index-1] % 2) != 0) {
                        swapbuffer = data[index-1];
                        data[index-1]=data[index];
                        data[index] = swapbuffer;
						swapmade=true;
					}
					index--;
					if (index == 0) {
						reversed = false;
						break;
					}
				}
			}
		}
        return data;
	}

	static void Main(string[] args) {
		int[] data = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

		Console.Write("data = {");
		foreach (int i in data) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b}");

		data = SortByParity(data);
		Console.WriteLine("Data shifted.");
		
		Console.Write("data = {");
		foreach (int i in data) {
			Console.Write($"{i},");
		}
		Console.WriteLine("\b}");
	}
}
