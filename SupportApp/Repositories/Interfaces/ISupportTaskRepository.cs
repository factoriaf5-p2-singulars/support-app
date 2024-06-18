using SupportApp.Models;

namespace SupportApp.Repositories.Interfaces;

public interface ISupportTaskRepository
{
    Task<SupportTask> CreateSupportTask(SupportTask supportTask);
    Task RemoveSupportTask(int id);
    // Task<SupportTask> UpdateSupportTask(int id, SupportTask supportTask);
    // Task<List<SupportTask>> GetAllSupportTasks();
    // Task<SupportTask> GetOneSupportTask(int id);
}