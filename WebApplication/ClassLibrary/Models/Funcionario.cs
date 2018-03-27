using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Funcionario : Pessoa
    {
        public string Formacao { get; set; }
        public string Especializacao { get; set; }

        public virtual Programador Programador { get; set; }
        public virtual Gerente Gerente { get; set; }
    }
}
