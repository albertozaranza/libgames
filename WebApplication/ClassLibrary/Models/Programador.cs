using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Programador : Funcionario
    {
        public int DesenvolvedorId { get; set; }

        public virtual Desenvolvedor Desenvolvedor { get; set; }
    }
}
