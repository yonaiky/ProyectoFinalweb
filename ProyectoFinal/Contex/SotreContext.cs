using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Contex
{
    public class SotreContext : DbContext
    {
        public DbSet<Socio> Socios { get; set; }
    }
    
}