using System;
using System.Collections.Generic;

namespace Trainings.Entities
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime Birthdate { get; set; }

		public virtual ICollection<EmployeeTraining> EmployeeTrainings { get; set; }
	}
}
