using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    abstract class Personas   //de esta clase van a colgar tanto visitantes como empleados
    {
        private string _dni;
        private string _nombre;
        private string _apellidos;
        private int _telefono;

        //constructor vacio

        public Personas()
        {
            this._dni = "";
            this._nombre = "";
            this._apellidos = "";
            this._telefono= 0;   
        }


        //constructor normal

        public Personas(string dni,string nombre, string apellidos, int telefono)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellidos =apellidos;
            this._telefono = telefono;
        }

        public string Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
    }
}
