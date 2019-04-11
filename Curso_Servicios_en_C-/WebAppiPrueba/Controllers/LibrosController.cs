using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppiPrueba.Context;


namespace WebAppiPrueba.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LibrosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Libros>> Get()
        //{
        //    return context.Lib
        //}
    }
}
