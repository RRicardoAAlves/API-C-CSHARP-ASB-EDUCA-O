using squadAPI2.Model;

namespace squadAPI2.Repository
{
    public interface IDemandaEscolaRepository
    {

        Task<IEnumerable<DemandaEscola>> GetDemandaEscolas();
        Task<DemandaEscola> GetDemandaEscolaById(int id);
        void AddDemandaEscola(DemandaEscola demandaescola);
        void AtualizarDemandaEscola(DemandaEscola demandaescola);
        void DeletarDemandaEscola(DemandaEscola demandaescola);
        Task<bool> SaveChangesAsync();

    }
}