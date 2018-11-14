using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces.Gateways.Repositories;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayersController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        // GET api/players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> Get()
        {
            return await _playerRepository.ListAll();
        }

        // GET api/players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> Get(int id)
        {
            return await _playerRepository.GetById(id);
        }
    }
}
