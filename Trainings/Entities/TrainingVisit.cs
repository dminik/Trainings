using System;

namespace Trainings.Entities
{
	public class TrainingVisit
	{
		public int Id { get; set; }

		public int EmployeeTrainingId { get; set; }
		public DateTime Date { get; set; }		
	}
}
