﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //El nombre del contenedor es el nombre de la clase ValuesController, sin embargo,
    //por conveccion se omite la palabra Controller.
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        //Cuando se ejecuta el servicio, lo que devuelve el método get es value1, value2.
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value" + id.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
