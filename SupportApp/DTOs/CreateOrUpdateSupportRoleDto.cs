using System.ComponentModel.DataAnnotations;

namespace SupportApp.DTOs;

public class CreateOrUpdateSupportRoleDto
{
    [StringLength(50)]
    public string Name { get; set; } = null!;
    public string Description { get; set; }= null!;
}