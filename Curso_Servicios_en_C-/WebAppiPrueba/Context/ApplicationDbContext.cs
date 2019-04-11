using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppiPrueba.Entities;

namespace WebAppiPrueba.Context
{
    //Utiliza Microsoft.EntityFrameworkCores para DbContext, se utiliza para poder realizar la configuración de una tabla
    public class ApplicationDbContext : DbContext
    {
        //Contructor y se crea una estancia de DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        //Cada ves que se crea un bdset se deve hacer un Add-Migration 
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { set; get; }
    }
}
