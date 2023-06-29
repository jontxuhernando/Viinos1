using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viinos1
{
    internal class EmpleadosDB
    {


        static public void insertarEmpleado()   //esto va a ClientesDB
        {
            Console.WriteLine("Inserta Dni");
            string dniVisitante = Console.ReadLine();
            Console.WriteLine("Inserta nombre ");
            string nombreEmpleado = Console.ReadLine();
            Console.WriteLine("Inserta apellido");
            string apellidoEmpleado = Console.ReadLine();
            Console.WriteLine("Inserta telefono");
            int telefonoEmpleado = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta codigo Departamento");
            int codDepartamento = int.Parse(Console.ReadLine());
           




            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "INSERT INTO Empleados (dniEmpleado,nombreEmpleado,apellidoEmpleado,telefonoEmpleado,codDepartamento) VALUES ('" + dniVisitante + "','" + nombreEmpleado + "', '" + apellidoEmpleado + "'," + telefonoEmpleado + "," + codDepartamento + ")";
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





        static public void LeerEmpleados()   //esto va en clientesDB
        {
            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "SELECT * FROM Empleados";
            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                OleDbCommand comando = new OleDbCommand(consulta, conexion);



                try
                {
                    conexion.Open();
                    using (OleDbDataReader miTabla = comando.ExecuteReader())  //a mi tabla traeme lo que lleva la select
                    {
                        Console.WriteLine("----------------Empleados--------------");
                        while (miTabla.Read())
                        {
                            Console.WriteLine("{0} {1} {2} {3} {4}  ", miTabla["DniEmpleado"].ToString(), miTabla["NombreEmpleado"].ToString(), miTabla["ApellidoEmpleado"].ToString(), miTabla["TelefonoEmpleado"].ToString(), miTabla["CodDepartamento"].ToString());
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
