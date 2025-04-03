using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            CargarDatos();
            MostrarReporte();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            datosAlquiler alquiler = new datosAlquiler
            {
                NitCliente = textBoxNit.Text,
                PlacaVehiculo = textBoxPlaca.Text,
                FechaAlquiler = dateTimePickerAlquiler.Value,
                FechaDevolucion = dateTimePickerDevolucion.Value,
                KilometrosRecorridos = int.Parse(textBoxKmRecorrido.Text)
            };

            listaAlquileres.Add(alquiler);

            using (StreamWriter sw = new StreamWriter(ArchivoAlquileres))
            {
                foreach (var a in listaAlquileres)
                {
                    sw.WriteLine($"{a.NitCliente},{a.PlacaVehiculo},{a.FechaAlquiler.ToShortDateString()},{a.FechaDevolucion.ToShortDateString()},{a.KilometrosRecorridos}");
                }
            }

            MostrarReporte();
            MostrarMayorKm();
        }


        private void CargarDatos()
        {
           
            listaClientes.Clear();
            if (File.Exists(ArchivoClientes))
            {
                foreach (var linea in File.ReadAllLines(ArchivoClientes))
                {
                    var datos = linea.Split(',');
                    listaClientes.Add(new datosClientes
                    {
                        Nit = datos[0],
                        Nombre = datos[1],
                        Direccion = datos[2]
                    });
                }
            }

           
            listaAutos.Clear();
            if (File.Exists(ArchivoAutos))
            {
                foreach (var linea in File.ReadAllLines(ArchivoAutos))
                {
                    var datos = linea.Split(',');
                    listaAutos.Add(new datosAutosAlquilados
                    {
                        Placa = datos[0],
                        Marca = datos[1],
                        Modelo = datos[2],
                        Color = datos[3],
                        PrecioPorKm = decimal.Parse(datos[4])
                    });
                }
            }

          
            listaAlquileres.Clear();
            if (File.Exists(ArchivoAlquileres))
            {
                foreach (var linea in File.ReadAllLines(ArchivoAlquileres))
                {
                    var datos = linea.Split(',');
                    listaAlquileres.Add(new datosAlquiler
                    {
                        NitCliente = datos[0],
                        PlacaVehiculo = datos[1],
                        FechaAlquiler = DateTime.Parse(datos[2]),
                        FechaDevolucion = DateTime.Parse(datos[3]),
                        KilometrosRecorridos = int.Parse(datos[4])
                    });
                }
            }
        }

        private void MostrarReporte()
        {
            List<datosReporteAlquiler> reporte = new List<datosReporteAlquiler>();

            foreach (var alquiler in listaAlquileres)
            {
                var cliente = listaClientes.FirstOrDefault(c => c.Nit == alquiler.NitCliente);
                var auto = listaAutos.FirstOrDefault(a => a.Placa == alquiler.PlacaVehiculo);

                if (cliente != null && auto != null)
                {
                    reporte.Add(new datosReporteAlquiler
                    {
                        NombreCliente = cliente.Nombre,
                        Placa = auto.Placa,
                        Marca = auto.Marca,
                        Modelo = auto.Modelo,
                        Color = auto.Color,
                        FechaDevolucion = alquiler.FechaDevolucion,
                        TotalPagar = alquiler.KilometrosRecorridos * auto.PrecioPorKm
                    });
                }
            }

            dataGridView1.AutoGenerateColumns = true; // Habilita columnas automáticas
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporte;

            if (reporte.Count == 0)
            {
                MessageBox.Show("No hay datos que coincidan entre clientes y autos.");
            }
        }

        private void MostrarMayorKm()
        {
            if (listaAlquileres.Count > 0)
            {
                int mayorKm = listaAlquileres.Max(a => a.KilometrosRecorridos);
                labelMayorKm.Text = $"Mayor recorrido: {mayorKm} km";
            }
        }

        private void textBoxFechaAlquiler_TextChanged(object sender, EventArgs e)
        {

        }
    }
}