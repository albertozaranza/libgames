using ClassLibrary;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/tags")]
    public class TagController : BaseController<Tag>
    {
        public TagController(StoreContext context) : base(context)
        {
        }
    }
}
