using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
     class VinosDB
    {


        Vinos tv =new Vinos(100);
        Vino v = new Vino();



         public void LeerVinos()
        {
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
                            v.CodVino = miTabla.GetInt32(0);
                            v.Nombre = miTabla.GetString(1);
                            v.Anio = miTabla.GetInt32(2);
                            v.Tipo = miTabla.GetString(3);
                            v.TipoUva = miTabla.GetString(4);

                            Console.WriteLine(" ID: "+v.CodVino +" Nombre: "+v.Nombre+" Año: "+v.Anio+" Tipo: "+v.Tipo+" Tipo de Uva: "+v.TipoUva);
                            

                          
                            tv.aniadirVino(v);
                            tv.sumarCantVinos();
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








        public void insertarVino()
        {
            Console.WriteLine("Inserta nombre");
            string nombre = System.Console.ReadLine();
            Console.WriteLine("Inserta año ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta tipo");
            string tipo = (Console.ReadLine());
            Console.WriteLine("Inserta tipo de uva");
            string uva = (Console.ReadLine());




            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "INSERT INTO Vinos (nombre, anio,tipo,tipoUva) VALUES ('" + nombre + "'," + year + ",'" + tipo + "','" + uva + "')";
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                OleDbCommand comando = new OleDbCommand(consulta, conexion);



                try
                {
                    conexion.Open();
                    OleDbDataReader tablaVinos = comando.ExecuteReader();

                    conexion.Close();



                }
                catch (Exception ex)
                {
                    Console.WriteLine("No funciona");
                }
            }

        }


    }
}
