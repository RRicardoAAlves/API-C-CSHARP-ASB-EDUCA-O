using Microsoft.AspNetCore.Mvc;
using squadAPI2.Model;
using squadAPI2.Repository;

namespace squadAPI2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemandaEscolaController : ControllerBase
    {

        private readonly IDemandaEscolaRepository _repository;

        public DemandaEscolaController(IDemandaEscolaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var demandaescolas = await _repository.GetDemandaEscolas();
            return demandaescolas.Any() ? Ok(demandaescolas) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var demandaescola = await _repository.GetDemandaEscolaById(id);
            return demandaescola != null
            ? Ok(demandaescola) : NotFound("Demanda da escola não encontrada.");
        }

        [HttpPost]

        public async Task<IActionResult> Post(DemandaEscola demandaescola)
        {
            _repository.AddDemandaEscola(demandaescola);
            return await _repository.SaveChangesAsync()
            ? Ok("Demanda da escola adicionada.") : BadRequest("Algo deu errado.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, DemandaEscola demandaescola)
        {
            var demandaescolaExiste = await _repository.GetDemandaEscolaById(id);
            if (demandaescolaExiste == null) return NotFound("Demanda da escola não encontrada.");

            demandaescolaExiste.Demanda = demandaescola.Demanda ?? demandaescolaExiste.Demanda;
            demandaescolaExiste.DescricaoDemanda = demandaescola.DescricaoDemanda ?? demandaescolaExiste.DescricaoDemanda;
            demandaescolaExiste.DataDemanda = demandaescola.DataDemanda != new DateTime()
           ? demandaescola.DataDemanda : demandaescolaExiste.DataDemanda;

            _repository.AtualizarDemandaEscola(demandaescolaExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Demanda da escola atualizada.") : BadRequest("Algo deu errado.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var demandaescolaExiste = await _repository.GetDemandaEscolaById(id);
            if (demandaescolaExiste == null)
                return NotFound("Demanda da escola não encontrada.");

            _repository.DeletarDemandaEscola(demandaescolaExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Demanda da escola deletada.") : BadRequest("Algo deu errado.");
        }
    }
}