using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupportApp.DTOs.Update;
using SupportApp.Repositories.Interfaces;
using ProjectTask = SupportApp.DTOs.Create.CreateProjectTaskDto;

namespace SupportApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTaskController(IMapper mapper, IProjectTaskRepository projectTaskRepository)
        : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateProjectTask(ProjectTask projectTaskDto)
        {
            var projectTask = mapper.Map<Models.ProjectTask>(projectTaskDto);
            await projectTaskRepository.CreateProjectTask(projectTask);
            return Ok(projectTask);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProjectTask(int id, UpdateProjectTaskDto projectTaskDto)
        {
            var projectTask = mapper.Map<Models.ProjectTask>(projectTaskDto);
            var result = await projectTaskRepository.UpdateProjectTask(id, projectTask);
            return Ok(result);
        }

    }

}
