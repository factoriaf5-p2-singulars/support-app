using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SupportApp.Models;

namespace SupportApp.DTOs;

[AutoMap(typeof(SupportProject),ReverseMap = true)]
public class SupportProjectDto
{
    public int Id { get; set; }
    
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