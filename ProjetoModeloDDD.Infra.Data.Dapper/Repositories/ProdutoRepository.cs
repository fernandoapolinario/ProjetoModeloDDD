
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using DapperExtensions;

namespace ProjetoModeloDDD.Infra.Data.Dapper.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            using (var db = Context)
            {
                return db.GetList<Produto>().Where(p => p.Nome == nome);
            }
        }
    }
}
