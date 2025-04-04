using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Avion
    {
        string fabricante;
        string modelo;
        int cantAsientos;
        int alcance;
        decimal costoOperacionKm;

        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int CantAsientos { get => cantAsientos; set => cantAsientos = value; }
        public int Alcance { get => alcance; set => alcance = value; }
        public decimal CostoOperacionKm { get => costoOperacionKm; set => costoOperacionKm = value; }

        public Avion()
        {
        }

        public Avion(string fabricante, string modelo, int cantAsientos, int alcance, decimal costoOperacionKm)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            CantAsientos = cantAsientos;
            Alcance = alcance;
            CostoOperacionKm = costoOperacionKm;
        }


    }
}
