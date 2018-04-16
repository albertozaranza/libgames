using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/tagjogos")]
    public class TagJogoController : BaseController<TagJogoController>
    {
        public TagJogoController(StoreContext context) : base(context)
        {
        }
    }
}
