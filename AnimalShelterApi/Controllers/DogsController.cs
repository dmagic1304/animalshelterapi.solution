using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CretaceousApi.Models;

namespace CretaceousApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    /
    [HttpGet]
    public async Task<List<Dog>> Get()
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

     

      return await query.ToListAsync();
    }

    
  }
}