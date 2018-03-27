using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Tag
    {

        public Tag()
        {
            TagsJogo = new List<TagJogo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TagJogo> TagsJogo { get; set; }
    }
}
