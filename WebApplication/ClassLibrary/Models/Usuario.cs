using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Usuario : Pessoa
    {

        public Usuario()
        {
            Jogos = new List<Jogo>();
        }
        
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
