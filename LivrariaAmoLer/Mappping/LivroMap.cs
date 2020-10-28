﻿using LivrariaAmoLerDomain;
using System.Data.Entity.ModelConfiguration;

namespace LivrariaAmoLer.Mappping
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");

            HasKey(x => x.Id);
            Property(x => x.Titulo).HasMaxLength(60).IsRequired();
            Property(x => x.ISBN).HasMaxLength(32).IsRequired();
            Property(x => x.DataLancamento).IsRequired();
        }
    }
}