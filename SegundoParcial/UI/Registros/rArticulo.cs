using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial.UI.Registros
{
    public partial class rArticulo : Form
    {
        public rArticulo()
        {
            InitializeComponent();
        }
        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && articulosIdNumericUpDown.Value == 0)
            {
                errorProvider.SetError(articulosIdNumericUpDown, "Llenar ArticulosId Id");
                errores = true;
            }

            if (error == 2 && precioNumericUpDown.Value == 0)
            {
                errorProvider.SetError(precioNumericUpDown, "Llene precio");
                errores = true;
            }

            if (error == 2 && gananciaNumericUpDown.Value == 0)
            {
                errorProvider.SetError(gananciaNumericUpDown, "Llene Ganancia");
                errores = true;
            }

            if (error == 2 && costoNumericUpDown.Value == 0)
            {
                errorProvider.SetError(costoNumericUpDown, "Llene Costo");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                errorProvider.SetError(descripcionTextBox, "Llene Descripcion");
                errores = true;
            }
            if (error == 2 && string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                errorProvider.SetError(descripcionTextBox, "Llene Descripcion");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(inventarioTextBox.Text))
            {
                errorProvider.SetError(inventarioTextBox, "Llene Inventario");
                errores = true;
            }
            return errores;
        }

        private void Limpiar()
        {
            articulosIdNumericUpDown.Value = 0;
            costoNumericUpDown.Value = 0;
            precioNumericUpDown.Value = 0;
            inventarioTextBox.Clear();
            descripcionTextBox.Clear();
            gananciaNumericUpDown.Value = 0;
            inventarioTextBox.Text = 0.ToString();

            errorProvider.Clear();
        }

        private Articulos Llenaclase()
        {
            Articulos articulos = new Articulos();

            inventarioTextBox.Text = 0.ToString();
            articulos.ArticulosId = Convert.ToInt32(articulosIdNumericUpDown.Value);
            articulos.Descripcion = descripcionTextBox.Text;
            articulos.costo = Convert.ToInt32(costoNumericUpDown.Value);
            articulos.Ganancia = Convert.ToInt32(gananciaNumericUpDown.Value);
            articulos.precio = Convert.ToInt32(precioNumericUpDown.Value);
            articulos.Inventario = Convert.ToInt32(inventarioTextBox.Text);

            return articulos;
        }
      

        
        


        private void VentanaRegistroDeArticulos_Load(object sender, EventArgs e)
        {

        }

       


        private void articulosIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {


        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulos = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (articulosIdNumericUpDown.Value == 0)
                {
                    paso = BLL.ArticulosBLL.Guardar(articulos);
                }
                else
                {
                    paso = BLL.ArticulosBLL.Editar(articulos);
                }
                Limpiar();
                errorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(articulosIdNumericUpDown.Value);
                Articulos articulos = BLL.ArticulosBLL.Buscar(id);

                if (articulos != null)
                {
                    articulosIdNumericUpDown.Value = articulos.ArticulosId;
                    descripcionTextBox.Text = articulos.Descripcion;
                    costoNumericUpDown.Value = articulos.costo;
                    gananciaNumericUpDown.Value = articulos.Ganancia;
                    precioNumericUpDown.Value = articulos.precio;
                    inventarioTextBox.Text = articulos.Inventario.ToString();
                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }
        

        private void descripcionTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gananciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToInt32(costoNumericUpDown.Value);
            decimal precio = Convert.ToInt32(precioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(gananciaNumericUpDown.Value);

            if (costoNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && precioNumericUpDown.Value == 0)
            {
                precioNumericUpDown.Value = BLL.ArticulosBLL.CalcularPrecio(costo, ganancia);
            }
            else
            if (precioNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && costoNumericUpDown.Value == 0)
            {
                costoNumericUpDown.Value = BLL.ArticulosBLL.CalcularCosto(ganancia, precio);
            }

        }

        private void precioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(costoNumericUpDown.Value);
            decimal precio = Convert.ToDecimal(precioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(gananciaNumericUpDown.Value);

            if (precioNumericUpDown.Value > costoNumericUpDown.Value && gananciaNumericUpDown.Value == 0)
            {
                gananciaNumericUpDown.Value = BLL.ArticulosBLL.CalcularGanancia(costo, precio);
            }
            else
            if (precioNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && costoNumericUpDown.Value == 0)
            {
                costoNumericUpDown.Value = BLL.ArticulosBLL.CalcularCosto(ganancia, precio);
            }

        }

        private void costoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToInt32(costoNumericUpDown.Value);
            decimal precio = Convert.ToInt32(precioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(gananciaNumericUpDown.Value);

            if (costoNumericUpDown.Value < precioNumericUpDown.Value && gananciaNumericUpDown.Value == 0)
            {
                gananciaNumericUpDown.Value = BLL.ArticulosBLL.CalcularGanancia(costo, costo);
            }
            else

                if (costoNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && precioNumericUpDown.Value == 0)
            {
                precioNumericUpDown.Value = BLL.ArticulosBLL.CalcularPrecio(costo, ganancia);
            }


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(articulosIdNumericUpDown.Value);

                if (BLL.ArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void inventarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void articulosIdNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}