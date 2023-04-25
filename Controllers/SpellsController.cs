using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CSharpAPI.Controllers
{
    [ApiController]
    [Route("api/spells")]
    public class SpellsController : ControllerBase
    {

        private readonly SpellsService _spellsService;

        public SpellsController(SpellsService spellsService)
        {
            _spellsService = spellsService;
        }

        [HttpGet]
        public ActionResult<List<Spell>> Get()
        {
            try
            {
                List<Spell> spells = _spellsService.Get();
                return Ok(spells);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{spellId}")]
        public ActionResult<Spell> GetOne(int spellId)
        {
            try
            {
                Spell spell = _spellsService.GetOne(spellId);
                return Ok(spell);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Spell> Create([FromBody] Spell spellData)
        {
            try
            {
                Spell spell = _spellsService.Create(spellData);
                return Ok(spell);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{spellId}")]
        public ActionResult<string> Remove(int spellId)
        {
            try
            {
                string message = _spellsService.Remove(spellId);
                return Ok(message);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}