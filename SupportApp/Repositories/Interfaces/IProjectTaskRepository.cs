using SupportApp.Models;

namespace SupportApp.Repositories.Interfaces;

public interface IProjectTaskRepository
{
    Task<ProjectTask> CreateProjectTask(ProjectTask projectTask);
    Task RemoveProjectTask(int id);
    Task<ProjectTask?> UpdateProjectTask(int id, ProjectTask projectTask);
    // Task<List<ProjectTaskController>> GetAllProjectTasks();
    // Task<ProjectTaskController> GetOneProjectTask(int id);
}