using System.ComponentModel.DataAnnotations;

namespace BlazorServer.TemplatePatternExample.Domain.Models
{
    public class Employee : EmployeeModelBase
    {
        [Required]
        public int? ManagerId { get; set; }

        public Manager? Manager { get; set; }
    }
}
