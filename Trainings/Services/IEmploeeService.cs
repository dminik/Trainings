using System.Collections.Generic;

using Trainings.Entities;

namespace Trainings.Services
{
	public interface IEmploeeService
	{
		List<TrainingVisit> GetLatestTrainings(Employee employee);
	}
}