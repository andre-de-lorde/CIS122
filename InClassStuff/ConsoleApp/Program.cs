// Written by Shatranj
// 1/22/25

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
	public class Program
	{
		
		public static void Main(string[] args)
		{
			

			Student aStudent1 = new Student(8675309, "John", "Boring", "Smith", "Archeology", "Ontology");
			List<Student> aListOfStudents = new List<Student>();

			aListOfStudents.Add(aStudent1);
			aListOfStudents.Add(aStudent1);
			int index = 0;
			foreach(Student aStudent in aListOfStudents) {
				index += 1;
				Console.WriteLine(index + "==============");
				Console.WriteLine(aStudent.ToString());
			}
		}

	}

}
