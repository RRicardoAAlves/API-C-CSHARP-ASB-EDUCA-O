using squadAPI2.Database;
using squadAPI2.Model;
using Microsoft.EntityFrameworkCore;

namespace squadAPI2.Repository
{
    public class CadastroEscolaRepository : ICadastroEscolaRepository
    {
        private readonly ConfigDbContext _context;

        public CadastroEscolaRepository(ConfigDbContext context)
        {
            _context = context;
        }

        public void AddCadastroEscola(CadastroEscola cadastroescola)
        {
            _context.Add(cadastroescola);
        }

        public void AtualizarCadastroEscola(CadastroEscola cadastroescola)
        {
            _context.Update(cadastroescola);
        }

        public void DeletarCadastroEscola(CadastroEscola cadastroescola)
        {
            _context.Remove(cadastroescola);
        }

        public async Task<CadastroEscola> GetCadastroEscolaById(int id)
        {
            return await _context.CadastroEscolas
            .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CadastroEscola>> GetCadastroEscolas()
        {
            return await _context.CadastroEscolas.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}