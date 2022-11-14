using squadAPI2.Database;
using squadAPI2.Model;
using Microsoft.EntityFrameworkCore;

namespace squadAPI2.Repository
{
    public class CadastroEmpresaRepository : ICadastroEmpresaRepository
    {
        private readonly ConfigDbContext _context;

        public CadastroEmpresaRepository(ConfigDbContext context)
        {
            _context = context;
        }

        public void AddCadastroEmpresa(CadastroEmpresa cadastroempresa)
        {
            _context.Add(cadastroempresa);
        }

        public void AtualizarCadastroEmpresa(CadastroEmpresa cadastroempresa)
        {
            _context.Update(cadastroempresa);
        }

        public void DeletarCadastroEmpresa(CadastroEmpresa cadastroempresa)
        {
            _context.Remove(cadastroempresa);
        }

        public async Task<CadastroEmpresa> GetCadastroEmpresaById(int id)
        {
            return await _context.CadastroEmpresas
            .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CadastroEmpresa>> GetCadastroEmpresas()
        {
            return await _context.CadastroEmpresas.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}