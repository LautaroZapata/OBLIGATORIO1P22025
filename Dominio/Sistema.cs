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

            #region PrecargaAviones
            AgregarAvion("Boeing", "737 MAX", 189, 6570, 5);
            AgregarAvion("Airbus", "A320neo", 180, 6300, 6);
            AgregarAvion("Embraer", "E195-E2", 132, 4815, 4);
            AgregarAvion("Bombardier", "CS300", 160, 6112, 7);
            #endregion

            #region PrecargaAeropuertos
            AgregarAeropuerto("MVD", "Montevideo", 1500.00m, 500.00m);
            AgregarAeropuerto("EZE", "Buenos Aires - Ezeiza", 1800.00m, 600.00m);
            AgregarAeropuerto("AEP", "Buenos Aires - Aeroparque", 1700.00m, 550.00m);
            AgregarAeropuerto("PDP", "Punta del Este", 1200.00m, 400.00m);
            AgregarAeropuerto("GRU", "São Paulo", 2000.00m, 700.00m);
            AgregarAeropuerto("SCL", "Santiago de Chile", 1900.00m, 650.00m);
            AgregarAeropuerto("LIM", "Lima", 2100.00m, 750.00m);
            AgregarAeropuerto("ASU", "Asunción", 1600.00m, 500.00m);
            AgregarAeropuerto("MIA", "Miami", 3000.00m, 1000.00m);
            AgregarAeropuerto("JFK", "Nueva York", 3500.00m, 1200.00m);
            AgregarAeropuerto("MAD", "Madrid", 3200.00m, 1100.00m);
            AgregarAeropuerto("BCN", "Barcelona", 3100.00m, 1050.00m);
            AgregarAeropuerto("LAX", "Los Ángeles", 3600.00m, 1250.00m);
            AgregarAeropuerto("DXB", "Dubái", 4000.00m, 1400.00m);
            AgregarAeropuerto("PEK", "Pekín", 4200.00m, 1500.00m);
            AgregarAeropuerto("COR", "Córdoba", 1550.00m, 480.00m);
            AgregarAeropuerto("MDZ", "Mendoza", 1580.00m, 500.00m);
            AgregarAeropuerto("CYD", "Colonia del Sacramento", 1100.00m, 390.00m);
            AgregarAeropuerto("SJO", "Salto", 1150.00m, 410.00m);
            AgregarAeropuerto("RIO", "Río de Janeiro", 1950.00m, 670.00m);
            #endregion

            #region PrecargaRutas
            AgregarRuta(DevolverAeropuerto("MVD"), DevolverAeropuerto("EZE"), 200);
            AgregarRuta(DevolverAeropuerto("MVD"), DevolverAeropuerto("GRU"), 1570);
            AgregarRuta(DevolverAeropuerto("MVD"), DevolverAeropuerto("SCL"), 1370);
            AgregarRuta(DevolverAeropuerto("EZE"), DevolverAeropuerto("LIM"), 3140);
            AgregarRuta(DevolverAeropuerto("GRU"), DevolverAeropuerto("MIA"), 6540);
            AgregarRuta(DevolverAeropuerto("SCL"), DevolverAeropuerto("MIA"), 6620);
            AgregarRuta(DevolverAeropuerto("PDP"), DevolverAeropuerto("AEP"), 320);
            AgregarRuta(DevolverAeropuerto("ASU"), DevolverAeropuerto("EZE"), 1080);
            AgregarRuta(DevolverAeropuerto("MVD"), DevolverAeropuerto("LAX"), 9900);
            AgregarRuta(DevolverAeropuerto("MVD"), DevolverAeropuerto("JFK"), 8600);
            AgregarRuta(DevolverAeropuerto("JFK"), DevolverAeropuerto("LAX"), 3980);
            AgregarRuta(DevolverAeropuerto("MAD"), DevolverAeropuerto("BCN"), 620);
            AgregarRuta(DevolverAeropuerto("MIA"), DevolverAeropuerto("BCN"), 7450);
            AgregarRuta(DevolverAeropuerto("DXB"), DevolverAeropuerto("PEK"), 5840);
            AgregarRuta(DevolverAeropuerto("COR"), DevolverAeropuerto("MDZ"), 660);
            AgregarRuta(DevolverAeropuerto("MDZ"), DevolverAeropuerto("SCL"), 480);
            AgregarRuta(DevolverAeropuerto("CYD"), DevolverAeropuerto("MVD"), 170);
            AgregarRuta(DevolverAeropuerto("SJO"), DevolverAeropuerto("PDP"), 550);
            AgregarRuta(DevolverAeropuerto("PEK"), DevolverAeropuerto("LAX"), 10000);
            AgregarRuta(DevolverAeropuerto("PEK"), DevolverAeropuerto("JFK"), 11000);
            AgregarRuta(DevolverAeropuerto("DXB"), DevolverAeropuerto("MAD"), 5700);
            AgregarRuta(DevolverAeropuerto("RIO"), DevolverAeropuerto("GRU"), 430);
            AgregarRuta(DevolverAeropuerto("RIO"), DevolverAeropuerto("MVD"), 1820);
            AgregarRuta(DevolverAeropuerto("COR"), DevolverAeropuerto("AEP"), 660);
            AgregarRuta(DevolverAeropuerto("CYD"), DevolverAeropuerto("EZE"), 190);
            AgregarRuta(DevolverAeropuerto("SJO"), DevolverAeropuerto("ASU"), 1080);
            AgregarRuta(DevolverAeropuerto("PDP"), DevolverAeropuerto("RIO"), 1930);
            AgregarRuta(DevolverAeropuerto("MVD"), DevolverAeropuerto("LIM"), 3120);
            AgregarRuta(DevolverAeropuerto("MIA"), DevolverAeropuerto("JFK"), 1760);
            AgregarRuta(DevolverAeropuerto("MAD"), DevolverAeropuerto("JFK"), 5760);
            #endregion
        }

        // METODOS

        #region Vuelo
        public void AgregarVuelo(string nroVuelo, Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada, Avion avion, List<DayOfWeek> frecuencia)
        {
            try
            {
                ExisteVuelo(nroVuelo);
                ExisteAvion(avion);
                Vuelo vuelo = new Vuelo(nroVuelo, ExisteRuta(aeropuertoSalida, aeropuertoLlegada), avion, frecuencia);
                vuelo.Validar();
                listaVuelos.Add(vuelo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        public void AgregarAvion(string fabricante, string modelo, int cantAsientos, int alcance, decimal costoOperacionKm)
        {
            try
            {
                Avion avion = new Avion(fabricante, modelo, cantAsientos, alcance, costoOperacionKm);
                ExisteAvion(avion);
                avion.Validar();
                listaAviones.Add(avion);

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

        #endregion

        #region Ruta
        public void AgregarRuta(Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada, int distancia)
        {
            try
            {
                Ruta ruta = new Ruta(aeropuertoSalida,aeropuertoLlegada,distancia);
                ruta.Validar();
                listaRutas.Add(ruta);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        #endregion

        #region Aeropuerto
        public void AgregarAeropuerto(string codigoIata, string ciudad, decimal costoOperacion, decimal costoTasas)
        {
            try
            {
                Aeropuerto aeropuerto = new Aeropuerto(codigoIata, ciudad, costoOperacion, costoTasas);
                aeropuerto.Validar();
                listaAeropuertos.Add(aeropuerto);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Aeropuerto DevolverAeropuerto(string codigoIata)
        {
            foreach (Aeropuerto unAeropuerto in listaAeropuertos)
            {
                if (unAeropuerto.CodigoIata == codigoIata) return unAeropuerto;
            }
            throw new Exception("No esta registrado el Aeropuerto");
        }
       
        #endregion
    }
}
