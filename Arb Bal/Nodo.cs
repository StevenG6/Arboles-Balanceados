using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arb_Bal
{
    class Nodo
    {
        public int Numero;
        public string Nombre;

        public Nodo EnlaceIzquierdo;
        public Nodo EnlaceDerecho;

        public int FE;

        public Nodo(int numero, string nombre)
        {
            Numero = numero;
            Nombre = nombre;
        }
    }
}
