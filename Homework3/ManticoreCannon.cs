// Written by Andre de Lorde
// 2/7/25
namespace Manticore;
public class Cannon {
	private int shots = 0;
	public void Increment() {
		this.shots += 1;
	}
	public int CalculateDamage() {
		bool fire = false;
		bool electric = false;
		if (this.shots % 3 == 0) {
			fire = true;
		}
		if (this.shots % 5 == 0) {
			electric = true;
		}
		if (fire && electric) {
			return 10;
		} else if (fire) {
			return 3;
		} else if (electric) {
			return 3;
		} else {
			return 1;
		}
	}
}
