using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class Visita
    {
        private int codVisita;
        private string fecha;
        private int codReserva;  //clave foranea de la tabla visitantes



        //constructor vacio

        public Visita()
        {
            this.codVisita = 0;
            this.fecha = "";
            this.codReserva = 0;
        }







        //constructor normal
        public Visita(int codVisita, string fecha, int codReserva)
        {
            this.codVisita = codVisita;
            this.fecha = fecha;
            this.codReserva = codReserva;
        }

        public int CodVisita { get => codVisita; set => codVisita = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int CodReserva { get => codReserva; set => codReserva = value; }
    }
}
