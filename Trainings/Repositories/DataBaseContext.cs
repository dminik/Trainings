using System.Data.Entity;
using Trainings.Entities;

namespace Trainings.Repositories
{
	public class DataBaseContext : DbContext
	{
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder
			  .Entity<Employee>()
			  .MapToStoredProcedures(s =>
				s.Insert(u => u.HasName("InsertEmployee")));

			modelBuilder
			  .Entity<Employee>()
			  .MapToStoredProcedures(s =>
				s.Update(u => u.HasName("UpdateEmployee")));
		}

		public DataBaseContext() : base("DbConnection"){ }

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Training> Trainings { get; set; }
		public DbSet<TrainingVisit> TrainingVisits { get; set; }
		public DbSet<EmployeeTraining> EmployeeTrainings { get; set; }
	}
	
}
