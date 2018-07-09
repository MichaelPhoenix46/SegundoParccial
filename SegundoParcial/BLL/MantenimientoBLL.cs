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
    public class MantenimientoBLL
    {
        public static bool Guardar(Mantenimiento mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


            Vehiculos vehiculos = new Vehiculos();
            try
            {
                if (contexto.mantenimientos.Add(mantenimiento) != null)
                {

                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticulosId).Inventario -= item.Cantidad;
                    }


                    contexto.vehiculos.Find(mantenimiento.VehiculoId).Mantenimiento += mantenimiento.Total;

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
                Mantenimiento mantenimiento = contexto.mantenimientos.Find(id);

                if (mantenimiento != null)
                {
                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticulosId).Inventario += item.Cantidad;
                    }

                    contexto.vehiculos.Find(mantenimiento.VehiculoId).Mantenimiento -= mantenimiento.Total;

                    mantenimiento.Detalle.Count();
                    contexto.mantenimientos.Remove(mantenimiento);
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }




        public static Mantenimiento Buscar(int id)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            Contexto contexto = new Contexto();

            try
            {
                mantenimiento = contexto.mantenimientos.Find(id);
                if (mantenimiento != null)
                {
                    mantenimiento.Detalle.Count();

                    foreach (var item in mantenimiento.Detalle)
                    {
                        string s = item.RegistrodeArticulos.Descripcion;
                    }
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return mantenimiento;
        }


        public static bool Editar(Mantenimiento mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var Mantenimiento = BLL.MantenimientoBLL.Buscar(mantenimiento.MantenimientoId);


                if (Mantenimiento != null)
                {


                    foreach (var item in Mantenimiento.Detalle)
                    {

                        contexto.Articulos.Find(item.ArticulosId).Inventario += item.Cantidad;


                        if (!mantenimiento.Detalle.ToList().Exists(v => v.Id == item.Id))
                        {
                            contexto.entradaArticulos.Find(item.ArticulosId).Cantidad -= item.Cantidad;

                            item.RegistrodeArticulos = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }
                    }

                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticulosId).Inventario += item.Cantidad;

                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }
                    contexto.Entry(mantenimiento).State = EntityState.Modified;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }



        public static List<Mantenimiento> GetList(Expression<Func<Mantenimiento, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Mantenimiento> registrodeMantenimientos = new List<Mantenimiento>();

            try
            {
                registrodeMantenimientos = contexto.mantenimientos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return registrodeMantenimientos;

        }

        public static decimal CalcularImporte(decimal precio, int cantidad)
        {
            return Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
        }
        public static decimal CalcularItbis(decimal subtotal)
        {
            return Convert.ToDecimal(subtotal) * Convert.ToDecimal(0.18);
        }

        public static decimal Total(decimal subtotal, decimal itbis)
        {
            return Convert.ToDecimal(subtotal) + Convert.ToDecimal(itbis);
        }


    }
}