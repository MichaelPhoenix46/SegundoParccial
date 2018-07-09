using SegundoParcial.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulo rArticulo = new rArticulo();
            rArticulo.Show();


        }

        private void entradaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaArticulos rEntradaArticulos = new rEntradaArticulos();
            rEntradaArticulos.Show();
        }

        private void registroDeTalleresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTalleres rTalleres = new rTalleres();
            rTalleres.Show();
        }

        private void registroDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos rVehiculos = new rVehiculos();
            rVehiculos.Show();
        }

        private void registroDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMantenimiento rMantenimiento = new rMantenimiento();
            rMantenimiento.Show();
        }
    }
}
