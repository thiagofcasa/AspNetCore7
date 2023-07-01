using Microsoft.EntityFrameworkCore;
using ThinKsaDev.ItDeveloper.Data.Data.Mapping;
using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Data.Data.ORM
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientState> PatientState { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //nesse foreach ele pega todas as propriedades string que não tem referencia de tipo e atribui varchar(90)
            //Nesse caso, ele evitará que uma propriedade não declarada fique com nvarchar e consuma espaço ecessivo.
            //modelBuilder coordena a construção dos objetos relacionando os modelos com a base de dados.
            foreach (var prop in modelBuilder.Model.GetEntityTypes()
                                    .SelectMany(e => e.GetProperties()
                                    .Where(p => p.ClrType == typeof(string))))
            {
                prop.SetColumnType("varchar(90)");
            }

            //Aplicar configuração dando um new no objeto, ele executara o objeto e aplicara as confirações.
            //modelBuilder.ApplyConfiguration(new PatientStateMap());
            //modelBuilder.ApplyConfiguration(new PatientMap());

            //Essa linha faz com que ele aplique as configurações aqui feitas de forma global nesse assemblly,
            //por isso comentamos as linhas acima que aplicava entidade por entidade.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            foreach (var relationshipFk in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                //Para evitar deleção, atualmente não é comum se deletar e sim de inativar um determinado dado.
                //O Ideal é não ter a operação de deletar no CRUC seria um CRU, isso aqui é só para garantir.
                relationshipFk.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
