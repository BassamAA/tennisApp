using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class EntrepriseController : BaseApiController
        {
            private readonly DataContext _context;

            public EntrepriseController(DataContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<AppEntreprise>>> GetEntreprises()
            {
                var entreprises = await _context.Entreprises.ToListAsync();

                return entreprises;
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<AppEntreprise>> GetEntreprise(int id)
            {
                return await _context.Entreprises.FindAsync(id);

            }
        }
}