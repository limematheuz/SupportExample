using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportExample.Data;
using SupportExample.DTOs;
using SupportExample.Models;
using SupportExample.Repositories;

namespace SupportExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;
        public ProjectController(IProjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProjectDto>>> GetAllProjects()
        {
            var projectsList = await _repository.GetAllProjects();
            // var projectsDto = _mapper.Map<List<ProjectDto>>(projectsList);
            return Ok(_mapper.Map<List<ProjectDto>>(projectsList));
        }
} }
