using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Desenvolvedor
    {
        public Desenvolvedor()
        {
            Funcionarios = new List<Funcionario>();
            Jogos = new List<Jogo>();

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public int EnderecoId { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }        
    }
}
