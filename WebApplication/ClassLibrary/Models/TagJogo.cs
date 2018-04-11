using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class TagJogo
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int JogoId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual Jogo Jogo { get; set; }
    }
}
