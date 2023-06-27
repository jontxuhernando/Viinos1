using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinos1;

namespace Vinos1
{
     class listaVinos
    {

        
        private List<Vinos> _vinoss;
        private Random _rnd;
        private int _limite;
        private int _numVinos;


        public listaVinos(int limite)
        {
            this._vinoss = new List<Vinos>();
            _numVinos = 0;
            _limite = limite;
            _rnd = new Random();

        }
        

        public void LeerVinos()
        {
            int index = 0;
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "SELECT * FROM Vinos";
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                OleDbCommand comando = new OleDbCommand(consulta, conexion);



                try
                {
                    conexion.Open();
                    using (OleDbDataReader miTabla = comando.ExecuteReader())  //a mi tabla traeme lo que lleva la select
                    {
                        Console.WriteLine("----------------Nuestros Vinos--------------");
                        while (miTabla.Read())
                        {
                            Vinos v = new Vinos();
                            v.CodVino = miTabla.GetInt32(0);
                            v.Nombre = miTabla.GetString(1);
                            v.Anio = miTabla.GetInt32(2);
                            v.Tipo = miTabla.GetString(3);
                            v.TipoUva = miTabla.GetString(4);


                            _vinoss.Add(v);
                            index++;

                            Console.WriteLine(" ID: " + v.CodVino + " Nombre: " + v.Nombre + " Año: " + v.Anio + " Tipo: " + v.Tipo + " Tipo de Uva: " + v.TipoUva);



                            
                        }

                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ha chustao");
                }








            }
        }



    }
}
