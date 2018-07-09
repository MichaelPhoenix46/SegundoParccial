using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using SegundoParcial.DAL;
using SegundoParcial.UI.Registros;

namespace SegundoParcial.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Vehiculos> vehiculos { get; set; }
        public DbSet<Talleres> talleres { get; set; }
        public DbSet<EntradaArticulos> entradaArticulos { get; set; }
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Entidades.Mantenimiento> mantenimientos { get; set; }

        public DbSet<MantenimientoDetalle> Detalles { get; set; }

        public Contexto() : base("ConStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}
