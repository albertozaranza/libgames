using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Gerente : Funcionario
    {
        public int Registro { get; set; }
        public int DesenvolvedorId { get; set; }

        public virtual Desenvolvedor Desenvolvedor { get; set; }
    }
}
