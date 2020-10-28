﻿using LivrariaAmoLerDomain;
using System.Data.Entity.ModelConfiguration;

namespace LivrariaAmoLer.Mappping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();

            HasMany(x => x.Livros).WithRequired(x => x.Categoria);
        }
    }
}