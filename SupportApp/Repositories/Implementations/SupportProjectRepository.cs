using Microsoft.EntityFrameworkCore;
using SupportApp.Data;
using SupportApp.Models;
using SupportApp.Repositories.Interfaces;

namespace SupportApp.Repositories.Implementations;

public class SupportProjectRepository : ISupportProjectRepository
{
    private readonly ApplicationDbContext _context;
    public SupportProjectRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<SupportProject> CreateSupportProject(SupportProject supportProject)
    {
        _context.Add(supportProject);
        await _context.SaveChangesAsync();
        return supportProject;
    }

    public async Task RemoveSupportProject(int id)
    { 
        await _context.SupportProject.Where(x=>x.Id==id).ExecuteDeleteAsync();
    }

   // public async Task<SupportProject> UpdateSupportProject(int id, SupportProject supportProject)
   //  {
   //      
   //  }
   //
   //  public async Task<List<SupportProject>> GetAllSupportProjects()
   //  {
   //      
   //  }
   //
   //  public async Task<SupportProject> GetOneSupportProject(int id)
   //  {
   //      
   //  }
}