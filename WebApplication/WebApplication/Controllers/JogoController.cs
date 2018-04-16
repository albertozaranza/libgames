using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/jogos")]
    public class JogoController : BaseController<JogoController>
    {
        public JogoController(StoreContext context) : base(context)
        {
        }
    }
}
