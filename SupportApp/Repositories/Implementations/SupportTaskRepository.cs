using Microsoft.EntityFrameworkCore;
using SupportApp.Data;
using SupportApp.Models;
using SupportApp.Repositories.Interfaces;

namespace SupportApp.Repositories.Implementations;

public class SupportTaskRepository : ISupportTaskRepository
{
    private readonly ApplicationDbContext _context;
    public SupportTaskRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<SupportTask> CreateSupportTask(SupportTask supportTask)
    {
        _context.Add(supportTask);
        await _context.SaveChangesAsync();
        return supportTask;
    }

    public async Task RemoveSupportTask(int id)
    { 
        await _context.SupportTask.Where(x=>x.Id==id).ExecuteDeleteAsync();
    }

   // public async Task<SupportTask> UpdateSupportTask(int id, SupportTask supportTask)
   //  {
   //      
   //  }
   //
   //  public async Task<List<SupportTask>> GetAllSupportTasks()
   //  {
   //      
   //  }
   //
   //  public async Task<SupportTask> GetOneSupportTask(int id)
   //  {
   //      
   //  }
}