﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppiPrueba.Context;
using WebAppiPrueba.Entities;

namespace WebAppiPrueba.Controllers
{
    [ApiController] //Trae un conjunto de acciones que ayudan a simplificar el código de nuestras acciones
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public AutoresController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[httpget]
        ////en este metodo nos dice que puiede regresar dos tipos de dato
        ////actionresult 200, 404 etc o ienumerable una lista de autores
        //public actionresult<ienumerable<autor>> get()
        //{
        //    //trae un listado de la base de datos 
        //    return context.autores.include(x => x.libros).tolist();
        //}

        //Obtiene un autor en especifico
        [HttpGet ("{id}", Name = "ObtenerAutor")]
        public ActionResult<Autor> Get(int id)
        {
            var autor = context.Autores.Include(x => x.Libros).FirstOrDefault(x => x.Id == id);
            if(autor == null)
            {
                return NotFound();
            }
            return autor;
        }

        [HttpGet("primer")]
        public ActionResult<Autor> GetPrimero()
        {
            return context.Autores.Include(x => x.Libros).FirstOrDefault();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            context.Autores.Add(autor);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id}, autor);
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            //Realiza la busqueda del autor
            var autor = context.Autores.FirstOrDefault(x => x.Id == id);
            if(autor == null)
            {
                return BadRequest();
            }
            context.Autores.Remove(autor);
            context.SaveChanges();
            return autor;
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor autor)
        {
            //Se valida de que el
            if (id != autor.Id)
            {
                return BadRequest();
            }
            context.Entry(autor).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }
    }
}
