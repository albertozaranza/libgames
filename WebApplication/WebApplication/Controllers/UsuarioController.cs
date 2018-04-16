using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/usuarios")]
    public class UsuarioController : BaseController<UsuarioController>
    {
        public UsuarioController(StoreContext context) : base(context)
        {
        }
    }
}
