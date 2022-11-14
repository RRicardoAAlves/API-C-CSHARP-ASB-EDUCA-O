using Microsoft.EntityFrameworkCore;
using squadAPI2.Model;

namespace squadAPI2.Database
{
    public class ConfigDbContext : DbContext
    {
        public ConfigDbContext(DbContextOptions<ConfigDbContext>
        options) : base(options)
        {

        }



        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CadastroEscola> CadastroEscolas { get; set; }
        public DbSet<CadastroEmpresa> CadastroEmpresas { get; set; }
        public DbSet<DemandaEscola> DemandaEscolas { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.ToTable("usuario");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.RazaoSocial).HasColumnName("razao_social").IsRequired();
            usuario.Property(x => x.Email).HasColumnName("email");
            usuario.Property(x => x.Senha).HasColumnName("senha");

            var cadastroescola = modelBuilder.Entity<CadastroEscola>();
            cadastroescola.ToTable("cadastro_escola");
            cadastroescola.HasKey(x => x.Id);
            cadastroescola.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            cadastroescola.Property(x => x.RazaoSocial).HasColumnName("razao_social").IsRequired();
            cadastroescola.Property(x => x.Cnpj).HasColumnName("cnpj");
            cadastroescola.Property(x => x.Rua).HasColumnName("rua");
            cadastroescola.Property(x => x.Numero).HasColumnName("numero");
            cadastroescola.Property(x => x.Bairro).HasColumnName("bairro");
            cadastroescola.Property(x => x.Complemento).HasColumnName("complemento");
            cadastroescola.Property(x => x.Cep).HasColumnName("cep");
            cadastroescola.Property(x => x.Cidade).HasColumnName("cidade");
            cadastroescola.Property(x => x.Estado).HasColumnName("estado");
            cadastroescola.Property(x => x.NomeRepresentante).HasColumnName("nome_representante");
            cadastroescola.Property(x => x.Email).HasColumnName("email");
            cadastroescola.Property(x => x.Telefone).HasColumnName("telefone");

            var cadastroempresa = modelBuilder.Entity<CadastroEmpresa>();
            cadastroempresa.ToTable("cadastro_empresa");
            cadastroempresa.HasKey(x => x.Id);
            cadastroempresa.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            cadastroempresa.Property(x => x.RazaoSocial).HasColumnName("razao_social").IsRequired();
            cadastroempresa.Property(x => x.Cnpj).HasColumnName("cnpj");
            cadastroempresa.Property(x => x.Rua).HasColumnName("rua");
            cadastroempresa.Property(x => x.Numero).HasColumnName("numero");
            cadastroempresa.Property(x => x.Bairro).HasColumnName("bairro");
            cadastroempresa.Property(x => x.Complemento).HasColumnName("complemento");
            cadastroempresa.Property(x => x.Cep).HasColumnName("cep");
            cadastroempresa.Property(x => x.Cidade).HasColumnName("cidade");
            cadastroempresa.Property(x => x.Estado).HasColumnName("estado");
            cadastroempresa.Property(x => x.NomeRepresentante).HasColumnName("nome_representante");
            cadastroempresa.Property(x => x.Email).HasColumnName("email");
            cadastroempresa.Property(x => x.Telefone).HasColumnName("telefone");

            var demandaescola = modelBuilder.Entity<DemandaEscola>();
            demandaescola.ToTable("demanda_escola");
            demandaescola.HasKey(x => x.Id);
            demandaescola.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            demandaescola.Property(x => x.Demanda).HasColumnName("demanda").IsRequired();
            demandaescola.Property(x => x.DescricaoDemanda).HasColumnName("descricao_demanda").IsRequired();
            demandaescola.Property(x => x.DataDemanda).HasColumnName("data_demanda").IsRequired();

                        
        }

    }


}