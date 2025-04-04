using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aeropuerto
    {
        string codigoIata;
        string ciudad;
        decimal costoOperacion;
        decimal costoTasas;

        public string CodigoIata { get => codigoIata; set => codigoIata = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public decimal CostoOperacion { get => costoOperacion; set => costoOperacion = value; }
        public decimal CostoTasas { get => costoTasas; set => costoTasas = value; }

        public Aeropuerto(string codigoIata, string ciudad, decimal costoOperacion, decimal costoTasas)
        {
            CodigoIata = codigoIata;
            Ciudad = ciudad;
            CostoOperacion = costoOperacion;
            CostoTasas = costoTasas;
        }

        public Aeropuerto()
        {
        }
    }
}
