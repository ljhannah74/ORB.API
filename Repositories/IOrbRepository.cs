using System;
using ORB.API.Models;

namespace ORB.API.Repositories;

public interface IOrbRepository
{
    Task<IEnumerable<Orb>> GetAllAsync();
    Task<Orb> GetByIdAsync(int id);
    Task AddOrbAsync(Orb o);
    Task UpdateOrbAsync(Orb o);
    Task DeleteOrbAsync(int id);
}
