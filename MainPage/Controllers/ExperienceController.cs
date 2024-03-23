using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace MainPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceService _repository;

        public ExperienceController(IExperienceService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperience()
        {
            var experiences = await _repository.GetAllExpieriences();
            if (experiences == null)
            {
                return BadRequest();
            }
            return Ok(experiences);
        }
    }
}
