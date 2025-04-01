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
    public partial class FormDatosAutos : Form
    {
        private const string ArchivoAutos = "autos.txt";
        private List<datosAutosAlquilados> listaAutos = new List<datosAutosAlquilados>();
        public FormDatosAutos()
        {
            InitializeComponent();
          
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string placa = textBoxPlaca.Text;
            if (listaAutos.Any(a => a.Placa == placa))
            {
                MessageBox.Show("Ya existe un vehículo con esa placa.");
                return;
            }

            datosAutosAlquilados auto = new datosAutosAlquilados
            {
                Placa = textBoxPlaca.Text,
                Marca = textBoxMarca.Text,
                Modelo = textBoxModelo.Text,
                Color = textBoxColor.Text,
                PrecioPorKm = decimal.Parse(textBoxPrecioKm.Text)
            };

            listaAutos.Add(auto);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LimpiarCampos()
        {
            textBoxPlaca.Clear();
            textBoxMarca.Clear();
            textBoxModelo.Clear();
            textBoxColor.Clear();
            textBoxPrecioKm.Clear();
            textBoxPlaca.Focus();
        }

    }
}
