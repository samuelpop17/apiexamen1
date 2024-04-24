using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExamen1.Models;
using WebApiExamen1.Repositories;

namespace WebApiExamen1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private PersonajesRepository repo;

        public PersonajesController(PersonajesRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonajeSeries>>> GetPersonajeSeries()
        {
            return await this.repo.GetPersonajeSeriesAsync();
        }

        [HttpGet("[action]/{serie}")]
        public async Task<ActionResult<List<PersonajeSeries>>> GetPersonajesSeries(string serie)
        {
            return await this.repo.FindPersonajeSeriesAsync(serie);
        }


        [HttpGet("[action]")]
        public async Task<ActionResult<List<string>>> Series()
        {
            return await this.repo.GetSeriesAsync();
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<PersonajeSeries>> PersonajesSeries(int id)
        {
            return await this.repo.FindPersonajeIdAsync(id);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<PersonajeSeries>> InsertPersonaje(PersonajeSeries per)
        {
            await this.repo.InsertarPersonajeSeriesAsync(per);
            return Ok();
        }
        [HttpPut("[action]")]
        public async Task<ActionResult<PersonajeSeries>> UpdatePersonaje(PersonajeSeries per)
        {
            await this.repo.UpdatePersonajeSeriesAsync(per);
            return Ok();
        }
        [HttpDelete("[action]/{id}")]
        public async Task<ActionResult<PersonajeSeries>> DeletePersonaje(int id)
        {
            await this.repo.DeletePersonajeSeriesAsync(id);
            return Ok();
        }
    }
}
