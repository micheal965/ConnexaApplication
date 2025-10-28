using Connexa.API.Data;
using Connexa.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Connexa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController(AppDbContext _dbContext) : ControllerBase
    {
        [HttpGet("GetMembers")]
        public async Task<ActionResult<List<ApplicationUser>>> GetMembers()
        {
            return Ok(await _dbContext.ApplicationUsers.ToListAsync());
        }
    }
}
