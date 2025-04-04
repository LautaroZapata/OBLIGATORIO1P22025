using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador : Usuario
    {
        string apodo;
        string mail;
        string password;

        public string Apodo { get => apodo; set => apodo = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }

        public Administrador()
        {
        }

        public Administrador(string apodo, string mail, string password)
        {
            Apodo = apodo;
            Mail = mail;
            Password = password;
        }
    }
}
