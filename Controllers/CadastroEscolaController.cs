using Microsoft.AspNetCore.Mvc;
using squadAPI2.Model;
using squadAPI2.Repository;

namespace squadAPI2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroEscolaController : ControllerBase
    {

        private readonly ICadastroEscolaRepository _repository;

        public CadastroEscolaController(ICadastroEscolaRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        
        public async Task<IActionResult> GetAll(){
            var cadastroescolas = await _repository.GetCadastroEscolas();
            return cadastroescolas.Any() ? Ok(cadastroescolas) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cadastroescola = await _repository.GetCadastroEscolaById(id);
            return cadastroescola != null
            ? Ok(cadastroescola) : NotFound("Escola não encontrada.");
        }

        [HttpPost]
        
        public async Task<IActionResult> Post(CadastroEscola cadastroescola){
            _repository.AddCadastroEscola(cadastroescola);
            return await _repository.SaveChangesAsync()
            ? Ok("Escola adicionada.") : BadRequest("Algo deu errado.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, CadastroEscola cadastroescola)
        {
            var cadastroescolaExiste = await _repository.GetCadastroEscolaById(id);
            if (cadastroescolaExiste == null) return NotFound("Escola não encontrada.");

            cadastroescolaExiste.RazaoSocial = cadastroescola.RazaoSocial ?? cadastroescolaExiste.RazaoSocial;
            cadastroescolaExiste.Cnpj = cadastroescola.Cnpj ?? cadastroescolaExiste.Cnpj;
            cadastroescolaExiste.Rua = cadastroescola.Rua ?? cadastroescolaExiste.Rua;
            cadastroescolaExiste.Numero = cadastroescola.Numero ?? cadastroescolaExiste.Numero;
            cadastroescolaExiste.Bairro = cadastroescola.Bairro ?? cadastroescolaExiste.Bairro;
            cadastroescolaExiste.Complemento = cadastroescola.Complemento ?? cadastroescolaExiste.Complemento;
            cadastroescolaExiste.Cep = cadastroescola.Cep ?? cadastroescolaExiste.Cep;
            cadastroescolaExiste.Cidade = cadastroescola.Cidade ?? cadastroescolaExiste.Cidade;
            cadastroescolaExiste.Estado = cadastroescola.Estado ?? cadastroescolaExiste.Estado;
            cadastroescolaExiste.NomeRepresentante = cadastroescola.NomeRepresentante ?? cadastroescolaExiste.NomeRepresentante;
            cadastroescolaExiste.Email = cadastroescola.Email ?? cadastroescolaExiste.Email;
            cadastroescolaExiste.Telefone = cadastroescola.Telefone ?? cadastroescolaExiste.Telefone;
            
            _repository.AtualizarCadastroEscola(cadastroescolaExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Escola atualizada.") : BadRequest("Algo deu errado.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cadastroescolaExiste = await _repository.GetCadastroEscolaById(id);
            if (cadastroescolaExiste == null)
                return NotFound("Escola não encontrada.");

            _repository.DeletarCadastroEscola(cadastroescolaExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Escola deletada.") : BadRequest("Algo deu errado.");
        }
    }
}