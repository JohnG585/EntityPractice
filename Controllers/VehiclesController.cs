using System;
using System.Threading.Tasks;
using AutoMapper;
using EntityPractice.Controllers.Resources;
using EntityPractice.Models;
using EntityPractice.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace EntityPractice.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        private readonly EPDbContext context;
        public VehiclesController(IMapper mapper, EPDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdate = DateTime.Now;

            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();
            
            var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }
    }
}