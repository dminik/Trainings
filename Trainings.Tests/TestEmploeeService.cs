using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

using Trainings.Entities;
using Trainings.Services;

namespace Trainings.Tests
{
	[TestFixture]
	public class TestEmploeeService
	{
		[Test]
		public void Test_GetLatestTrainings_Have2EmploeesAndOneHasResentDate_FoundOneEmploee()
		{
			// Arrange 
			var testEmploee = new Employee
			{
				EmployeeTrainings = new List<EmployeeTraining>()
				{
					new EmployeeTraining()
					{
						TrainingVisits = new List<TrainingVisit>()
						{
							new TrainingVisit
							{
								Date = DateTime.Now.AddDays(-3),
							}
						}
					},

					new EmployeeTraining()
					{
						TrainingVisits = new List<TrainingVisit>()
						{
							new TrainingVisit
							{
								Date = DateTime.Now.AddDays(-20),
							}
						}
					},
				}
			};

			var serviceUnderTest = new EmploeeService(null);


			// Act 
			var actualVisits = serviceUnderTest.GetLatestTrainings(testEmploee);

			// Assert
			Assert.AreEqual(1, actualVisits.Count);

			const int recentDays = 10;
			var maxDate = DateTime.Now.AddDays(-recentDays);
			Assert.True(actualVisits.First().Date > maxDate);
		}
	}
}
