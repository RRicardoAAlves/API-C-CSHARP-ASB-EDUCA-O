using squadAPI2.Model;

namespace squadAPI2.Repository
{
    public interface ICadastroEmpresaRepository
    {
        Task<IEnumerable<CadastroEmpresa>> GetCadastroEmpresas();
        Task<CadastroEmpresa> GetCadastroEmpresaById(int id);
        void AddCadastroEmpresa(CadastroEmpresa cadastroempresa);
        void AtualizarCadastroEmpresa(CadastroEmpresa cadastroempresa);
        void DeletarCadastroEmpresa(CadastroEmpresa cadastroempresa);
        Task<bool> SaveChangesAsync();
        
    }
}