using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ruta
    {
        int id;
        static int ultimoId;
        Aeropuerto aeropuertoSalida;
        Aeropuerto aeropuertoLlegada;

        public int Id { get => id; set => id = value; }
        public static int UltimoId { get => ultimoId; set => ultimoId = value; }
        public Aeropuerto AeropuertoSalida { get => aeropuertoSalida; set => aeropuertoSalida = value; }
        public Aeropuerto AeropuertoLlegada { get => aeropuertoLlegada; set => aeropuertoLlegada = value; }

        public Ruta(int id, Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada)
        {
            Id = ++ultimoId;
            AeropuertoSalida = aeropuertoSalida;
            AeropuertoLlegada = aeropuertoLlegada;
        }

        public Ruta()
        {
            Id = ++ultimoId;
        }
    }
}
