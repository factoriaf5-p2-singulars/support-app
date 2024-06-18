using System.ComponentModel.DataAnnotations;

namespace SupportApp.DTOs.Create;

public class CreateProjectTaskDto
{
  
    public int SupportProjectId { get; set; }
    public int SupportTaskId { get; set; }
    public int SupportWorkForceId { get; set; }
    [Required]
    public string State { get; set; } = "On Progress";
    [Required]
    public DateTime StartDate {
        get;
        set;
    }
    public DateTime EndDate {
        get;
        set;
    }
}