using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
    internal class ClientesDB
    {


        //Mostrar la registros de la tabla clientes
        static public void LeerClientes()   //esto va en clientesDB
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "SELECT * FROM Clientes";
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                OleDbCommand comando = new OleDbCommand(consulta, conexion);



                try
                {
                    conexion.Open();
                    using (OleDbDataReader miTabla = comando.ExecuteReader())  //a mi tabla traeme lo que lleva la select
                    {
                        Console.WriteLine("----------------Clientes--------------");
                        while (miTabla.Read())
                        {
                            Console.WriteLine("{0} {1} {2} {3} {4} {5} ", miTabla["NifCliente"].ToString(), miTabla["NombreCliente"].ToString(), miTabla["DireccionCliente"].ToString(), miTabla["TelefonoCliente"].ToString(), miTabla["InicioContratoCliente"].ToString(), miTabla["FinContratoCliente"].ToString());
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


        // Agregar clientes a la Base de datos
        static public void insertarCliente()   
        {
            Console.WriteLine("Inserta Nif");
            string nifCliente = Console.ReadLine();
            Console.WriteLine("Inserta nombre ");
            string nombreCliente = Console.ReadLine();
            Console.WriteLine("Inserta direccion");
            string direccionCliente = Console.ReadLine();
            Console.WriteLine("Inserta telefono");
            int telefonoCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta fecha de inicio del contrato");
            string fechaInicio = Console.ReadLine();
            Console.WriteLine("Inserta fecha fin de contrato");
            string fechaFin = Console.ReadLine();




            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "INSERT INTO Clientes (nifCliente,nombreCliente,direccionCliente,telefonoCliente,inicioContratoCliente,finContratoCliente) VALUES ('" + nifCliente + "','" + nombreCliente + "', '" + direccionCliente + "'," + telefonoCliente + ",'" + fechaInicio + "','" + fechaFin + "')";
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





        // Borrar el registro que le indiquemos de la tabla clientes
        static public void borrarCliente()
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";




            string consulta = "DELETE  FROM Clientes WHERE Id = ";
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
