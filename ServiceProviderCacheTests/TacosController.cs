using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ServiceProviderCacheTests
{
    [Route("tacos")]
    public class TacosController : ControllerBase
    {
        private readonly TestDbContext _context;

        public TacosController(TestDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            var tacos = await _context.Tacos.FindAsync(id);
            return Ok(tacos);
        }
    }
}
