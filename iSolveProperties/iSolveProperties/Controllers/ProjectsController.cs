using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace iSolveProperties.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;


        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDto>>> GetProjects()
        {
            try { 
            var projects = await _projectService.GetAllProjectsAsync();
            return Ok(projects);
            }
            catch (Exception ex)
        {
                // Log the exception
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
