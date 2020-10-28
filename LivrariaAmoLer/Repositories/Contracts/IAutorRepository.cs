using LivrariaAmoLerDomain;
using System;
using System.Collections.Generic;

namespace LivrariaAmoLer.Repositories.Contracts
{
    public interface IAutorRepository : IDisposable
    {
        List<Autor> Get();
        Autor Get(int id);
        List<Autor> GetByName(string nome);
        bool Create(Autor autor);
        bool Update(Autor autor);
        void Delete(int id);

    }
}
