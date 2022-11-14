using squadAPI2.Database;
using squadAPI2.Model;
using Microsoft.EntityFrameworkCore;

namespace squadAPI2.Repository
{
    public class DemandaEscolaRepository : IDemandaEscolaRepository
    {
        private readonly ConfigDbContext _context;

        public DemandaEscolaRepository(ConfigDbContext context)
        {
            _context = context;
        }

        public void AddDemandaEscola(DemandaEscola demandaescola)
        {
           _context.Add(demandaescola);
        }

        public void AtualizarDemandaEscola(DemandaEscola demandaescola)
        {
            _context.Update(demandaescola);
        }

        public void DeletarDemandaEscola(DemandaEscola demandaescola)
        {
            _context.Remove(demandaescola);
        }

        public async Task<DemandaEscola> GetDemandaEscolaById(int id)
        {
            return await _context.DemandaEscolas
            .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<DemandaEscola>> GetDemandaEscolas()
        {
            return await _context.DemandaEscolas.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}