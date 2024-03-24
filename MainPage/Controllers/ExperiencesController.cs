using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace MainPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        private readonly IExperienceService _repository;

        public ExperiencesController(IExperienceService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("~/api/experiences")]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperience()
        {
            var experiences = await _repository.GetAllExpieriences();
            if (experiences is null)
            {
                return BadRequest();
            }
            return Ok(experiences);
        }

        [HttpGet]
        [Route("~/api/skills")]
        public async Task<ActionResult<IEnumerable<Experience>>> GetSkill()
        {
            var skills = await _repository.GetAllSkills();
            if (skills is null)
            {
                return BadRequest();
            }
            return Ok(skills);
        }
    }
}
