using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFinancia.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinancia.Api.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario")
            .HasKey(p => p.Id);

            builder.Property(p => p.Email)
            .HasColumnType("Varchar")
            .IsRequired();

            builder.Property(p => p.Senha)
            .HasColumnType("Varchar")
            .IsRequired();

            builder.Property(p => p.DataCadastro)
            .HasColumnType("Timestamp")
            .IsRequired();

            builder.Property(p => p.DataInativaçao)
            .HasColumnType("Timestamp");

        }
    }
}