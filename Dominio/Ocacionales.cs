using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ocacionales : Cliente
    {
        bool elegible;


        public bool Elegible { get => elegible; set => elegible = value; }

        public Ocacionales()
        {
        }

        public Ocacionales(bool elegible)
        {
            Elegible = elegible;
        }
    }
}
