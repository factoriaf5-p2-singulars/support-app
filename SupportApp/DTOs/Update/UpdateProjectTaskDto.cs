using System.ComponentModel.DataAnnotations;

namespace SupportApp.DTOs.Update;

public class UpdateProjectTaskDto
{
    public string State { get; set; } = "On Progress";
    public DateTime? EndDate { get; set; }
}