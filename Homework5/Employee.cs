// Written by Andre
// 2/27/25

namespace Homework5;

// {{{ Parent Class Employee
public class Employee {
	public string Name   {get;set;}
	public double  Salary {get;set;}

	public Employee(string pName, double pSalary) {
		this.Name   = pName;
		this.Salary = pSalary;
	}

	public override string ToString() {
		return $"Employee: {this.Name}, Salary: {this.Salary}";
	}
}
// }}} Parent Class Employee

// {{{ Child Classes Manager, Engineer of Employee
public class Manager : Employee {
	public int NumberOfEmployeesManaged {get;set;} //a bit wordy, innut

	public Manager(string pName, double pSalary, int pNumberOfEmployeesManaged) : base(pName, pSalary) {
		this.NumberOfEmployeesManaged = pNumberOfEmployeesManaged;
	}
	
	public override string ToString() {
		return $"Employee: {this.Name}, Salary: {this.Salary}, Employees Managed: {this.NumberOfEmployeesManaged}";
	}
}

public class Engineer : Employee {
	public string Specialization {get;set;}

	public Engineer(string pName, double pSalary, string pSpecialization) : base(pName, pSalary) { //oh neat, i spelled it right first try
		this.Specialization = pSpecialization;
	}

	public override string ToString() {
		return $"Employee: {this.Name}, Salary: {this.Salary}, Specialization: {this.Specialization}";
	}
}
// }}} Child Classes Manager, Engineer of Employee
