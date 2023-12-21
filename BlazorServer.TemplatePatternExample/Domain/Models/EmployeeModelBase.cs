using System.ComponentModel.DataAnnotations;

namespace BlazorServer.TemplatePatternExample.Domain.Models
{
    public class EmployeeModelBase: ModelBase
    {
        [Required]
        public string? Department { get; set; }
    }
}
