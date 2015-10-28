using System;
using System.Collections.Generic;
using System.Linq;

using Trainings.Entities;
using Trainings.Repositories;

namespace Trainings.Services
{
	public class EmploeeService : IEmploeeService
	{
		IEmployeeRepository EmployeeRepository { get; set; }

		public EmploeeService(IEmployeeRepository employeeRepository)
		{
			EmployeeRepository = employeeRepository;
		}

		public void Insert(Employee employee)
		{
			EmployeeRepository.Insert(employee);
			EmployeeRepository.Save();
		}
		
		public List<TrainingVisit> GetLatestTrainings(Employee employee)
		{
			const int recentDays = 10;
			var maxDate = DateTime.Now.AddDays(-recentDays);

			var emploeeTrenings = employee.EmployeeTrainings;
			
			var recentVisits = emploeeTrenings.SelectMany(training => 
				training.TrainingVisits.Where(trainingVisit => trainingVisit.Date > maxDate));

			return recentVisits.ToList();
		}
	}
}
