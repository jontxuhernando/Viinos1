using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Vinos1
{
    public class Vino
    {

       private int _codVino;
       private string _nombre;
       private int _anio;
       private string _tipo;
       private string _tipoUva;



        public Vino()
        {
            this._codVino = 0;
            this._nombre = "";
            this._anio = 0;
            this._tipo = "";
            this._tipoUva = "";

        }

        public Vino(int codVino ,string nombre, int anio, string tipo,  string tipoUva)
        {
            this._codVino= codVino;
            this._nombre = nombre;
            this._anio = anio;
            this._tipo = tipo;
            this._tipoUva = tipoUva;  
        }

        public int CodVino { get => _codVino; set => _codVino = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Anio { get => _anio; set => _anio = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string TipoUva { get => _tipoUva; set => _tipoUva = value; }



        


    }
}
