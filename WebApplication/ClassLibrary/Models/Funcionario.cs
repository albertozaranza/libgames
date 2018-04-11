using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Formacao { get; set; }
        public string Especializacao { get; set; }
        public int PessoaId { get; set; }
        public int DesenvolvedorId { get; set; }

        public virtual Programador Programador { get; set; }
        public virtual Gerente Gerente { get; set; }
        public virtual Desenvolvedor Desenvolvedor { get; set; }
    }
}
