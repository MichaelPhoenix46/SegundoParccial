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
    public class VehiculosBLL
    {
        public static bool Guardar(Vehiculos vehiculos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.vehiculos.Add(vehiculos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }


        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Vehiculos vehiculos = contexto.vehiculos.Find(id);

                if (vehiculos != null)
                {
                    contexto.Entry(vehiculos).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception) { throw; }

            return paso;
        }



        public static bool Editar(Vehiculos vehiculos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(vehiculos).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static Vehiculos Buscar(int id)
        {

            Vehiculos vehiculos = new Vehiculos();
            Contexto contexto = new Contexto();

            try
            {
                vehiculos = contexto.vehiculos.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return vehiculos;

        }



        public static List<Vehiculos> GetList(Expression<Func<Vehiculos, bool>> expression)
        {
            List<Vehiculos> vehiculos = new List<Vehiculos>();
            Contexto contexto = new Contexto();

            try
            {
                vehiculos = contexto.vehiculos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return vehiculos;
        }
    }
}