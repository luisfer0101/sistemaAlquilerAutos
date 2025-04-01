using System;

namespace sistemaAlquilerAutos
{
    internal class datosReporteAlquiler
    {
        public string NombreCliente { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal TotalPagar { get; set; }
    }
}
