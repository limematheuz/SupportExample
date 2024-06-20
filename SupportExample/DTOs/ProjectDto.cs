using System.ComponentModel.DataAnnotations;

namespace SupportExample.DTOs;

public class ProjectDto
{
    public int Id {get; set;}  
    [Required, StringLength(50)]
    public string Name {get; set;} 
    [Required, StringLength(400)]
    public string Description {get; set;} 
    public DateTime StartDate {get; set;}
    public DateTime? EndDate { get; set; } = null;
}