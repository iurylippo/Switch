using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Sobrenome).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(32).IsRequired();
            builder.Property(u => u.Sexo).IsRequired();
            builder.Property(u => u.UrlFoto).HasMaxLength(100).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();
        }
    }
}
