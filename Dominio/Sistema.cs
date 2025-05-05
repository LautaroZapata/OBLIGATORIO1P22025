using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema instancia;

        List<Avion> listaAviones = new List<Avion>();
        List<Usuario> listaUsuarios = new List<Usuario>();
        List<Aeropuerto> listaAeropuertos = new List<Aeropuerto>();
        List<Ruta> listaRutas = new List<Ruta>();
        List<Vuelo> listaVuelos = new List<Vuelo>();
        List<Pasaje>listaPasajes = new List<Pasaje>();  

        public static Sistema Instancia
        {
            get
            {
                if (instancia == null) instancia = new Sistema();
                return instancia;
            }
        }
        private Sistema() 
        {
            // PRECARGA DE DATOS VA ACA ADENTRO
            //AgregarVuelo("AB1234",);
            //AgregarAvion();

        }

        // METODOS

        #region Vuelo
        public void AgregarVuelo(string nroVuelo, Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada, Avion avion, List<DayOfWeek> frecuencia)
        {
            try
            {
                ExisteVuelo(nroVuelo);
                ExisteAvion(avion);
                Ruta ruta = ExisteRuta(aeropuertoSalida, aeropuertoLlegada);
                Vuelo vuelo = new Vuelo(nroVuelo, ruta, avion, frecuencia);
                vuelo.Validar();
                listaVuelos.Add(vuelo);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExisteAvion(Avion avion)
        {
            if (!listaAviones.Contains(avion)) throw new Exception("El avion no existe.");
        }

        public void ExisteVuelo(string nroVuelo)
        {
            foreach (Vuelo unVuelo in listaVuelos)
            {
                if (unVuelo.NroVuelo.ToUpper() == nroVuelo.ToUpper()) throw new Exception("El vuelo ya existe");
            }
        }

        public Ruta ExisteRuta(Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada)
        {
            // recorremos lista de rutas y si existe la ruta la devuelve.
            
            foreach(Ruta unaRuta in listaRutas)
            {
                if (unaRuta.AeropuertoLlegada == aeropuertoLlegada && unaRuta.AeropuertoSalida == aeropuertoSalida) return unaRuta;
            }
            throw new Exception("No existe una ruta con los aeropuertos especificados.");
        }
        #endregion

        #region Pasaje
        public void AgregarPasaje(Vuelo vuelo, DateTime fecha, Cliente pasajero, Equipaje equipaje, decimal precio)
        {
            try
            {
                Pasaje pasaje = new Pasaje(vuelo, fecha, pasajero, equipaje, precio);
                pasaje.Validar();
                ValidarPasajero(pasajero);
                // CalcularPrecioPasaje() iría en este momento antes de la emision del pasaje.
                listaPasajes.Add(pasaje);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void ValidarPasajero(Cliente pasajero)
        {
            if (!listaUsuarios.Contains(pasajero)) throw new Exception("No existe el usuario");
        }
        #endregion

        #region Avion
        public void AgregarAvion(string)
        {

        }
        #endregion
    }
}
