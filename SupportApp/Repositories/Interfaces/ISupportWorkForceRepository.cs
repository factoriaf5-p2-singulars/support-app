using SupportApp.Models;

namespace SupportApp.Repositories.Interfaces;

public interface ISupportWorkForceRepository
{
    Task<SupportWorkForce> CreateSupportWorkForce(SupportWorkForce supportWorkForce);
    Task RemoveSupportWorkForce(int id);
    // Task<SupportWorkForce> UpdateSupportWorkForce(int id, SupportWorkForce supportWorkForce);
    // Task<List<SupportWorkForce>> GetAllSupportWorkForces();
    // Task<SupportWorkForce> GetOneSupportWorkForce(int id);
}