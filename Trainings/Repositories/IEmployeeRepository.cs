using Trainings.Entities;

namespace Trainings.Repositories
{
	public interface IEmployeeRepository
	{		
		bool Insert(Employee employee);

		bool Update(Employee employee);	
	}
}
