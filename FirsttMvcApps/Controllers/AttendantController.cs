using FirsttMvcApps.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirsttMvcApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendantController : ControllerBase
    {
        // GET: api/<AttendantController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Attendance.GetAttendants());
        }
        
        // POST api/<AttendantController>
        [HttpPost]
        public ActionResult<Person> Post([FromBody] Person person)
        {
            Attendance.AddAttendant(person);
            return CreatedAtAction(nameof(Get), new { id = person.Id }, person);

        }
        [HttpOptions]
        public IActionResult Options()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", new[] { (string)Request.Headers["Origin"] });

            Response.Headers.Add("Access-Control-Allow-Headers", new[] { "Origin, X-Requested-With, Content-Type, Accept" });

            Response.Headers.Add("Access-Control-Allow-Methods", new[] { "GET, POST, PUT, DELETE, OPTIONS" });

            Response.Headers.Add("Access-Control-Allow-Credentials", new[] { "true" });


            return NoContent();

        }

        
    }
}
