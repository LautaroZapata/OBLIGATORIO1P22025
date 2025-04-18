﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Cliente : Usuario
    {
        string documento;
        string nombre;
        string nacionalidad;

        public string Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public Cliente()
        {
        }

        public Cliente(string documento, string nombre, string nacionalidad, string mail, string password) : base(mail,password)
        {
            Documento = documento;
            Nombre = nombre;
            Nacionalidad = nacionalidad;
        }
    }
}
