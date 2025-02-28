// Written by Andre
// 2/27/25

namespace Homework5;
// {{{ Parent Class Vehicle
public class Vehicle {
	public string Make  {get;set;}
	public string Model {get;set;}
	public int    Year  {get;set;}

	public Vehicle(string pMake, string pModel, int pYear) {
		this.Make  = pMake;
		this.Model = pModel;
		this.Year  = pYear;
	}

	public Vehicle() : this("Null","Null",0) {}

	public override string ToString() {
		return $"{this.Make} {this.Model} {this.Year}";
	}

}
// }}} Parent Class Vehicle

// {{{ Child Classes Car, Motorcycle of Vehicle
public class Car : Vehicle {
	public int NumberOfDoors {get;set;}

	public Car(string pMake, string pModel, int pYear, int pNumberOfDoors) : base(pMake, pModel, pYear) {
		this.NumberOfDoors = pNumberOfDoors;
	}

	public override string ToString() {
		return $"{this.Year} {this.Make} {this.Model} with {this.NumberOfDoors} doors";
	}
}

public class Motorcycle : Vehicle {
	public bool HasSidecar {get;set;}

	public Motorcycle(string pMake, string pModel, int pYear, bool pHasSidecar) : base(pMake, pModel, pYear) {
		this.HasSidecar = pHasSidecar;
	}

	public override string ToString() {
		return $"{this.Year} {this.Make} {this.Model} (Has Sidecar: {this.HasSidecar})";
	}
}
// }}} Child Classes Car, Motorcycle of Vehicle

