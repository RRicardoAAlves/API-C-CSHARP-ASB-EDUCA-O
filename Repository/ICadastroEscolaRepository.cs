using squadAPI2.Model;


namespace squadAPI2.Repository
{
    public interface ICadastroEscolaRepository
    {

        Task<IEnumerable<CadastroEscola>> GetCadastroEscolas();
        Task<CadastroEscola> GetCadastroEscolaById(int id);
        void AddCadastroEscola(CadastroEscola cadastroescola);
        void AtualizarCadastroEscola(CadastroEscola cadastroescola);
        void DeletarCadastroEscola(CadastroEscola cadastroescola);
        Task<bool> SaveChangesAsync();

    }
}