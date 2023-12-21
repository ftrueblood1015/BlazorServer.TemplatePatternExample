using BlazorServer.TemplatePatternExample.Domain.Models;
using BlazorServer.TemplatePatternExample.Repositories;
using BlazorServer.TemplatePatternExample.Repositories.Managers;
using BlazorServer.TemplatePatternExample.Services.Employees;

namespace BlazorServer.TemplatePatternExample.Services.Managers
{
    public class ManagerService : ServiceBase<Manager, IManagerRepository>, IManagerService
    {
        private readonly IEmployeeService EmployeeService;

        public ManagerService(IRepositoryBase<Manager> repo, IEmployeeService employeeService) : base(repo)
        {
            EmployeeService = employeeService;
        }

        public override bool SafeDelete(Manager entity)
        {

            return EmployeeService.Filter(x => x.ManagerId == entity.Id).Count() == 0;
        }

        public override bool Delete(Manager entity)
        {
            return SafeDelete(entity) ? base.Delete(entity) : false;
        }
    }
}
