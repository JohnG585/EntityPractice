using System.Collections.Generic;
using System.Threading.Tasks;
using EntityPractice.Models;
using EntityPractice.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityPractice.Controllers
{
    public class MakesController : Controller
    {
        private readonly EPDbContext context;
        public MakesController(EPDbContext context)
        {
            this.context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}