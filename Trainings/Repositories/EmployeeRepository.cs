using System;
using System.Data.Entity;
using Trainings.Entities;

namespace Trainings.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private DataBaseContext Context { get; }

		public EmployeeRepository()
		{
			this.Context = new DataBaseContext();
		}
		public void Insert(Employee employee)
		{
			Context.Employees.Add(employee);
		}

		public void Update(Employee employee)
		{
			Context.Entry(employee).State = EntityState.Modified;
		}

		public void Save()
		{
			Context.SaveChanges();
		}

		private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					Context.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
