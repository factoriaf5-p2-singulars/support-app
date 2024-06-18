using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupportApp.DTOs;
using SupportApp.Models;
using SupportApp.Repositories.Interfaces;

namespace SupportApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportProjectController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISupportProjectRepository _supportProjectRepository;

        public SupportProjectController(IMapper mapper, ISupportProjectRepository supportProjectRepository)
        {
            _supportProjectRepository = supportProjectRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSupportProject(CreateOrUpdateSupportProjectDto supportProjectDto)
        {
            var supportProject = _mapper.Map<SupportProject>(supportProjectDto);
            await _supportProjectRepository.CreateSupportProject(supportProject);
            return Ok(supportProject);
        }
        
    }
}
