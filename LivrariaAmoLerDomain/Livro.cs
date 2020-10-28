using System;
using System.Collections.Generic;

namespace LivrariaAmoLerDomain
{
    public class Livro
    {

        public Livro()
        {
            this.Autores = new List<Autor>();
        }

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string ISBN { get; set; }

        public int CategoriaId { get; set; }

        public DateTime DataLancamento { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}
