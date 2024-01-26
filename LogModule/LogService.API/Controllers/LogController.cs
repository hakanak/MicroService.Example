using LogService.API.Dtos;
using LogService.Data.Entities;
using LogService.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LogService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly LogRepository logRepository;
        public LogController(LogRepository logRepository)
        {
            this.logRepository = logRepository;

        }

        [HttpPost]
        public async Task<IActionResult> Create(LogCreateDto dto)
        {

            

            logRepository.CreateLog( new Data.Entities.Log
            {
                ServiceName = dto.service,
                LogType = dto.type, 
                LogException=dto.detail,
                LogDate = dto.date,
            });

            return Created("","");


        }

        [HttpGet]
        public IActionResult Get()
        {


            return Ok();
        }
    }
}
