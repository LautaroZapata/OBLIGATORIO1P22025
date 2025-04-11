using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ocasionales : Cliente
    {
        bool elegible;


        public bool Elegible { get => elegible; set => elegible = value; }

        public Ocasionales()
        {
        }

        public Ocasionales(bool elegible, string documento, string nombre, string mail, string password, string nacionalidad) : base(documento, nombre, mail, password, nacionalidad)
        {
            Elegible = elegible;
        }
    }
}
