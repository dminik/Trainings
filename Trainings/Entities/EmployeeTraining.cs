using System.Collections.Generic;

namespace Trainings.Entities
{
	public class EmployeeTraining
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public int TrainingId { get; set; }

		public virtual ICollection<TrainingVisit> TrainingVisits { get; set; }
	}
}
