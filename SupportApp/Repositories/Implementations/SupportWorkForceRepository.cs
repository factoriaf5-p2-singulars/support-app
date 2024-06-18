using Microsoft.EntityFrameworkCore;
using SupportApp.Data;
using SupportApp.Models;
using SupportApp.Repositories.Interfaces;

namespace SupportApp.Repositories.Implementations;

public class SupportWorkForceRepository : ISupportWorkForceRepository
{
    private readonly ApplicationDbContext _context;
    public SupportWorkForceRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<SupportWorkForce> CreateSupportWorkForce(SupportWorkForce supportWorkForce)
    {
        _context.Add(supportWorkForce);
        await _context.SaveChangesAsync();
        return supportWorkForce;
    }

    public async Task RemoveSupportWorkForce(int id)
    { 
        await _context.SupportWorkForce.Where(x=>x.Id==id).ExecuteDeleteAsync();
    }

   // public async Task<SupportWorkForce> UpdateSupportWorkForce(int id, SupportWorkForce supportWorkForce)
   //  {
   //      
   //  }
   //
   //  public async Task<List<SupportWorkForce>> GetAllSupportWorkForces()
   //  {
   //      
   //  }
   //
   //  public async Task<SupportWorkForce> GetOneSupportWorkForce(int id)
   //  {
   //      
   //  }
}