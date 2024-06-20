using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportExample.Models;

namespace SupportExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            return Ok();
        }
    }
}
