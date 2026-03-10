using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TickTackAPI.Data;
using TickTackAPI.models;

namespace TickTackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimerController : ControllerBase
    {
        private readonly AppDbContext _db;
        public TimerController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet("GetTimer")]
        public async Task< IActionResult> Get()
        {
            var data= await _db.timers.ToListAsync();
            return Ok("sucessfully");
        }
        [HttpPost("update")]
        public async Task<IActionResult> Post(TimerItem d)
        {
         _db.timers.Add(d);
        await _db.SaveChangesAsync();
        return Ok("updated");

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            var timer = await _db.timers.FindAsync(id);
            if (timer == null)
            {
                return NotFound();
            }
            _db.timers.Remove(timer);
            await _db.SaveChangesAsync();
            return Ok(new { message = "Timer deleted successfully" });
        }
    }
}
