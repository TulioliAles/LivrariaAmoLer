using LivrariaAmoLer.Mappping;
using LivrariaAmoLerDomain;
using System.Data.Entity;

namespace LivrariaAmoLer.Context
{
    public class LivrariaAmoLerDataContext : DbContext
    {

        public LivrariaAmoLerDataContext()
            :base("LivrariaAmoLerConnectionString")
        {

        }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new LivroMap());
        }
    }
}