using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viinos1;

namespace Vinos1

{
     public class Bodega
    {


        VisitasDB visi = new VisitasDB();
        VisitantesDB visitor = new VisitantesDB();
        EmpleadosDB emp =new EmpleadosDB();
       

        //Muestra los datos e información de la bodega 

        static public void acercaDe()
        {
            Console.WriteLine("-----------Bodega Navas Urkiaga-----------------");
            Console.WriteLine("Avenida Santo Domingo de la Calzada junto a finca Linares");
            Console.WriteLine("Haro , La Rioja");
            Console.ReadLine();

        }
        
        
        //area privada

        static public void areaprivada()
        {
            
            Console.WriteLine("Usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Contraseña");
           
            string pass=Console.ReadLine();

            if(usuario=="Pepe" && pass == "patata1")
            {
                int gestion;
                do
                {
                    Console.WriteLine("Bienvenido "+usuario+ " , que quieres hacer hoy? \n 1) Mostrar Empleados \n 2) Mostrar Cliente \n 3) Añadir Empleado \n 4) Añadir Cliente \n 5) Borrar Empleado \n 6) Borrar Cliente \n 7) Insertar Vino \n 8) Mostrar Vinos \n 9) Borrar Vino \n 10) Insertar Visitante \n 11) Borrar Visitante \n 12) Insertar Departamento \n 13) Eliminar Departamento \n 0) Salir");
                    gestion = int.Parse(Console.ReadLine());
                    switch (gestion) {

                            case 1:
                                EmpleadosDB.LeerEmpleados();
                            break;


                            case 2:
                                ClientesDB.LeerClientes();
                            break;


                            case 3:
                                EmpleadosDB.insertarEmpleado();
                            break;


                            case 4:
                                ClientesDB.insertarCliente();
                            break;


                            case 5:
                            EmpleadosDB.borrarEmpleado();

                            break;


                            case 6:
                              ClientesDB.borrarCliente();
                            break;


                            case 7:
                            VinosDB.insertarVino();
                            break;


                            case 8:
                             VinosDB.leerVinos();
                            break;


                            case 9:
                                VinosDB.borrarVino();
                            break;


                            case 10:
                                VisitantesDB.insertarVisitante();
                            break;

                            case 11:
                                VisitantesDB.borrarVisitante();
                            break;


                            case 12:
                                DepartamentosDB.insertarDepartamento();
                            break;


                            case 13:
                                DepartamentosDB.borrarDepartamento();
                            break;



                       

                    }



                }while (gestion!=0);
                Console.WriteLine("Bienvenido " + usuario + " , que quieres hacer hoy? \n 1) Mostrar Empleados \n 2) Mostrar Cliente \n 3) Añadir Empleado \n 4) Añadir Cliente \n 5) Borrar Empleado \n 6) Borrar Cliente \n 7) Insertar Vino \n 8) Mostrar Vinos \n 9) Borrar Vino \n 10) Registrar Visitante \n 0) Salir");
                gestion = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }


        }
                        


      // MAIN //   



        string direccion;
        string climatologia;
        string calidad;

        public string Direccion { get => direccion; set => direccion = value; }
        public string Climatologia { get => climatologia; set => climatologia = value; }
        public string Calidad { get => calidad; set => calidad = value; }

       static void Main(string[] args)
        {

            int op;
            Console.WriteLine("Bienvenido a la Bodega");
            Console.WriteLine("Seleccione que desea hacer \n 1) Ver vinos \n 2) Visite la Bodega \n 3) Saber mas de nosotros \n 4) Area privada \n 0) Salir");
            op = int.Parse(Console.ReadLine());
            VinosDB wine = new VinosDB();
         
            
            
            

            //Menu Principal

            do
            {
                switch (op)
                {
                    case 1:
                        VinosDB.leerVinos();
                        break;

                    case 2:

                        VisitasDB.insertarVisita();
                        break;

                    case 3:
                        acercaDe();
                        break;

                    case 4:
                         areaprivada();  //esta opcion abrira el area privada si el usuario y la contraseña son correctos
                        break;

                }
                Console.WriteLine("Seleccione que desea hacer \n 1) Ver nuestros vinos \n 2) Visitar nuestra Bodega \n 3) Saber mas de nosotros \n 4) Area privada \n 0) Salir");
                op = int.Parse(Console.ReadLine());
            } while (op != 0);




            








        }


        
    }
}
