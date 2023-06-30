using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class Departamento
    {
        int codDepartamento;  
        string nombreDepartamento;



        //constructor vacio
        public Departamento()
        {
            this.codDepartamento = 0;
            this.nombreDepartamento = "";
        }



        // constructor normal
        public Departamento(int codDepartamento, string nombreDepartamento)
        {
            this.codDepartamento = codDepartamento;
            this.nombreDepartamento = nombreDepartamento;
        }

        public int CodDepartamento { get => codDepartamento; set => codDepartamento = value; }
        public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
    }
}
