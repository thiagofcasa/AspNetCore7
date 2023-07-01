using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Data.Data.Mapping
{
    internal class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable(nameof(Patient));

            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).IsRequired().HasColumnType("varchar(80)")
                .HasColumnName("Nome");

            builder.Property(p => p.Email).HasColumnName("Email")
                .HasColumnType("varchar(150)");

            builder.Property(p => p.Cpf).HasMaxLength(11)
                .IsFixedLength(true)
                .HasColumnName("Cpf")
                .HasColumnType("varchar(11)");

            builder.Property(r => r.Rg).HasMaxLength(15)
                .HasColumnName("Rg")
                .HasColumnType("varchar(15)");

            // 1:1 => Paciente : EstadoPaciente
            builder.HasOne<PatientState>()
                .WithMany(p => p.Patients)
                .HasForeignKey(fk => fk.PatientStateId)
                .HasPrincipalKey(p => p.Id);
            
        }
    }
}
