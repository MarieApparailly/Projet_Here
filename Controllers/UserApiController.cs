using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_Here.Data;
using Projet_Here.Models;

namespace Projet_Here.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserApiController : ControllerBase
{
    private readonly HereContext _context;

    public UserApiController(HereContext context)
    {
        _context = context;
    }

    // GET: api/UserApi
    // public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    // {
    //     return await _context.Users.ToListAsync();
    // }

    // GET: api/UserApi
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        // Get users
        var users = _context.Users
            .OrderBy(s => s.LastName)
            .ThenBy(s => s.FirstName)
            .Include(s => s.Missions);

        return await users.ToListAsync();
    }

    // // GET: api/userApi/5
    // [HttpGet("{id}")]
    // public async Task<ActionResult<User>> GetUser(int id)
    // {
    //     // Find user and related enrollments
    //     // SingleAsync() throws an exception if no user is found (which is possible, depending on id)
    //     // SingleOrDefaultAsync() is a safer choice here
    //     var user = await _context.Users
    //         .Where(s => s.Id == id)
    //         .Include(s => s.Missions)
    //         .SingleOrDefaultAsync();

    //     if (user == null)
    //         return NotFound();

    //     return user;
    // }

    // // POST: api/UserApi
    // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // [HttpPost]
    // public async Task<ActionResult<User>> PostUser(User user)
    // {
    //     _context.Users.Add(user);
    //     await _context.SaveChangesAsync();

    //     return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
    // }

    // // DELETE: api/UserApi/5
    // [HttpDelete("{id}")]
    // public async Task<IActionResult> DeleteUser(int id)
    // {
    //     var user = await _context.Users.FindAsync(id);
    //     if (user == null)
    //         return NotFound();

    //     _context.Users.Remove(user);
    //     await _context.SaveChangesAsync();

    //     return NoContent();
    // }
}
