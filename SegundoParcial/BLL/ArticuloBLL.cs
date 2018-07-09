using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos Articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Articulos.Add(Articulos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }



        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Articulos registrodeArticulos = contexto.Articulos.Find(id);

                if (registrodeArticulos != null)
                {
                    contexto.Entry(registrodeArticulos).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }



        public static bool Editar(Articulos Articulos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(Articulos).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



        public static Articulos Buscar(int id)
        {

            Articulos registrodeArticulos = new Articulos();
            Contexto contexto = new Contexto();

            try
            {
                registrodeArticulos = contexto.Articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return registrodeArticulos;
        }



        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> registro = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {
                registro = contexto.Articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return registro;
        }


        public static decimal CalcularCosto(decimal Ganancia, decimal precio)
        {

            Ganancia /= 100;
            return Convert.ToDecimal(precio) * Convert.ToDecimal(Ganancia);
        }

        public static decimal CalcularGanancia(decimal Costo, decimal Precio)
        {
            Precio -= Costo;
            return (Convert.ToDecimal(Precio) / Convert.ToDecimal(Costo)) * 100;
        }

        public static decimal CalcularPrecio(decimal Costo, decimal Ganancia)
        {
            Ganancia /= 100;
            Ganancia *= Costo;
            return Convert.ToDecimal(Costo) + Convert.ToDecimal(Ganancia);
        }

        public static string RetornarDescripcion(string nombre)
        {
            string descripcion = string.Empty;
            var lista = GetList(x => x.Descripcion.Equals(nombre));
            foreach (var item in lista)
            {
                descripcion = item.Descripcion;
            }

            return descripcion;
        }


    }
}
