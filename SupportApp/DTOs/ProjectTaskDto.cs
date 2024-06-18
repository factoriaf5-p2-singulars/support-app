using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SupportApp.Models;

namespace SupportApp.DTOs;

[AutoMap(typeof(Models.ProjectTask),ReverseMap = true)]
public class ProjectTaskDto
{
    public int Id { get; set; }
    public SupportProject Project { get; set; } = null!;
    public SupportTask Task { get; set; } = null!;
    public SupportWorkForce Participant { get; set; } = null!;
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