using Microsoft.AspNetCore.Mvc;
using squadAPI2.Model;
using squadAPI2.Repository;

namespace squadAPI2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroEmpresaController : ControllerBase
    {

        private readonly ICadastroEmpresaRepository _repository;

        public CadastroEmpresaController(ICadastroEmpresaRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        
        public async Task<IActionResult> GetAll(){
            var cadastroempresas = await _repository.GetCadastroEmpresas();
            return cadastroempresas.Any() ? Ok(cadastroempresas) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cadastroempresa = await _repository.GetCadastroEmpresaById(id);
            return cadastroempresa != null
            ? Ok(cadastroempresa) : NotFound("Empresa não encontrada.");
        }

        [HttpPost]
        
        public async Task<IActionResult> Post(CadastroEmpresa cadastroempresa){
            _repository.AddCadastroEmpresa(cadastroempresa);
            return await _repository.SaveChangesAsync()
            ? Ok("Empresa adicionada.") : BadRequest("Algo deu errado.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, CadastroEmpresa cadastroempresa)
        {
            var cadastroempresaExiste = await _repository.GetCadastroEmpresaById(id);
            if (cadastroempresaExiste == null) return NotFound("Empresa não encontrada.");

            cadastroempresaExiste.RazaoSocial = cadastroempresa.RazaoSocial ?? cadastroempresaExiste.RazaoSocial;
            cadastroempresaExiste.Cnpj = cadastroempresa.Cnpj ?? cadastroempresaExiste.Cnpj;
            cadastroempresaExiste.Rua = cadastroempresa.Rua ?? cadastroempresaExiste.Rua;
            cadastroempresaExiste.Numero = cadastroempresa.Numero ?? cadastroempresaExiste.Numero;
            cadastroempresaExiste.Bairro = cadastroempresa.Bairro ?? cadastroempresaExiste.Bairro;
            cadastroempresaExiste.Complemento = cadastroempresa.Complemento ?? cadastroempresaExiste.Complemento;
            cadastroempresaExiste.Cep = cadastroempresa.Cep ?? cadastroempresaExiste.Cep;
            cadastroempresaExiste.Cidade = cadastroempresa.Cidade ?? cadastroempresaExiste.Cidade;
            cadastroempresaExiste.Estado = cadastroempresa.Estado ?? cadastroempresaExiste.Estado;
            cadastroempresaExiste.NomeRepresentante = cadastroempresa.NomeRepresentante ?? cadastroempresaExiste.NomeRepresentante;
            cadastroempresaExiste.Email = cadastroempresa.Email ?? cadastroempresaExiste.Email;
            cadastroempresaExiste.Telefone = cadastroempresa.Telefone ?? cadastroempresaExiste.Telefone;
            
            _repository.AtualizarCadastroEmpresa(cadastroempresaExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Empresa atualizada.") : BadRequest("Algo deu errado.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cadastroempresaExiste = await _repository.GetCadastroEmpresaById(id);
            if (cadastroempresaExiste == null)
                return NotFound("Escola não encontrada.");

            _repository.DeletarCadastroEmpresa(cadastroempresaExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Empresa deletada.") : BadRequest("Algo deu errado.");
        }
    }
}