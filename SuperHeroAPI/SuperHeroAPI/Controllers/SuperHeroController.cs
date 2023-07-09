using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> getSuperHeroes()
        {

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> CreateSuperHero(SuperHero newSuperHero)
        {
            _context.SuperHeroes.Add(newSuperHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateSuperHero(SuperHero superHero)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(superHero.Id);

            if(dbHero == null)
            {
                return BadRequest("Hero Not Found");
            }
            else
            {
                dbHero.Name = superHero.Name;
                dbHero.FirstName = superHero.FirstName;
                dbHero.LastName = superHero.LastName;
                dbHero.Place = superHero.Place;

                await _context.SaveChangesAsync();
                return Ok(await _context.SuperHeroes.ToListAsync());
            }

        }
    }
}
