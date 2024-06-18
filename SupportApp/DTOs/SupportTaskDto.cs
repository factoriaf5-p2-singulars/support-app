using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SupportApp.Models;

namespace SupportApp.DTOs;

[AutoMap(typeof(SupportTask),ReverseMap = true)]
public class SupportTaskDto
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string Name { get; set; } = null!;
    public string Description { get; set; }= null!;
    [Required]
    public bool Enabled
    {
        get;
        set;
    } = true;

}