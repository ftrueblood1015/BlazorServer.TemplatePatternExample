using System.ComponentModel.DataAnnotations;

namespace BlazorServer.TemplatePatternExample.Domain.Models
{
    public class ModelBase
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public bool? IsActive { get; set; }

        public string? Description { get; set; }
    }
}
