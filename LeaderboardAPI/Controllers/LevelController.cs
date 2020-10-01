using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaderboardAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LeaderboardAPI.Models;

namespace LeaderboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelRepository _levelRepository;

        public LevelController(ILevelRepository levelRepository)
        {
            _levelRepository = levelRepository;
        }

        [HttpGet]
        public IActionResult GetLevels()
        {
            return Ok(_levelRepository.GetLevels());
        }

        [HttpPost]
        public IActionResult PostLevel([FromBody] Level level)
        {
            _levelRepository.AddLevel(level);
            return Ok();
        }
    }
}
