using BlazorServer.TemplatePatternExample.Domain.Models;
using BlazorServer.TemplatePatternExample.Infrastructure;

namespace BlazorServer.TemplatePatternExample.Repositories.Managers
{
    public class ManagerRepository : RepositoryBase<Manager, TemplatePatternContext>, IManagerRepository
    {
        public ManagerRepository(TemplatePatternContext context) : base(context)
        {
        }
    }
}
