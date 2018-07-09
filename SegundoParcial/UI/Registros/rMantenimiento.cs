using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial.UI.Registros
{
    public partial class rMantenimiento : Form
    {
        decimal itbis = 0;
        decimal importe = 0;
        decimal Total = 0;
        decimal subtotal = 0;

        public rMantenimiento()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        public void Limpiar()
        {
            mantenimientoIdNumericUpDown.Value = 0;
            fechaDateTimePicker.Value = DateTime.Now;
            cantidadNumericUpDown.Value = 0;
            TotaltextBox.Clear();

            importeTextBox.Clear();
            subtotaltextBox.Text = 0.ToString();
            TotaltextBox.Text = 0.ToString();
            ItbistextBox.Text = 0.ToString();
            DetalledataGridView.DataSource = null;

            itbis = 0;
            importe = 0;
            Total = 0;
            subtotal = 0;

            errorProvider.Clear();
        }

        public void QuitarColumnas()
        {
            DetalledataGridView.Columns["MantenimientoId"].Visible = false;
            DetalledataGridView.Columns["Id"].Visible = false;
            DetalledataGridView.Columns["MantenimientoId"].Visible = false;
            DetalledataGridView.Columns["TallerId"].Visible = false;
            DetalledataGridView.Columns["ArticulosId"].Visible = false;
            DetalledataGridView.Columns["RegistrodeArticulos"].Visible = false;
        }

        private Mantenimiento LlenaClase()
        {
            Mantenimiento matenimiento = new Mantenimiento();

            matenimiento.MantenimientoId = Convert.ToInt32(mantenimientoIdNumericUpDown.Value);
            matenimiento.VehiculoId = Convert.ToInt32(vehiculoComboBox.SelectedValue);
            matenimiento.Fecha = fechaDateTimePicker.Value;
            matenimiento.Subtotal = Convert.ToDecimal(subtotaltextBox.Text);
            matenimiento.itbis = Convert.ToDecimal(ItbistextBox.Text);
            matenimiento.Total = Convert.ToDecimal(TotaltextBox.Text);

            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {

                matenimiento.AgregarDetalle
                    (ToInt(item.Cells["id"].Value),
                     matenimiento.MantenimientoId,
                       ToInt(item.Cells["tallerId"].Value),
                     ToInt(item.Cells["articulosId"].Value),
                      Convert.ToString(item.Cells["articulo"].Value),
                       ToInt(item.Cells["cantidad"].Value),
                    ToInt(item.Cells["precio"].Value),
                    ToInt(item.Cells["importe"].Value)

                  );
            }
            return matenimiento;
        }


        private void LlenarCampos(Mantenimiento mantenimiento)
        {
            Limpiar();
            mantenimientoIdNumericUpDown.Value = mantenimiento.MantenimientoId;
            fechaDateTimePicker.Value = mantenimiento.Fecha;
            subtotaltextBox.Text = mantenimiento.Subtotal.ToString();
            ItbistextBox.Text = mantenimiento.itbis.ToString();
            TotaltextBox.Text = mantenimiento.Total.ToString();

            foreach (var item in mantenimiento.Detalle)
            {
                subtotal += item.Importe;
            }
            subtotaltextBox.Text = subtotal.ToString();

            DetalledataGridView.DataSource = mantenimiento.Detalle;
            QuitarColumnas();

        }

        private void LlenarComboBox()
        {
            Repositorio<Vehiculos> vehiculos = new Repositorio<Vehiculos>(new Contexto());
            vehiculoComboBox.DataSource = vehiculos.GetList(c => true);
            vehiculoComboBox.ValueMember = "VehiculosId";
            vehiculoComboBox.DisplayMember = "Descripcion";

            Repositorio<Talleres> talleres = new Repositorio<Talleres>(new Contexto());
            tallerComboBox.DataSource = talleres.GetList(c => true);
            tallerComboBox.ValueMember = "TallerId";
            tallerComboBox.DisplayMember = "Nombre";

            Repositorio<Articulos> Entrada = new Repositorio<Articulos>(new Contexto());
            articulosComboBox.DataSource = Entrada.GetList(c => true);
            articulosComboBox.ValueMember = "ArticulosId";
            articulosComboBox.DisplayMember = "Descripcion";
        }
        private void RegistroDeMantenimiento_Load(object sender, EventArgs e)
        {


            DateTime fecha = Convert.ToDateTime(fechaproximaDateTimePicker.Text);
            fecha = fecha.AddDays(90);

            fechaproximaDateTimePicker.Text = fecha.ToString();

        }

        private void articulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in BLL.ArticulosBLL.GetList(x => x.Descripcion == articulosComboBox.Text))
            {
                precioTextBox.Text = item.precio.ToString();

            }
        }

        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            List<MantenimientoDetalle> detalle = new List<MantenimientoDetalle>();
            Mantenimiento mantenimiento = new Mantenimiento();


            if (DetalledataGridView.DataSource != null)
            {
                mantenimiento.Detalle = (List<MantenimientoDetalle>)DetalledataGridView.DataSource;
            }

            

            foreach (var item in BLL.ArticulosBLL.GetList(x => x.Inventario < cantidadNumericUpDown.Value))
            {

                MessageBox.Show("No hay esa Existencia para Vender ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (string.IsNullOrEmpty(importeTextBox.Text))
            {
                MessageBox.Show("Importe esta vacio , Llene cantidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mantenimiento.Detalle.Add(
                    new MantenimientoDetalle(id: 0,
                    mantenimientoId: (int)Convert.ToInt32(mantenimientoIdNumericUpDown.Value),
                    tallerId: (int)tallerComboBox.SelectedValue,
                       articulosId: (int)articulosComboBox.SelectedValue,
                            articulo: (string)BLL.ArticulosBLL.RetornarDescripcion(articulosComboBox.Text),
                        cantidad: (int)Convert.ToInt32(cantidadNumericUpDown.Value),
                        precio: (int)Convert.ToInt32(precioTextBox.Text),
                        importe: (int)Convert.ToInt32(importeTextBox.Text)
                    ));
        
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = mantenimiento.Detalle;

                QuitarColumnas();


            }


            importe += BLL.MantenimientoBLL.CalcularImporte(Convert.ToDecimal(precioTextBox.Text), Convert.ToInt32(cantidadNumericUpDown.Value));

            if (mantenimientoIdNumericUpDown.Value != 0)
            {

                subtotal += importe;
                subtotaltextBox.Text = subtotal.ToString();
            }
            else
            {

                subtotal = importe;
                subtotaltextBox.Text = subtotal.ToString();
            }

            itbis = BLL.MantenimientoBLL.CalcularItbis(Convert.ToDecimal(subtotaltextBox.Text));

            ItbistextBox.Text = itbis.ToString();

            Total = BLL.MantenimientoBLL.Total(Convert.ToDecimal(subtotaltextBox.Text), Convert.ToDecimal(ItbistextBox.Text));

            TotaltextBox.Text = Total.ToString();

        }

        private void cantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            importeTextBox.Text = BLL.MantenimientoBLL.CalcularImporte(Convert.ToInt32(precioTextBox.Text), Convert.ToInt32(cantidadNumericUpDown.Value)).ToString(); ;

        }

        private void fechaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


            fechaproximaDateTimePicker.Value = fechaDateTimePicker.Value;


            DateTime fecha = Convert.ToDateTime(fechaproximaDateTimePicker.Text);
            fecha = fecha.AddDays(90);

            fechaproximaDateTimePicker.Text = fecha.ToString();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(mantenimientoIdNumericUpDown.Value);
            Mantenimiento mantenimiento = BLL.MantenimientoBLL.Buscar(id);

            if (mantenimiento != null)
            {
                LlenarCampos(mantenimiento);

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


        }



        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (Validar(1))
            {


                MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int id = Convert.ToInt32(mantenimientoIdNumericUpDown.Value);
                if (BLL.MantenimientoBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("Debe Agregar Algun Producto al Grid", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Mantenimiento mantenimiento = LlenaClase();
                bool Paso = false;

                if (mantenimientoIdNumericUpDown.Value == 0)
                {
                    Paso = BLL.MantenimientoBLL.Guardar(mantenimiento);
                    errorProvider.Clear();
                }
                else
                {

                    Paso = BLL.MantenimientoBLL.Editar(mantenimiento);
                    errorProvider.Clear();
                }



                
                if (Paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Removerbutton_Click_1(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {

                List<MantenimientoDetalle> detalle = (List<MantenimientoDetalle>)DetalledataGridView.DataSource;

                subtotal -= detalle.ElementAt(DetalledataGridView.CurrentRow.Index).Importe;

                detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);




                subtotaltextBox.Text = subtotal.ToString();

                itbis = BLL.MantenimientoBLL.CalcularItbis(Convert.ToDecimal(subtotaltextBox.Text));
                ItbistextBox.Text = itbis.ToString();

                Total = BLL.MantenimientoBLL.Total(Convert.ToDecimal(subtotaltextBox.Text), Convert.ToDecimal(ItbistextBox.Text));

                TotaltextBox.Text = Total.ToString();


                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = detalle;


                QuitarColumnas();
            }

        }

        private bool Validar(int error)
        {
            bool paso = false;



            if (error == 1 && mantenimientoIdNumericUpDown.Value == 0)
            {
                errorProvider.SetError(mantenimientoIdNumericUpDown,
                   "No debes dejar la Mantenimien Id Vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(TotaltextBox.Text))
            {
                errorProvider.SetError(TotaltextBox,
                   "No debes dejar la total vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(subtotaltextBox.Text))
            {
                errorProvider.SetError(subtotaltextBox,
                   "No debes dejar la subtotal vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(ItbistextBox.Text))
            {
                errorProvider.SetError(ItbistextBox,
                   "No debes dejar la Itbis vacio");
                paso = true;
            }

            if (error == 2 && DetalledataGridView.RowCount == 0)
            {
                errorProvider.SetError(DetalledataGridView,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            if (error == 3 && string.IsNullOrEmpty(importeTextBox.Text))
            {
                errorProvider.SetError(importeTextBox,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            return paso;
        }

        private void Tallerlabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rMantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
