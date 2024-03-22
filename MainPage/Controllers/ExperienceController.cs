using MainPage.Domain.Entities;
using MainPage.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MainPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceRepository _repository;

        public ExperienceController(IExperienceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperience()
        {
            var experiences = await _repository.GetAllAsync();
            if (experiences == null)
            {
                return BadRequest();
            }
            return Ok(experiences);
        }
    }
}
