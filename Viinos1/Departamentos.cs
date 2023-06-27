using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class Departamentos
    {
        int codDepartamento;  
        string nombreDepartamento;



        //constructor vacio
        public Departamentos()
        {
            this.codDepartamento = 0;
            this.nombreDepartamento = "";
        }



        // constructor normal
        public Departamentos(int codDepartamento, string nombreDepartamento)
        {
            this.codDepartamento = codDepartamento;
            this.nombreDepartamento = nombreDepartamento;
        }

        public int CodDepartamento { get => codDepartamento; set => codDepartamento = value; }
        public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
    }
}
