﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ocasionales : Cliente
    {
        static Random random = new Random();
        bool elegible;


        public bool Elegible { get => elegible; set => elegible = value; }

        public Ocasionales()
        {
        }

        public Ocasionales(string documento, string nombre, string nacionalidad, string mail, string password) : base(documento, nombre, nacionalidad, mail, password)
        {
            Elegible = random.Next(0, 2) == 1; // Agarra un numero entre 0 y 2  [0,1], si da 1 es true si da 0 es false.
        }

        public override void Validar()
        {
            base.Validar();
        }

        private string EsElegible()
        {
            if (Elegible) return "Si";
            return "No";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Es Elegible: {EsElegible()}, Tipo de cliente: Ocasional \n";
        }

        
    }
}
