using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class EntradaArticulos
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Articulos { get; set; }
        public int Cantidad { get; set; }

        public EntradaArticulos()
        {
            EntradaId = 0;
            Fecha = DateTime.Now;
            Articulos = string.Empty;
            Cantidad = 0;
        }



        public override string ToString()
        {
            return this.Articulos;
        }
    }
}
