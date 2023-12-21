using Microsoft.AspNetCore.Components;

namespace BlazorServer.TemplatePatternExample.Pages.Employees.Detail
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }
    }
}
