using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class VisitantesDB
    {



        static public void insertarVisitante()   //esto va a ClientesDB
        {
            Console.WriteLine("Inserta Dni");
            string dniVisitante = Console.ReadLine();
            Console.WriteLine("Inserta nombre ");
            string nombreVisitante = Console.ReadLine();
            Console.WriteLine("Inserta apellido");
            string apellidoVisitante = Console.ReadLine();
            Console.WriteLine("Inserta telefono");
            int telefonoVisitante = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta codigo de Reserva");
            string codReservaVisitante = Console.ReadLine();
            Console.WriteLine("Compra Vino?");
            string compraVino = Console.ReadLine();




            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "INSERT INTO Visitantes (dniVisitante,nombreVisitante,apellidoVisitante,telefonoVisitante,codReserva,compraVino) VALUES ('" + dniVisitante + "','" + nombreVisitante + "', '" + apellidoVisitante + "'," + telefonoVisitante + ",'" + codReservaVisitante + "','" + compraVino + "')";
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                OleDbCommand comando = new OleDbCommand(consulta, conexion);



                try
                {
                    conexion.Open();
                    OleDbDataReader tablaVisitantes = comando.ExecuteReader();

                    conexion.Close();



                }
                catch (Exception ex)
                {
                    Console.WriteLine("No funciona");
                }
            }

        }


        static public void borrarVisitante()
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";




            string consulta = "DELETE  FROM Visitantes WHERE Id = ";
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
