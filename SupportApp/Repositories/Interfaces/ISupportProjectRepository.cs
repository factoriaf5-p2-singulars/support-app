using SupportApp.Models;

namespace SupportApp.Repositories.Interfaces;

public interface ISupportProjectRepository
{
    Task<SupportProject> CreateSupportProject(SupportProject supportProject);
    Task RemoveSupportProject(int id);
    // Task<SupportProject> UpdateSupportProject(int id, SupportProject supportProject);
    // Task<List<SupportProject>> GetAllSupportProjects();
    // Task<SupportProject> GetOneSupportProject(int id);
}