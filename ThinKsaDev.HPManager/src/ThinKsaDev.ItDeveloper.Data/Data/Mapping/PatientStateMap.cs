using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Data.Data.Mapping
{
    public class PatientStateMap : IEntityTypeConfiguration<PatientState>
    {
        public void Configure(EntityTypeBuilder<PatientState> builder)
        {
            //nome da tabela. Caso queria um nome especifico para a tabela. Se não fizer nada ele aceita o default.
            builder.ToTable(nameof(PatientState));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description)
                .HasColumnType("Varchar(30)")
                .IsRequired().HasColumnName("Descricao");

            builder.HasMany(p => p.Patients)
                .WithOne(p => p.PatientState);
                //.OnDelete(DeleteBehavior.NoAction);
        }
    }
}
