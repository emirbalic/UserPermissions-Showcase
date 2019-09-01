using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemjanApi.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemjanApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        // public async Task<IActionResult> GetUsers()
        // {
        //     var users = await _context.Users.ToListAsync();
        //     return Ok(users);
        // }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users
            .Include(x => x.UserPermissions)
            .ThenInclude(x => x.Permission).ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(user);
        }

        // [HttpPost("AddUser")]
        // public async Task<IActionResult> AddUser (String username)
        // {
             
        // }


        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

    }
}