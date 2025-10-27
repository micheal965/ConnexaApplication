using Connexa.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Connexa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController(AppDbContext _dbContext) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetMembers()
        {
            return Ok(_dbContext.ApplicationUsers.ToListAsync());
        }
    }
}
