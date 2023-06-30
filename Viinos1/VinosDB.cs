using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
     public class VinosDB
    {


        Vinos tv =new Vinos(100);
        Vino v = new Vino();
       



         static public void leerVinos()
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








        static public void insertarVino()
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








        static public void borrarVino()
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";




            string consulta = "DELETE  FROM Vinos WHERE Id = ";
            int id;

            System.Console.WriteLine("¿Qué id quieres borrar?");
            id = int.Parse(System.Console.ReadLine());
            consulta = consulta + id;

            //Ver consulta
            System.Console.WriteLine(consulta);

            // Create a connection    
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                // Create a command and set its connection    
                OleDbCommand comando = new OleDbCommand(consulta, conexion);


                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    conexion.Open();
                    // Execute command    



                    OleDbDataReader miTabla = comando.ExecuteReader();
                    Console.WriteLine("Comando eliminado");

                    conexion.Close();











                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problemicas txato!!" + ex.Message);
                }

            }
            System.Console.ReadKey();

        }









    }
}
