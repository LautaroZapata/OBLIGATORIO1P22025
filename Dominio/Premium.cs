using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Premium : Cliente
    {
        int puntos;

        public int Puntos { get => puntos; set => puntos = value; }

        public Premium()
        {
        }

        public Premium(int puntos)
        {
            Puntos = puntos;
        }
    }
}
