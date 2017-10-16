

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class EmpresaViewModel
    {
        [Key]
        public int Id { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }
    }
}