
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using DapperExtensions;

namespace ProjetoModeloDDD.Infra.Data.Dapper.Repositories
{
    public class EmpresaRepository : RepositoryBase<Companies>, IEmpresaRepository
    {
    }
}
