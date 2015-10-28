using System;

using Trainings.Entities;

namespace Trainings.Repositories
{
	public interface IEmployeeRepository : IDisposable
	{
		void Insert(Employee employee);

		void Update(Employee employee);

		void Save();
	}
}
