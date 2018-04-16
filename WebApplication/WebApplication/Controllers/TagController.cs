using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/tags")]
    public class TagController : BaseController<TagController>
    {
        public TagController(StoreContext context) : base(context)
        {
        }
    }
}
