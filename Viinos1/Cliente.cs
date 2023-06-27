using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class Cliente
    {

        //atributos
       private int _nifCliente;
        private string _nombreCliente;
        private string _direccionCliente;
        private int _telefonoCliente;
        private string _inicioContratoCliente;
        private string _finContratoCliente;
     



        //constructor vacio
        public Cliente() { 
            this._nifCliente = 0;
            this._nombreCliente = "";
            this._direccionCliente = "";
            this._telefonoCliente = 0;
            this._inicioContratoCliente = "";
            this._finContratoCliente = "";
             
            }
           

          //constructor normal
          public Cliente(int nifCliente, string nombreCliente, string direccionCliente, int telefonoCliente, string inicioContratoCliente, string finContratoCliente)
        {
            this._nifCliente= nifCliente;
            this._nombreCliente= nombreCliente;
            this._direccionCliente =direccionCliente;
            this._telefonoCliente = telefonoCliente;
            this._inicioContratoCliente=inicioContratoCliente;
            this._finContratoCliente=finContratoCliente;
        }

        public int NifCliente { get => _nifCliente; set => _nifCliente = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string DireccionCliente { get => _direccionCliente; set => _direccionCliente = value; }
        public int TelefonoCliente { get => _telefonoCliente; set => _telefonoCliente = value; }
        public string InicioContratoCliente { get => _inicioContratoCliente; set => _inicioContratoCliente = value; }
        public string FinContratoCliente { get => _finContratoCliente; set => _finContratoCliente = value; }


        



    }
}
