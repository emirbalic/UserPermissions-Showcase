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
    public class PermissionsController : ControllerBase
    {
        private readonly DataContext _context;
        public PermissionsController(DataContext context)
        {
            _context = context;
        }

        // GET api/permissions
        [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        public async Task<IActionResult> GetPermissions()
        {
            var permissions =  await _context.Permissions.ToListAsync();
            return Ok(permissions);
        }

        // GET api/permissions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPermission(int id)
        {
            var permission = await _context.Permissions.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(permission);
            

        }

        // POST api/permissions
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/permissions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/permissions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}