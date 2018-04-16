using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/desenvolvedores")]
    public class DesenvolvedorController : BaseController<DesenvolvedorController>
    {
        public DesenvolvedorController(StoreContext context) : base(context)
        {
        }
    }
}
