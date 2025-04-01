using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAlquilerAutos
{
    public partial class FormAlquiler : Form
    {

        private const string ArchivoClientes = "clientes.txt";
        private const string ArchivoAutos = "autos.txt";
        private const string ArchivoAlquileres = "alquileres.txt";

        private List<datosClientes> listaClientes = new List<datosClientes>();
        private List<datosAutosAlquilados> listaAutos = new List<datosAutosAlquilados>();
        private List<datosAlquiler> listaAlquileres = new List<datosAlquiler>();

        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}