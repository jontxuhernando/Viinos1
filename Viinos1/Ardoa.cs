using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class Ardoa
    {

        string nombre;
        int anio;
        string tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
