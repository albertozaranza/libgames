using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Usuario
    {

        public Usuario()
        {
            Jogos = new List<Jogo>();
        }
        
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; }
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoas { get; set; }
        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
