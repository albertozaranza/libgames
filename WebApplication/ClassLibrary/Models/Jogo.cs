using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Jogo
    {
        public Jogo()
        {
            TagsJogo = new List<TagJogo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Lancamento { get; set; }
        public double Preco { get; set; }
        public double Classificacao { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<TagJogo> TagsJogo { get; set; }
    }
}
