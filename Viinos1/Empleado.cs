using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class Empleado:Personas
    {
        private int codDepartamento;  //clave foranea de la tabla departamentos 




        public Empleado():base()
        {
            this.codDepartamento = 0;

        }

        public Empleado(int codDepartamento, string dni, string nombre, string apellidos, int telefono) : base(dni, nombre,apellidos,telefono)
        {
            this.codDepartamento=codDepartamento;

        }

        public int CodDepartamento { get => codDepartamento; set => codDepartamento = value; }
    }

    
}
