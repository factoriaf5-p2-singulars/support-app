using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupportApp.DTOs;
using SupportApp.Models;
using SupportApp.Repositories.Interfaces;

namespace SupportApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportWorkForceController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISupportWorkForceRepository _supportWorkForceRepository;

        public SupportWorkForceController(IMapper mapper, ISupportWorkForceRepository supportWorkForceRepository)
        {
            _supportWorkForceRepository = supportWorkForceRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSupportWorkForce(CreateOrUpdateSupportWorkForceDto supportWorkForceDto)
        {
            var supportWorkForce = _mapper.Map<SupportWorkForce>(supportWorkForceDto);
            await _supportWorkForceRepository.CreateSupportWorkForce(supportWorkForce);
            return Ok(supportWorkForce);
        }
        
    }
}