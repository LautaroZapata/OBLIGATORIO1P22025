using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Usuario
    {
        string documento;
        string nombre;
        string mail;
        string password;
        string nacionalidad;

        public string Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public Cliente()
        {
        }

        public Cliente(string documento, string nombre, string mail, string password, string nacionalidad)
        {
            Documento = documento;
            Nombre = nombre;
            Mail = mail;
            Password = password;
            Nacionalidad = nacionalidad;
        }
    }
}
