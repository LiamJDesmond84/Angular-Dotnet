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
        public async Task<List<SuperHero>>> CreateSuperHero(SuperHero newSuperHero)
        {
            _context.SuperHeroes.Add(newSuperHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());

        }
    }
}
