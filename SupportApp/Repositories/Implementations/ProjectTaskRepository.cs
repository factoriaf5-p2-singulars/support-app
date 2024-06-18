using Microsoft.EntityFrameworkCore;
using SupportApp.Data;
using SupportApp.Models;
using SupportApp.Repositories.Interfaces;

namespace SupportApp.Repositories.Implementations;

public class ProjectTaskRepository : IProjectTaskRepository
{
    private readonly ApplicationDbContext _context;
    public ProjectTaskRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<ProjectTask> CreateProjectTask(ProjectTask projectTask)
    {
        _context.Add(projectTask);
        await _context.SaveChangesAsync();
        return projectTask;
    }

    public async Task RemoveProjectTask(int id)
    {
        await _context.ProjectTask.Where(x => x.Id == id).ExecuteDeleteAsync();
    }

    public async Task<ProjectTask?> UpdateProjectTask(int id, ProjectTask updateProjectTask)
    {
        var projectTask = await _context.ProjectTask.FindAsync(id);

        if (projectTask == null)
        {
            return null;
        }

        projectTask.State = updateProjectTask.State;
        if(updateProjectTask.State == "Done"){

            projectTask.EndDate = DateTime.Now; 
        }

        await _context.SaveChangesAsync();

        return projectTask;

    }
    //
    //  public async Task<List<ProjectTaskController>> GetAllProjectTasks()
    //  {
    //
    //  }
    //
    //  public async Task<ProjectTaskController> GetOneProjectTask(int id)
    //  {
    //
    //  }
}