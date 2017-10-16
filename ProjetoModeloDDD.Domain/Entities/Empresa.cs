using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Companies
    {
        public int Id { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }
    }
}
