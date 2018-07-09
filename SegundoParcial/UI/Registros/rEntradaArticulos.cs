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
    public partial class rEntradaArticulos : Form
    {
        public rEntradaArticulos()
        {
            InitializeComponent();
        }

        private void EntradaArticulos_Load(object sender, EventArgs e)
        {

        }
        private void LlenaComboBox()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>(new Contexto());
            articulosComboBox.DataSource = repositorio.GetList(c => true);
            articulosComboBox.ValueMember = "ArticulosId";
            articulosComboBox.DisplayMember = "Descripcion";
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && entradaIdNumericUpDown.Value == 0)
            {
                errorProvider.SetError(entradaIdNumericUpDown, "Llenar Entrada Id");
                errores = true;
            }

            if (error == 2 && cantidadNumericUpDown.Value == 0)
            {
                errorProvider.SetError(cantidadNumericUpDown, "Llene Nombre");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            entradaIdNumericUpDown.Value = 0;
            cantidadNumericUpDown.Value = 0;


            errorProvider.Clear();
        }
        private EntradaArticulos Llenaclase()
        {
            EntradaArticulos entradaArticulo = new EntradaArticulos();
            entradaArticulo.EntradaId = Convert.ToInt32(entradaIdNumericUpDown.Value);
            entradaArticulo.Articulos = articulosComboBox.Text;
            entradaArticulo.Cantidad = Convert.ToInt32(cantidadNumericUpDown.Value);


            return entradaArticulo;
        }
        

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar (Vehiculos Id) para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(entradaIdNumericUpDown.Value);

                if (BLL.EntradaArticulosBLL.Eliminar(id))
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

        private void articulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            EntradaArticulos entradaArticulo = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (entradaIdNumericUpDown.Value == 0)
                {
                    paso = BLL.EntradaArticulosBLL.Guardar(entradaArticulo);
                }
                else
                {
                    paso = BLL.EntradaArticulosBLL.Editar(entradaArticulo);
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

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(entradaIdNumericUpDown.Value);
                EntradaArticulos registroEntradaDeArticulos = BLL.EntradaArticulosBLL.Buscar(id);

                if (registroEntradaDeArticulos != null)
                {
                    entradaIdNumericUpDown.Value = registroEntradaDeArticulos.EntradaId;
                    articulosComboBox.Text = registroEntradaDeArticulos.Articulos;
                    cantidadNumericUpDown.Value = registroEntradaDeArticulos.Cantidad;



                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }

    }
}
