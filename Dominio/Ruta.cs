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
        int distancia;

        public int Id { get => id; set => id = value; }
        public static int UltimoId { get => ultimoId; set => ultimoId = value; }
        public Aeropuerto AeropuertoSalida { get => aeropuertoSalida; set => aeropuertoSalida = value; }
        public Aeropuerto AeropuertoLlegada { get => aeropuertoLlegada; set => aeropuertoLlegada = value; }
        public int Distancia { get => distancia; set => distancia = value; }

        public Ruta(int id, Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada, int ruta)
        {
            Id = ++ultimoId;
            AeropuertoSalida = aeropuertoSalida;
            AeropuertoLlegada = aeropuertoLlegada;
            Distancia = distancia;
        }

        public Ruta()
        {
            Id = ++ultimoId;
        }

        public void Validar()
        {
            ValidarDistancia();
            
        }


        public void ValidarDistancia()
        {
            if (distancia < 1) throw new Exception("La distancia de la ruta debe ser mayor a 1KM");
        }

        
    }
}
