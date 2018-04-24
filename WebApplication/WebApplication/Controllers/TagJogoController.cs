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
    [Route("api/tagjogos")]
    public class TagJogoController : BaseController<TagJogo>
    {
        private readonly StoreContext context;

        public TagJogoController(StoreContext context) : base(context)
        {
            this.context = context;
        }

        [HttpGet]
        public override IQueryable<TagJogo> GetAll()
        {
            var dados = context.TagsJogo.Include(a => a.Tag);
            return dados;
        }
    }
}
