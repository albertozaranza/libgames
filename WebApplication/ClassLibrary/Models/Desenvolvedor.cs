using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Desenvolvedor
    {
        public Desenvolvedor()
        {
            Programadores = new List<Programador>();
            Gerentes = new List<Gerente>();
            Enderecos = new List<Endereco> ();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public virtual ICollection<Programador> Programadores { get; set; }
        public virtual ICollection<Gerente> Gerentes { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
