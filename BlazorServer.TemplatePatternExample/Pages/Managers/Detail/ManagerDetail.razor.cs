using Microsoft.AspNetCore.Components;

namespace BlazorServer.TemplatePatternExample.Pages.Managers.Detail
{
    public partial class ManagerDetail
    {
        [Parameter]
        public int ManagerId { get; set; }
    }
}
