using BlazorServer.TemplatePatternExample.Domain.Models;
using BlazorServer.TemplatePatternExample.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.TemplatePatternExample.Repositories.Employees
{
    public class EmployeeRepository : RepositoryBase<Employee, TemplatePatternContext>, IEmployeeRepository
    {
        public EmployeeRepository(TemplatePatternContext context) : base(context)
        {
        }

        public override IEnumerable<Employee> GetAll()
        {
            return Context.Set<Employee>().Include(m => m.Manager);
        }
    }
}
