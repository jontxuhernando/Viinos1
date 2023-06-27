using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viinos1
{
    internal class VisitasDB
    {


        static public void insertarVisita()
        {
            Console.WriteLine("Introduzca Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca Apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Inserta fecha ");
            string fecha = Console.ReadLine();
            Console.WriteLine("Inserta codigo de reserva");
            string codReserva = (Console.ReadLine());



            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "INSERT INTO Visitas (fecha, codReserva) VALUES ('" + fecha + "','" + codReserva + "')";
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                OleDbCommand comando = new OleDbCommand(consulta, conexion);



                try
                {
                    conexion.Open();
                    OleDbDataReader tablaVisitas = comando.ExecuteReader();

                    conexion.Close();
                    string respuesta;

                    Console.WriteLine("Desea adquier alguno de nuestros vinos? \n a) si \n b) no");
                    respuesta = Console.ReadLine();

                    if (respuesta == "a")
                    {
                        string vino;
                        Console.WriteLine("Que vino desea? \n - Aromas de Laguardia \n - Esencias");
                        vino = Console.ReadLine();

                        StreamWriter factura = new StreamWriter("C:\\Users\\Talio tecnico\\source\\repos\\reserva.txt");
                        factura.WriteLine("---------Su reserva------------- \n Muchas Gracias " + nombre + " " + apellido + " , Su visita esta programada para el dia " + fecha + " \n y ha comprado el vino: " + vino + "");
                        factura.Close();

                        StreamReader factura1 = new StreamReader("C:\\Users\\Talio tecnico\\source\\repos\\reserva.txt");
                        Console.WriteLine(factura1.ReadToEnd());
                        Console.ReadLine();




                    }
                    if (respuesta == "b")
                    {
                        StreamWriter factura = new StreamWriter("C:\\Users\\Talio tecnico\\source\\repos\\reserva.txt");
                        factura.WriteLine("---------Su reserva------------- \n Muchas Gracias " + nombre + " " + apellido + " , Su visita esta programada para el dia " + fecha + " ");
                        factura.Close();


                        StreamReader factura1 = new StreamReader("C:\\Users\\Talio tecnico\\source\\repos\\reserva.txt");
                        Console.WriteLine(factura1.ReadToEnd());
                        Console.ReadLine();


                    }





                }
                catch (Exception ex)
                {
                    Console.WriteLine("No funciona");
                }
            }

        }




    }
}
