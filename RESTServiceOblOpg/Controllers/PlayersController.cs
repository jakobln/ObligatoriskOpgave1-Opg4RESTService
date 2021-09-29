using Microsoft.AspNetCore.Mvc;
using RESTServiceOblOpg.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestsOblOpg;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTServiceOblOpg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly PlayersManager _manager = new PlayersManager();

        // GET: api/<PlayersController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<PlayersController>
        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
