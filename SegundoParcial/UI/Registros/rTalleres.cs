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
    public partial class rTalleres : Form
    {
        public rTalleres()
        {
            InitializeComponent();
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && tallerIdNumericUpDown.Value == 0)
            {
                errorProvider.SetError(tallerIdNumericUpDown, "Llenar taller Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider.SetError(nombreTextBox, "Llene Nombre");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            tallerIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();


            errorProvider.Clear();
        }
        private Talleres Llenaclase()
        {
            Talleres talleres = new Talleres();
            talleres.TallerId = Convert.ToInt32(tallerIdNumericUpDown.Value);
            talleres.Nombre = nombreTextBox.Text;


            return talleres;
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar (Talleres Id) para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(tallerIdNumericUpDown.Value);
                Talleres talleres = BLL.TalleresBLL.Buscar(id);

                if (talleres != null)
                {
                    tallerIdNumericUpDown.Value = talleres.TallerId;
                    nombreTextBox.Text = talleres.Nombre;



                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }
        }



        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar (Vehiculos Id) para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(tallerIdNumericUpDown.Value);

                if (BLL.TalleresBLL.Eliminar(id))
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

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            Talleres talleres = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (tallerIdNumericUpDown.Value == 0)
                {
                    paso = BLL.TalleresBLL.Guardar(talleres);
                }
                else
                {
                    paso = BLL.TalleresBLL.Editar(talleres);
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


        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar ();
        }
    }
}
