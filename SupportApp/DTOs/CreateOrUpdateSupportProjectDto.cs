using System.ComponentModel.DataAnnotations;

namespace SupportApp.DTOs;

public class CreateOrUpdateSupportProjectDto
{
    [StringLength(50)]
    public string Name { get; set; } = null!;
    public string Description { get; set; }= null!;
    [Required]
    public DateTime StartDate {
        get;
        set;
    }

    public DateTime? EndDate
    {
        get;
        set;
    } = null;
}