using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EntityPractice.Controllers.Resources;
using EntityPractice.Models;
using EntityPractice.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityPractice.Core;

namespace EntityPractice.Controllers
{
    public class MakesController : Controller
    {
        private readonly EPDbContext context;
        private readonly IMapper mapper;
        public MakesController(EPDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}