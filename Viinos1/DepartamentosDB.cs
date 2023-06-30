using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viinos1
{
    internal class DepartamentosDB
    {


        static public void insertarDepartamento()
        {
            Console.WriteLine("Inserta Codigo de Departamento");
            string codDep = Console.ReadLine();
            Console.WriteLine("Inserta Nombre del Departamento ");
            string nomDep = Console.ReadLine();
            




            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "INSERT INTO Departamentos (codDepartamento,nombreDepartamento) VALUES (" + codDep + ",'" + nomDep + "')";
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




        static public void borrarDepartamento()
        {
            //La ruta de la BD
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";




            string consulta = "DELETE  FROM Departamentos WHERE Id = ";
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
