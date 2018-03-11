using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EntityPractice.Controllers.Resources;
using EntityPractice.Models;
using EntityPractice.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityPractice.Controllers
{
  public class FeaturesController : Controller
  {
    private readonly EPDbContext context;
    private readonly IMapper mapper;
    public FeaturesController(EPDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<FeatureResource>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();
      
      return mapper.Map<List<Feature>, List<FeatureResource>>(features); 
    }
  }
}