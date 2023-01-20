using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public CatsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    
    [HttpGet]
    public async Task<List<Cat>> Get(string name, string breed, int age)
    {
      IQueryable<Cat> query = _db.Cats.AsQueryable();

       if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (age > 0)
      {
        query = query.Where(entry => entry.Age >= age);
      }

      return await query.ToListAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
      Cat cat = await _db.Cats.FindAsync(id);

      if (cat == null)
      {
        return NotFound();
      }

      return cat;
    }


    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat cat)
    {
      _db.Cats.Add(cat);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Cat cat)
    {
      if (id != cat.CatId)
      {
        return BadRequest();
      }

      _db.Cats.Update(cat);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CatExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool CatExists(int id)
    {
      return _db.Cats.Any(e => e.CatId == id);
    }  

    [HttpDelete("{id}")]
    public async Task<IActionResult> Cat(int id)
    {
      Cat cat = await _db.Cats.FindAsync(id);
      
    }

    
  }
}