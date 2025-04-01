using System;

namespace sistemaAlquilerAutos
{
    internal class datosAlquiler
    {
        public string NitCliente { get; set; }
        public string PlacaVehiculo { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int KilometrosRecorridos { get; set; }
    }
}
