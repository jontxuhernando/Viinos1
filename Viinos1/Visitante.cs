using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class Visitante : Personas
    {
        private int codigoReserva;   // el codigo de reserva es la clave primaria del visitante 
        private Boolean compraVino;  // es un booleano que indica si compra o no vino al finalizar la visita


        public Visitante():base ()
        {
            this.codigoReserva = 0;
            this.compraVino = false;    
        }

        public Visitante(int codReserva, Boolean compraVino, string dni, string nombre, string apellidos, int telefono) : base(dni, nombre, apellidos, telefono)
        {
            this.codigoReserva=codReserva;
            this.compraVino=compraVino; 
        }

        public int CodigoReserva { get => codigoReserva; set => codigoReserva = value; }
        public bool CompraVino { get => compraVino; set => compraVino = value; }
    }
}
