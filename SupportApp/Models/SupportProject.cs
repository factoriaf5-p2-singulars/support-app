using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using AutoMapper;
using SupportApp.DTOs;

namespace SupportApp.Models;

[AutoMap(typeof(CreateOrUpdateSupportProjectDto))]
public class SupportProject
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;
    [StringLength(400)]
    public string Description { get; set; }= null!;
    [Required]
    public DateTime StartDate {
        get;
        set;
    }

    
    public DateTime EndDate
    {
        get;
        set;
    }
    public ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();
}