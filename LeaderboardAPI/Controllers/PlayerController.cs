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
    public class PlayerController : ControllerBase
    {
        private IPlayerRepository _playerRepository;

        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpGet]
        public IActionResult GetPlayers() =>
            Ok(_playerRepository.GetPlayers());

        [HttpPost]
        public IActionResult AddPlayer([FromBody] Player newPlayer)
        {
            if (!TryValidateModel(newPlayer))
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _playerRepository.AddPlayer(newPlayer);
            return Created(Request.Path + newPlayer.Id.ToString(), newPlayer);
        }
    }
}
