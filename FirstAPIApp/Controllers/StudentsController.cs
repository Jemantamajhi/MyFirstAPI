using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[]Students=new string[] { "Jemanta","Ashish","Darwin","Tapas","Syjit","Nc"};
            return Ok(Students);
        }
    }
}
