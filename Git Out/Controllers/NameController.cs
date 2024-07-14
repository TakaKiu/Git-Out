using Microsoft.AspNetCore.Mvc;

namespace NameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "Your Name" });
        }
    }
}
