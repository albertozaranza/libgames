using ClassLibrary;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/jogos")]
    public class JogoController : BaseController<Jogo>
    {
        private readonly StoreContext context;

        public JogoController(StoreContext context) : base(context)
        {
            this.context = context;
        }

        [HttpGet]
        public override IQueryable<Jogo> GetAll()
        {
            var dados = context.Jogos.Include(a => a.TagsJogo);
            return dados;
        }
    }
}
