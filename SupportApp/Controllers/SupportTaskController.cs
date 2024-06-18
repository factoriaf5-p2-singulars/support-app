using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupportApp.DTOs;
using SupportApp.Models;
using SupportApp.Repositories.Interfaces;

namespace SupportApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SupportTaskController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISupportTaskRepository _supportTaskRepository;

        public SupportTaskController(IMapper mapper, ISupportTaskRepository supportTaskRepository)
        {
            _supportTaskRepository = supportTaskRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSupportTask(CreateOrUpdateSupportTaskDto supportTaskDto)
        {
            var supportTask = _mapper.Map<SupportTask>(supportTaskDto);
            await _supportTaskRepository.CreateSupportTask(supportTask);
            return Ok(supportTask);
        }
        
    }
}