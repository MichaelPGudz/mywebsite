using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace MainPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly HomeService _service;

        public HomeController(HomeService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("experiences")]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperience()
        {
            var experiences = await _service.GetAllExpieriences();
            if (experiences is null)
            {
                return BadRequest();
            }
            return Ok(experiences);
        }

        [HttpGet]
        [Route("skills")]
        public async Task<ActionResult<IEnumerable<Experience>>> GetSkill()
        {
            var skills = await _service.GetAllSkills();
            if (skills is null)
            {
                return BadRequest();
            }
            return Ok(skills);
        }
    }
}
