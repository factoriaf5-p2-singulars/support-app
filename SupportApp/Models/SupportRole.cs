using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SupportApp.DTOs;

namespace SupportApp.Models;

[AutoMap(typeof(CreateOrUpdateSupportRoleDto))]
public class SupportRole
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string Name { get; set; } = null!;
    [StringLength(400)]
    public string Description { get; set; }= null!;

    [Required]
    public bool Enabled
    {
        get;
        set;
    } = true;

}