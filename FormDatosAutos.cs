using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            GuardarAutos();
            MostrarAutos();
            LimpiarCampos();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarAutos()
        {
            listaAutos.Clear();
            if (!File.Exists(ArchivoAutos)) return;

            foreach (var linea in File.ReadAllLines(ArchivoAutos))
            {
                string[] datos = linea.Split(',');
                listaAutos.Add(new datosAutosAlquilados
                {
                    Placa = datos[0],
                    Marca = datos[1],
                    Modelo = datos[2],
                    Color = datos[3],
                    PrecioPorKm = decimal.Parse(datos[4])
                });
            }
            MostrarAutos();
        }

        private void GuardarAutos()
        {
            using (StreamWriter sw = new StreamWriter(ArchivoAutos))
            {
                foreach (var auto in listaAutos)
                {
                    sw.WriteLine($"{auto.Placa},{auto.Marca},{auto.Modelo},{auto.Color},{auto.PrecioPorKm}");
                }
            }
        }

        private void MostrarAutos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAutos;
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
