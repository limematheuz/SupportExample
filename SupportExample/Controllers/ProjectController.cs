using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportExample.Data;
using SupportExample.Models;
using SupportExample.Repositories;

namespace SupportExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _repository;
        public ProjectController(IProjectRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            var projectsList = await _repository.GetAllProjects();
            return Ok(projectsList);
        }
    }
}
