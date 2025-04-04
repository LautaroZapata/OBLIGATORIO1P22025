using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vuelo
    {
        string nroVuelo;
        Ruta ruta;
        Avion Avion;
        int frecuencia;

        public string NroVuelo { get => nroVuelo; set => nroVuelo = value; }
        public Ruta Ruta { get => ruta; set => ruta = value; }
        public Avion Avion1 { get => Avion; set => Avion = value; }
        public int Frecuencia { get => frecuencia; set => frecuencia = value; }

        public Vuelo()
        {
        }

        public Vuelo(string nroVuelo, Ruta ruta, Avion avion1, int frecuencia)
        {
            NroVuelo = nroVuelo;
            Ruta = ruta;
            Avion1 = avion1;
            Frecuencia = frecuencia;
        }
    }
}
