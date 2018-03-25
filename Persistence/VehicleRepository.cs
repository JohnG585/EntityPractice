using System.Threading.Tasks;
using EntityPractice.Models;
using Microsoft.EntityFrameworkCore;
using EntityPractice.Core;

namespace EntityPractice.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly EPDbContext context;
        public VehicleRepository(EPDbContext context)
        {
            this.context = context;

        }
        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            if (!includeRelated)
                return await context.Vehicles.FindAsync();

            return await context.Vehicles
            .Include(v => v.Features)
            .ThenInclude(vf => vf.Feature)
            .Include(v => v.Model)
            .ThenInclude(m => m.Make)
            .SingleOrDefaultAsync(v => v.Id == id);
        }

        public void Add(Vehicle vehicle) 
        {
            context.Vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle) 
        {
            context.Remove(vehicle);
        }
    }
}