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
        
        
       

        //Muestra los datos e información de la bodega 

        static public void acercaDe()
        {
            Console.WriteLine("-----------Bodega Navas Urkiaga-----------------");
            Console.WriteLine("Avenida Santo Domingo de la Calzada junto a finca Linares");
            Console.WriteLine("Haro , La Rioja");
            Console.ReadLine();

        }
        
        
        //inserta una visita en la base de datos , meterlo en VisitasDB


        
        
        
        //area privada

        static public void areaprivada()
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
                              //  LeerClientes();
                            break;

                            case 4:
                             //   insertarCliente();
                            break;

                            case 7:
                              //  insertarVino();
                            break;

                            case 8:
                              //  LeerVinos();
                            break;

           }



                }while (gestion!=0);
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
            Console.WriteLine("Seleccione que desea hacer \n 1) Ver vinos \n 2) Insertar Vino \n 3) Saber mas de nosotros \n 4) Area privada \n 0) Salir");
            op = int.Parse(Console.ReadLine());
            VinosDB wine = new VinosDB();

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
                         areaprivada();  //esta opcion abrira el area privada si el usuario y la contraseña son correctos
                        break;

                }
                Console.WriteLine("Seleccione que desea hacer \n 1) Ver nuestros vinos \n 2) Visitar nuestra Bodega \n 3) Saber mas de nosotros \n 4) Area privada \n 0) Salir");
                op = int.Parse(Console.ReadLine());
            } while (op != 0);




            /*   List<Ardoa> listaVinos = new List<Ardoa>()  // crea lista de vinos de la List de la clase Ardoa
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
            */








        }


        
    }
}
