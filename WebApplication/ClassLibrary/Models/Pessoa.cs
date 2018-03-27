using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
