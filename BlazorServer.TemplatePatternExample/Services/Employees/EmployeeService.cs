using BlazorServer.TemplatePatternExample.Domain.Models;
using BlazorServer.TemplatePatternExample.Repositories;
using BlazorServer.TemplatePatternExample.Repositories.Employees;

namespace BlazorServer.TemplatePatternExample.Services.Employees
{
    public class EmployeeService : ServiceBase<Employee, IEmployeeRepository>, IEmployeeService
    {
        public EmployeeService(IRepositoryBase<Employee> repo) : base(repo)
        {
        }
    }
}
