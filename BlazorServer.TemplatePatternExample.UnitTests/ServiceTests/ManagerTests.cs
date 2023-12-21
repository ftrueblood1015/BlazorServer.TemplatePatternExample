using BlazorServer.TemplatePatternExample.Domain.Models;
using BlazorServer.TemplatePatternExample.Repositories.Employees;
using BlazorServer.TemplatePatternExample.Repositories.Managers;
using BlazorServer.TemplatePatternExample.Services.Employees;
using BlazorServer.TemplatePatternExample.Services.Managers;
using BlazorServer.TemplatePatternExample.UnitTests.MockBases;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorServer.TemplatePatternExample.UnitTests.ServiceTests
{
    public class ManagerTests
    {

        private readonly EmployeeService EmployeeService;
        private readonly ManagerService ManagerService;

        public ManagerTests()
        {
            var EmployeeRepo = MockRepoBase.MockRepo<IEmployeeRepository, Employee>(new List<Employee>()
                {
                    new Employee { Id = 1, Department = "IT", Description = "IT Employee", IsActive = true, ManagerId = 1, Name = "Bob" },
                    new Employee { Id = 2, Department = "IT", Description = "IT Employee", IsActive = true, ManagerId = 1, Name = "Thorton" }
                }    
            );

            var ManagerRepo = MockRepoBase.MockRepo<IManagerRepository, Manager>(new List<Manager>()
                {
                    new Manager { Id = 1, Department = "IT", Description = "IT Manager", IsActive = true, Name = "Billy"}
                }
            );

            EmployeeService = new EmployeeService(EmployeeRepo.Object);
            ManagerService = new ManagerService(ManagerRepo.Object, EmployeeService);
        }

        [Test]
        public void Can_Not_Delete_Manager_With_Employees()
        {
            // Arrange
            Manager manager = ManagerService.GetById(1)!;

            // Act
            var result = ManagerService.Delete(manager);

            // Assert
            result.ShouldBeFalse();
        }

        [Test]
        public void Can_Delete_Manager_With_NO_Employees()
        {
            // Arrange
            Manager NewManager = new Manager() { Department = "Accounting", Description = "Accounting Manager", IsActive = true, Name = "Test" };
            Manager Manager = ManagerService.Add(NewManager);
            var Id = Manager.Id;
            var delete = ManagerService.Delete(Manager);

            // Assert
            ManagerService.Filter(x => x.Id == Id).Count().ShouldBe(0);
        }
    }
}
