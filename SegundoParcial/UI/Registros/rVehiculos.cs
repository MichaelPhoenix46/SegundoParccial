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
    public partial class rVehiculos : Form
    {
        public rVehiculos()
        {
            InitializeComponent();
        }
        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && vehiculosIdNumericUpDown.Value == 0)
            {
                errorProvider.SetError(vehiculosIdNumericUpDown, "Llenar Persona Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                errorProvider.SetError(descripcionTextBox, "Llene Mantenimiento");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            vehiculosIdNumericUpDown.Value = 0;
            descripcionTextBox.Clear();
            mantenimientoTextBox.Clear();

            errorProvider.Clear();
        }
        private Vehiculos Llenaclase()
        {
            mantenimientoTextBox.Text = 0.ToString();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.VehiculosId = Convert.ToInt32(vehiculosIdNumericUpDown.Value);
            vehiculos.Descripcion = descripcionTextBox.Text;
            vehiculos.Mantenimiento = Convert.ToDecimal(mantenimientoTextBox.Text);


            return vehiculos;
        }
        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {

            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar (Vehiculo Id) para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(vehiculosIdNumericUpDown.Value);
                Vehiculos vehiculos = BLL.VehiculosBLL.Buscar(id);

                if (vehiculos != null)
                {
                    vehiculosIdNumericUpDown.Value = vehiculos.VehiculosId;
                    descripcionTextBox.Text = vehiculos.Descripcion;
                    mantenimientoTextBox.Text = vehiculos.Mantenimiento.ToString();


                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider.Clear();
            }

        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            Vehiculos vehiculos = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (vehiculosIdNumericUpDown.Value == 0)
                {
                    paso = BLL.VehiculosBLL.Guardar(vehiculos);
                }
                else
                {
                    paso = BLL.VehiculosBLL.Editar(vehiculos);
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

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {

            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar (Vehiculos Id) para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(vehiculosIdNumericUpDown.Value);

                if (BLL.VehiculosBLL.Eliminar(id))
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

        private void vehiculosIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
