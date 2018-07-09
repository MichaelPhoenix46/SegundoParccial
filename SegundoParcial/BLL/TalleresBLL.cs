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
    public class TalleresBLL
    {
        public static bool Guardar(Talleres talleres)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.talleres.Add(talleres) != null)
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
                Talleres talleres = contexto.talleres.Find(id);

                if (talleres != null)
                {
                    contexto.Entry(talleres).State = EntityState.Deleted;
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



        public static bool Editar(Talleres talleres)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(talleres).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static Talleres Buscar(int id)
        {

            Talleres talleres = new Talleres();
            Contexto contexto = new Contexto();

            try
            {
                talleres = contexto.talleres.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return talleres;

        }



        public static List<Talleres> GetList(Expression<Func<Talleres, bool>> expression)
        {
            List<Talleres> talleres = new List<Talleres>();
            Contexto contexto = new Contexto();

            try
            {
                talleres = contexto.talleres.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return talleres;
        }
    }
}