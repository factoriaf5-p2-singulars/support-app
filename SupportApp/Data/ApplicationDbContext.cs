
using Microsoft.EntityFrameworkCore;
using SupportApp.Models;

namespace SupportApp.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public  DbSet<SupportProject> SupportProject { get; set; }
    public  DbSet<SupportTask> SupportTask { get; set; }
    public  DbSet<SupportWorkForce> SupportWorkForce { get; set; }
    public  DbSet<ProjectTask> ProjectTask { get; set; }
   
}