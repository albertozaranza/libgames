using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }

        public virtual Desenvolvedor Desenvolvedor { get; set; }
    }
}
