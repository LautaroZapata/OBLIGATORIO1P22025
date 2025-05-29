using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasaje
    {
        int id;
        static int ultimoId;
        Vuelo vuelo;
        DateTime fecha;
        Cliente pasajero;
        Equipaje equipaje;
        decimal precio;

        

        public int Id { get => id; set => id = value; }
        public static int UltimoId { get => ultimoId; set => ultimoId = value; }
        public Vuelo Vuelo { get => vuelo; set => vuelo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Cliente Pasajero { get => pasajero; set => pasajero = value; }
        public Equipaje Equipaje { get => equipaje; set => equipaje = value; }
        public decimal Precio { get => precio; set => precio = value; }

        public Pasaje(Vuelo vuelo, DateTime fecha, Cliente pasajero, Equipaje equipaje, decimal precio)
        {
            Id = ++ultimoId;
            Vuelo = vuelo;
            Fecha = fecha;
            Pasajero = pasajero;
            Equipaje = equipaje;
            Precio = precio;
        }

        public Pasaje()
        {
            Id = ++ultimoId;
        }

        public void Validar()
        {
            ValidarFechaConFrecuencia();
            // Son metodos para la segunda entrega.
            //ValidarEquipaje(); 
            //ValidarPrecio();
        }

        private void ValidarFechaConFrecuencia()
        {
             if (!Vuelo.Frecuencia.Contains(Fecha.DayOfWeek)) throw new Exception("La fecha no coincide con el vuelo.");
        }

        public override string ToString()
        {
            return $"Id: {Id} , Nombre: {Pasajero.Nombre} , Precio: {Precio} , Fecha: {Fecha} , NroVuelo {Vuelo.NroVuelo} \n ";
            ;
        }

        public decimal CalcularMargenGanancia()
        {
            return Vuelo.CalcularCostoPorAsiento() * 1.25m; //Margen de ganancia 25%

        }
        public decimal CalcularPrecioPasaje()
        {
            if(this.Pasajero is Ocasionales)
            {
                if(this.Equipaje == Equipaje.CABINA)
                {
                    return CalcularMargenGanancia() + 1.10m; // Precio base + 10% EQUIPAJE CABINA
                } 
                else if(this.Equipaje == Equipaje.BODEGA)
                {
                    return CalcularMargenGanancia() + 1.20m; // Precio base + 20% EQUIPAJE BODEGA
                }
            }
            if(this.Pasajero is Premium)
            {
                if(this.Equipaje == Equipaje.BODEGA)
                {
                    return CalcularMargenGanancia() + 1.05m; // Precio base + 5% EQUIPAJE BODEGA
                }
            }
            return CalcularMargenGanancia();
        }


    }
}
