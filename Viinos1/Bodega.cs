using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1

{



    public class Bodega
    {
        
        
        //Lee la base de datos de vinos

        

        VinosDB wine=new VinosDB(); 

        //Leer base de datos de clientes



        static public void LeerClientes()
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







        //Inserta vinos en la base de datos

        


        //inserta un cliente en la base de datos

        static public void insertarCliente()
        {
            Console.WriteLine("Inserta Nif");
            string nifCliente = Console.ReadLine();
            Console.WriteLine("Inserta nombre ");
            string nombreCliente =Console.ReadLine();
            Console.WriteLine("Inserta direccion");
            string direccionCliente = Console.ReadLine();
            Console.WriteLine("Inserta telefono");
            int telefonoCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserta fecha de inicio del contrato");
            string fechaInicio = Console.ReadLine();
            Console.WriteLine("Inserta fecha fin de contrato");
            string fechaFin = Console.ReadLine();




            string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Talio tecnico\source\repos\Bodega.mdb";
            string consulta = "INSERT INTO Clientes (nifCliente,nombreCliente,direccionCliente,telefonoCliente,inicioContratoCliente,finContratoCliente) VALUES ('" + nifCliente + "','" + nombreCliente + "', '"+ direccionCliente +"',"+ telefonoCliente +",'"+ fechaInicio+ "','"+ fechaFin + "')";
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







        //Muestra los datos de la bodega

        static public void acercaDe()
        {
            Console.WriteLine("-----------Bodega Navas Urkiaga-----------------");
            Console.WriteLine("Avenida Santo Domingo de la Calzada junto a finca Linares");
            Console.WriteLine("Haro , La Rioja");
            Console.ReadLine();

        }












        //inserta una visita en la base de datos


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
                    
                    if(respuesta=="a")
                    {
                        string vino;
                        Console.WriteLine("Que vino desea? \n - Aromas de Laguardia \n - Esencias");
                        vino=Console.ReadLine();
                        
                        StreamWriter factura = new StreamWriter("C:\\Users\\Talio tecnico\\source\\repos\\reserva.txt");
                        factura.WriteLine("---------Su reserva------------- \n Muchas Gracias "+nombre+" "+apellido+" , Su visita esta programada para el dia " + fecha + " \n y ha comprado el vino: "+vino+"");
                        factura.Close();

                        StreamReader factura1 = new StreamReader("C:\\Users\\Talio tecnico\\source\\repos\\reserva.txt");
                        Console.WriteLine(factura1.ReadToEnd());
                        Console.ReadLine();
                        



                    }
                    if(respuesta == "b")
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
        
        
        //area privada

      /*  static public void areaprivada()
        {
            
            Console.WriteLine("Introduce Usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Intrdoduce contraseña");
           
            string pass=Console.ReadLine();

            if(usuario=="Logan" && pass == "patata1")
            {
                int gestion;
                do
                {
                    Console.WriteLine("Bienvenido "+usuario+" , que quieres hacer hoy? \n 1) Mostrar Empleados \n 2) Mostrar Clientes \n 3) Añadir Empleado \n 4) Añadir Cliente \n 5) Borrar Empleado \n 6) Borrar Cliente \n 7) Insertar Vino \n 8) Mostrar Vinos \n 9) Borrar Vino \n 0) Salir");
                    gestion = int.Parse(Console.ReadLine());
                    switch (gestion) {

                            case 2:
                                LeerClientes();
                            break;

                            case 4:
                                insertarCliente();
                            break;

                            case 7:
                                insertarVino();
                            break;

                            case 8:
                                LeerVinos();
                            break;

           }



                }while (gestion!=0);
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }


        }*/
                        


                       



                        




                        
                       
         







        string direccion;
        string climatologia;
        string calidad;

        public string Direccion { get => direccion; set => direccion = value; }
        public string Climatologia { get => climatologia; set => climatologia = value; }
        public string Calidad { get => calidad; set => calidad = value; }

         static void Main(string[] args)
        {
            /*    VinosDB wine=new VinosDB();
                int op;
                Console.WriteLine("Bienvenido a la Bodega");
                Console.WriteLine("Seleccione que desea hacer \n 1) Ver nuestros vinos \n 2) Visitar nuestra Bodega \n 3) Saber mas de nosotros \n 4) Area privada \n 0) Salir" );
                op=int.Parse(Console.ReadLine());


                //Menu Principal

                do
                {
                    switch (op)
                    {
                        case 1:
                            wine.LeerVinos();
                            break;

                        case 2:
                         wine.insertarVino();
                            break;

                        case 3:
                           acercaDe();
                            break;

                        case 4:
                      //   wine.areaprivada();  //esta opcion abrira el area privada si el usuario y la contraseña son correctos
                            break;

                    }
                    Console.WriteLine("Seleccione que desea hacer \n 1) Ver nuestros vinos \n 2) Visitar nuestra Bodega \n 3) Saber mas de nosotros \n 4) Area privada \n 0) Salir");
                    op = int.Parse(Console.ReadLine());
                } while (op != 0);

                */


            List<Ardoa> listaVinos = new List<Ardoa>()  // crea lista de vinos de la List de la clase Ardoa
            {
                new Ardoa()
                {
                    Nombre="Aromas de Laguardia",   // hace el nuevo ardoa con los atributos de la clase Ardoa
                    Anio=2015,
                    Tipo="Tinto"
                    
                },

                new Ardoa()
                {
                    Nombre="Esencias",
                    Anio=2020,
                    Tipo="Blanco"

                },
                
        };

            //listaVinos.Remove("Esencias");

            //recorre la lista con un array para mostrar los elementos 
            Console.WriteLine("------------------Lista de vinos----------------");

            for (int i = 0; i < listaVinos.Count; i++)
            {
                Console.WriteLine(listaVinos[i].Nombre + " es del año " + listaVinos[i].Anio);
            }
            Console.ReadKey();

        }


                
          

            



         


        
    }
}
