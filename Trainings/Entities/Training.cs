using System.Collections.Generic;

namespace Trainings.Entities
{
	public class Training
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public virtual ICollection<EmployeeTraining> EmployeeTrainings { get; set; }
	}
}
