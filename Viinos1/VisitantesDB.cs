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



    }
}
