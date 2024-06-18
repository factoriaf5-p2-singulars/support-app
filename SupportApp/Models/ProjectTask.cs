using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SupportApp.DTOs;

namespace SupportApp.Models;

[AutoMap(typeof(DTOs.Create.CreateProjectTaskDto))]
[AutoMap(typeof(DTOs.Update.UpdateProjectTaskDto))]
public class ProjectTask
{
    public int Id { get; set; }
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

    public DateTime? EndDate
    {
        get;
        set;
    } = null;
}