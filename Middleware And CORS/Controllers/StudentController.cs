using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Middleware_And_CORS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudent()
        {
            var students = new[]
           {
                new
                {
                    Id = 1,
                    Name = "Sahdev",
                    Marks = 85
                },
                new
                {
                    Id = 2,
                    Name = "Rohit",
                    Marks = 78
                },
                new
                {
                    Id = 3,
                    Name = "Akash",
                    Marks = 90
                }
            };

            return Ok(students);
        }
    }
}
