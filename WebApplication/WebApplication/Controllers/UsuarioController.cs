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
    [Route("api/usuarios")]
    public class UsuarioController : BaseController<Usuario>
    {
        private readonly StoreContext context;

        public UsuarioController(StoreContext context) : base(context)
        {
            this.context = context;
        }

        [HttpGet]
        public override IQueryable<Usuario> GetAll()
        {
            var dados = context.Usuarios.Include(a => a.Pessoas).Include(b => b.Jogos);
            return dados;
        }
    }
}
