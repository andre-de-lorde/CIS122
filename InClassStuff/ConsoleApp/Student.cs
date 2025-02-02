// Written By Shatranj
// 1/15/25

using System;
using System.Collections.Generic;

namespace ConsoleApp
{
	public class Student {
		private int studentID = -1;
		private string firstName  = "N/A";
		private string middleName = "N/A";
		private string lastName   = "N/A";
		private string major      = "N/A";
		private string minor      = "N/A";
		//private double gpa        = -1.0;

		//{{{ Getters and Setters

		public int StudentID {
			get { return this.studentID; }
			set { this.studentID = value; }
		}

		public string FirstName {
			get { return this.firstName; }
			set { this.firstName = value; }
		}
		public string LastName {
			get { return this.lastName; }
			set { this.lastName = value; }
		} 
		public string MiddleName {
			get { return this.middleName; }
			set { this.middleName = value; }
		}
		public string Major {
			get { return this.major; }
			set { this.major = value; }
		}
		public string Minor {
			get { return this.minor; }
			set { this.minor = value; }
		}
		//}}} Getters and Setters
		
		public override string ToString()
		{
			string message = "";
			message += "Student ID: " + this.StudentID + "\n";
			message += "Name: " + this.firstName + " " + this.middleName + " " + this.lastName + "\n";
			message += "Major: " + this.Major + "\n";
			message += "Minor: " + this.Minor;
			return message;
		}

		// {{{ Constructor

		public Student(int aStudentID, string aFirstName, string aMiddleName, string aLastName, string aMajor, string aMinor) {
			this.StudentID = aStudentID;
			this.FirstName = aFirstName;
			this.MiddleName = aMiddleName;
			this.LastName = aLastName;
			this.Major = aMajor;
			this.Minor = aMinor;
		}

		// }}} Constructor


	}
}
